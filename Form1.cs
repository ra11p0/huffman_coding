using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decompressor_wpf
{
    public partial class Compressing : Form
    {
        string about = "Huffman coding algorithm.\n" +
                       "Przemysław Lenczewski.\n" +
                       "p.lenczewski@icloud.com\n" +
                       "29 april 2021";
        List<word> definedWords = new List<word>();

        public Compressing()
        {
            InitializeComponent();
        }

        public struct word
        {
            public char _character { get; set; }
            public string _symbol { get; }
            public word(char character, string symbol)
            {
                _character = character;
                _symbol = symbol;
            }
        }

        public struct wordStatisticsElement
        {
            public int _count { get;}
            public char _character { get; }

            public wordStatisticsElement(char znak)
            {
                _character = znak;
                _count = 1;
            }
            public wordStatisticsElement(char znak, int count)
            {
                _character = znak;
                _count = count;
            }
        }

        static string toBinary(int number, int wordSize)
        {
            string result = "";
            result = Convert.ToString(number, 2);
            while (result.Length < wordSize)
            {
                result = "0" + result;
            }
            return result;
        }

        private void wordSizeBox_Validating(object sender, EventArgs e)
        {
            int value;
            definedWords.Clear();
            if (int.TryParse(wordSizeBox.Text, out value))
            {
                if (value <= 0 || value > 8)
                {
                    MessageBox.Show("Word size must be in a range of 1 to 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wordSizeBox.Text = "";
                }
                else
                {
                    int tempInt = definedWords.Any() ? definedWords.Count : 0;
                    while (definedWords.Count <= Math.Pow(2, value))
                    {
                        definedWords.Add(new word(new char(), toBinary(tempInt, value)));
                        tempInt++;
                    }
                    while (definedWords.Count > Math.Pow(2, value))
                    {
                        definedWords.RemoveAt(definedWords.FindLastIndex(x => true));
                    }
                    wordsGrid.Rows.Clear();
                    foreach (word _word in definedWords)
                    {
                        string[] tempString = { _word._symbol, _word._character.ToString() };
                        wordsGrid.Rows.Add(tempString);
                    }
                }
            }
            else if (wordSizeBox.Text != "")
            {
                MessageBox.Show("Word size must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wordSizeBox.Text = "";
            }
        }

        private void wordsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (wordsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            if (wordsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length == 1)
            {
                word tempWord = definedWords[e.RowIndex];
                tempWord._character = (Convert.ToChar(wordsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                definedWords[e.RowIndex] = tempWord;
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            output.Text = "";
            string tempString = "";
            foreach (char character in input.Text)
            {
                if (character != '0' && character != '1')
                {
                    MessageBox.Show("Encoded field cannot contain characters diferent than 0 and 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tempString = tempString + character;
                if (tempString.Length == Convert.ToInt16(wordSizeBox.Text))
                {
                    output.Text = output.Text + definedWords.Find(x => x._symbol == tempString)._character;
                    float progress = output.TextLength * Convert.ToInt16(wordSizeBox.Text.ToString());
                    progress = progress / input.TextLength;
                    progressBar.Value = (int)(progress * 100);
                    tempString = "";
                }
            }
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            output.Text = "";
            string result = "";
            string inputString = input.Text;
            if (predefinedDictionary.Checked)
            {
                foreach (char character in inputString)
                {
                    bool errorWatchdog = true;
                    foreach (DataGridViewRow row in wordsGrid.Rows)
                    {
                        if (row.Cells[1].Value != null)
                        {
                            if (character.ToString() == row.Cells[1].Value.ToString())
                            {
                                result = result + row.Cells[0].Value.ToString();
                                result = result + definedWords.Find(x => x._character == character)._symbol;
                                float progress = result.Length / Convert.ToInt16(wordSizeBox.Text.ToString());
                                progress = progress / input.TextLength;
                                progressBar.Value = (progress * 100) > 100 ? 100 : (int)(progress * 100);
                                errorWatchdog = false;
                            }
                        }
                    }
                    if (errorWatchdog)
                    {
                        MessageBox.Show("Undefined character: " + character, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                output.Text = result;
            }
            else
            {
                List<wordStatisticsElement> statistics = new List<wordStatisticsElement>();
                foreach (char character in inputString)
                {
                    var temp = from wordStatisticsElement in statistics where wordStatisticsElement._character == character select wordStatisticsElement;

                    if (!temp.Any()) statistics.Add(new wordStatisticsElement(character));
                    else
                    {
                        statistics[statistics.FindIndex(x => x._character == temp.ElementAt(0)._character)] = new wordStatisticsElement(temp.ElementAt(0)._character, temp.ElementAt(0)._count + 1);
                    }
                }
                var sortedStatistisc = statistics.OrderBy(x => x._count).Reverse().ToList();
                int wordSize = Convert.ToString(statistics.Count - 1, 2).Length;
                wordSizeBox.Text = wordSize.ToString();
                definedWords.Clear();
                foreach (wordStatisticsElement element in sortedStatistisc)
                {
                    definedWords.Add(new word(element._character, toBinary(sortedStatistisc.FindIndex(x => x._character == element._character), wordSize)));
                }
                wordsGrid.Rows.Clear();
                foreach (word _word in definedWords)
                {
                    string[] tempString = { _word._symbol, _word._character.ToString() };
                    wordsGrid.Rows.Add(tempString);
                }

                foreach (char character in inputString)
                {
                    result = result + definedWords.Find(x => x._character == character)._symbol;
                    float progress = result.Length / wordSize;
                    progress = progress / input.TextLength;
                    progressBar.Value = (int)(progress * 100);
                }
                output.Text = result;
                numberOfBits.Text = output.TextLength.ToString() + " bits, " + (output.TextLength/8).ToString() + " bytes, " + ((output.TextLength / 8)/1024).ToString() + " KB.";
            }
            float compressinRateContainer = Convert.ToSingle(wordSizeBox.Text)/8;
            compressionRate.Text = "Compression rate: " + compressinRateContainer*100 + " %.";
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(about, "About.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
