namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.letterSelectionText = new System.Windows.Forms.TextBox();
            this.submitLetter = new System.Windows.Forms.Button();
            this.difficultySetting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateWord = new System.Windows.Forms.Button();
            this.wordSubmit = new System.Windows.Forms.Button();
            this.wordSelectionText = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainCanvas = new System.Windows.Forms.Panel();
            this.livesRemaining = new System.Windows.Forms.Label();
            this.currentGuesses = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(635, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 339);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // letterSelectionText
            // 
            this.letterSelectionText.Location = new System.Drawing.Point(30, 64);
            this.letterSelectionText.Name = "letterSelectionText";
            this.letterSelectionText.Size = new System.Drawing.Size(100, 20);
            this.letterSelectionText.TabIndex = 1;
            // 
            // submitLetter
            // 
            this.submitLetter.Location = new System.Drawing.Point(30, 90);
            this.submitLetter.Name = "submitLetter";
            this.submitLetter.Size = new System.Drawing.Size(100, 23);
            this.submitLetter.TabIndex = 2;
            this.submitLetter.Text = "Submit Letter";
            this.submitLetter.UseVisualStyleBackColor = true;
            this.submitLetter.Click += new System.EventHandler(this.submitLetter_Click);
            // 
            // difficultySetting
            // 
            this.difficultySetting.FormattingEnabled = true;
            this.difficultySetting.Items.AddRange(new object[] {
            "Choose  Difficulty",
            "Easy",
            "Medium",
            "Hard",
            "Very Hard"});
            this.difficultySetting.Location = new System.Drawing.Point(14, 91);
            this.difficultySetting.Name = "difficultySetting";
            this.difficultySetting.Size = new System.Drawing.Size(135, 21);
            this.difficultySetting.TabIndex = 3;
            this.difficultySetting.SelectedIndexChanged += new System.EventHandler(this.difficultySetting_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Difficulty Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hangman";
            // 
            // generateWord
            // 
            this.generateWord.Location = new System.Drawing.Point(160, 91);
            this.generateWord.Name = "generateWord";
            this.generateWord.Size = new System.Drawing.Size(75, 23);
            this.generateWord.TabIndex = 7;
            this.generateWord.Text = "Generate";
            this.generateWord.UseVisualStyleBackColor = true;
            this.generateWord.Click += new System.EventHandler(this.generateWord_Click);
            // 
            // wordSubmit
            // 
            this.wordSubmit.Location = new System.Drawing.Point(233, 90);
            this.wordSubmit.Name = "wordSubmit";
            this.wordSubmit.Size = new System.Drawing.Size(100, 23);
            this.wordSubmit.TabIndex = 9;
            this.wordSubmit.Text = "Submit Word";
            this.wordSubmit.UseVisualStyleBackColor = true;
            this.wordSubmit.Click += new System.EventHandler(this.wordSubmit_Click);
            // 
            // wordSelectionText
            // 
            this.wordSelectionText.Location = new System.Drawing.Point(233, 64);
            this.wordSelectionText.Name = "wordSelectionText";
            this.wordSelectionText.Size = new System.Drawing.Size(100, 20);
            this.wordSelectionText.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(454, 90);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.currentGuesses);
            this.panel2.Controls.Add(this.livesRemaining);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.wordSelectionText);
            this.panel2.Controls.Add(this.wordSubmit);
            this.panel2.Controls.Add(this.letterSelectionText);
            this.panel2.Controls.Add(this.submitLetter);
            this.panel2.Location = new System.Drawing.Point(5, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 150);
            this.panel2.TabIndex = 1;
            // 
            // mainCanvas
            // 
            this.mainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCanvas.Location = new System.Drawing.Point(5, 136);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(617, 330);
            this.mainCanvas.TabIndex = 1;
            // 
            // livesRemaining
            // 
            this.livesRemaining.AutoSize = true;
            this.livesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesRemaining.Location = new System.Drawing.Point(26, 16);
            this.livesRemaining.Name = "livesRemaining";
            this.livesRemaining.Size = new System.Drawing.Size(104, 13);
            this.livesRemaining.TabIndex = 8;
            this.livesRemaining.Text = "Lives Remaining:";
            // 
            // currentGuesses
            // 
            this.currentGuesses.AutoSize = true;
            this.currentGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGuesses.Location = new System.Drawing.Point(229, 16);
            this.currentGuesses.Name = "currentGuesses";
            this.currentGuesses.Size = new System.Drawing.Size(108, 13);
            this.currentGuesses.TabIndex = 11;
            this.currentGuesses.Text = "Current Guesses: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 658);
            this.Controls.Add(this.mainCanvas);
            this.Controls.Add(this.generateWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.difficultySetting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox letterSelectionText;
        private System.Windows.Forms.Button submitLetter;
        private System.Windows.Forms.ComboBox difficultySetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateWord;
        private System.Windows.Forms.Button wordSubmit;
        private System.Windows.Forms.TextBox wordSelectionText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainCanvas;
        private System.Windows.Forms.Label livesRemaining;
        private System.Windows.Forms.Label currentGuesses;
    }
}

