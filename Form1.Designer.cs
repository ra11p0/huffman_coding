
namespace decompressor_wpf
{
    partial class Compressing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordSizeBox = new System.Windows.Forms.TextBox();
            this.wordSizeLabel = new System.Windows.Forms.Label();
            this.listOfWordsLabel = new System.Windows.Forms.Label();
            this.wordsGrid = new System.Windows.Forms.DataGridView();
            this.gridSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.predefinedDictionary = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.numberOfBits = new System.Windows.Forms.Label();
            this.numberOfBitsLabel = new System.Windows.Forms.Label();
            this.compressionRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordsGrid)).BeginInit();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordSizeBox
            // 
            this.wordSizeBox.Location = new System.Drawing.Point(381, 415);
            this.wordSizeBox.Name = "wordSizeBox";
            this.wordSizeBox.Size = new System.Drawing.Size(22, 23);
            this.wordSizeBox.TabIndex = 1;
            this.wordSizeBox.TextChanged += new System.EventHandler(this.wordSizeBox_Validating);
            this.wordSizeBox.Validating += new System.ComponentModel.CancelEventHandler(this.wordSizeBox_Validating);
            // 
            // wordSizeLabel
            // 
            this.wordSizeLabel.AutoSize = true;
            this.wordSizeLabel.Location = new System.Drawing.Point(279, 418);
            this.wordSizeLabel.Name = "wordSizeLabel";
            this.wordSizeLabel.Size = new System.Drawing.Size(96, 15);
            this.wordSizeLabel.TabIndex = 2;
            this.wordSizeLabel.Text = "Word size in bits:";
            // 
            // listOfWordsLabel
            // 
            this.listOfWordsLabel.AutoSize = true;
            this.listOfWordsLabel.BackColor = System.Drawing.Color.Transparent;
            this.listOfWordsLabel.Location = new System.Drawing.Point(12, 9);
            this.listOfWordsLabel.Name = "listOfWordsLabel";
            this.listOfWordsLabel.Size = new System.Drawing.Size(64, 15);
            this.listOfWordsLabel.TabIndex = 4;
            this.listOfWordsLabel.Text = "Dictionary:";
            // 
            // wordsGrid
            // 
            this.wordsGrid.AllowUserToAddRows = false;
            this.wordsGrid.AllowUserToDeleteRows = false;
            this.wordsGrid.AllowUserToResizeRows = false;
            this.wordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridSymbol,
            this.gridCharacter});
            this.wordsGrid.Location = new System.Drawing.Point(12, 27);
            this.wordsGrid.Name = "wordsGrid";
            this.wordsGrid.RowHeadersVisible = false;
            this.wordsGrid.RowTemplate.Height = 25;
            this.wordsGrid.Size = new System.Drawing.Size(261, 411);
            this.wordsGrid.TabIndex = 5;
            this.wordsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.wordsGrid_CellEndEdit);
            // 
            // gridSymbol
            // 
            this.gridSymbol.HeaderText = "Symbol";
            this.gridSymbol.Name = "gridSymbol";
            this.gridSymbol.ReadOnly = true;
            this.gridSymbol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridCharacter
            // 
            this.gridCharacter.HeaderText = "Character";
            this.gridCharacter.MaxInputLength = 1;
            this.gridCharacter.Name = "gridCharacter";
            this.gridCharacter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(279, 311);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(509, 96);
            this.input.TabIndex = 6;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(279, 194);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(509, 96);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(279, 293);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(38, 15);
            this.inputLabel.TabIndex = 8;
            this.inputLabel.Text = "Input:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(279, 176);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(48, 15);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Output:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(723, 413);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(65, 25);
            this.decodeButton.TabIndex = 10;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(652, 413);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(65, 25);
            this.encodeButton.TabIndex = 11;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // predefinedDictionary
            // 
            this.predefinedDictionary.AutoSize = true;
            this.predefinedDictionary.Location = new System.Drawing.Point(423, 417);
            this.predefinedDictionary.Name = "predefinedDictionary";
            this.predefinedDictionary.Size = new System.Drawing.Size(211, 19);
            this.predefinedDictionary.TabIndex = 12;
            this.predefinedDictionary.Text = "Use predefined dictionary(Encode).";
            this.predefinedDictionary.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(360, 149);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(428, 27);
            this.progressBar.TabIndex = 13;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Location = new System.Drawing.Point(279, 146);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(75, 15);
            this.progressBarLabel.TabIndex = 14;
            this.progressBarLabel.Text = "Progress bar:";
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.compressionRate);
            this.infoBox.Controls.Add(this.infoButton);
            this.infoBox.Controls.Add(this.numberOfBits);
            this.infoBox.Controls.Add(this.numberOfBitsLabel);
            this.infoBox.Location = new System.Drawing.Point(279, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(509, 131);
            this.infoBox.TabIndex = 15;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Information:";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(444, 102);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(59, 23);
            this.infoButton.TabIndex = 2;
            this.infoButton.Text = "About";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // numberOfBits
            // 
            this.numberOfBits.AutoSize = true;
            this.numberOfBits.Location = new System.Drawing.Point(96, 15);
            this.numberOfBits.Name = "numberOfBits";
            this.numberOfBits.Size = new System.Drawing.Size(13, 15);
            this.numberOfBits.TabIndex = 1;
            this.numberOfBits.Text = "0";
            // 
            // numberOfBitsLabel
            // 
            this.numberOfBitsLabel.AutoSize = true;
            this.numberOfBitsLabel.Location = new System.Drawing.Point(7, 15);
            this.numberOfBitsLabel.Name = "numberOfBitsLabel";
            this.numberOfBitsLabel.Size = new System.Drawing.Size(83, 15);
            this.numberOfBitsLabel.TabIndex = 0;
            this.numberOfBitsLabel.Text = "Size of output:";
            // 
            // compressionRate
            // 
            this.compressionRate.AutoSize = true;
            this.compressionRate.Location = new System.Drawing.Point(7, 30);
            this.compressionRate.Name = "compressionRate";
            this.compressionRate.Size = new System.Drawing.Size(106, 15);
            this.compressionRate.TabIndex = 3;
            this.compressionRate.Text = "Compression rate: ";
            // 
            // Compressing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.predefinedDictionary);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.wordsGrid);
            this.Controls.Add(this.listOfWordsLabel);
            this.Controls.Add(this.wordSizeLabel);
            this.Controls.Add(this.wordSizeBox);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Compressing";
            this.Text = "Compressing";
            ((System.ComponentModel.ISupportInitialize)(this.wordsGrid)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox wordSizeBox;
        private System.Windows.Forms.Label wordSizeLabel;
        private System.Windows.Forms.Label listOfWordsLabel;
        private System.Windows.Forms.DataGridView wordsGrid;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.CheckBox predefinedDictionary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCharacter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label numberOfBits;
        private System.Windows.Forms.Label numberOfBitsLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label compressionRate;
    }
}

