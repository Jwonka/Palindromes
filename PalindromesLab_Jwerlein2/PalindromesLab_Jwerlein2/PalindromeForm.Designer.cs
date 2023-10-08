//Author: Josh Werlein
//Purpose: to create a program that allows a user to enter a word and inform them if it is a palindrome.
//Date: 09/06/2023

namespace PalindromesLab_Jwerlein2
{
    partial class PalindromeForm
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
            labelPhraseBox = new Label();
            wordTextBox = new TextBox();
            analyzeButton = new Button();
            resultsListBox = new ListBox();
            SuspendLayout();
            // 
            // labelPhraseBox
            // 
            labelPhraseBox.ForeColor = Color.Black;
            labelPhraseBox.Location = new Point(61, 47);
            labelPhraseBox.Name = "labelPhraseBox";
            labelPhraseBox.Size = new Size(146, 28);
            labelPhraseBox.TabIndex = 0;
            labelPhraseBox.Text = "Type in a Word:";
            // 
            // wordTextBox
            // 
            wordTextBox.BackColor = Color.FromArgb(192, 192, 0);
            wordTextBox.Location = new Point(213, 47);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(368, 31);
            wordTextBox.TabIndex = 1;
            // 
            // analyzeButton
            // 
            analyzeButton.BackColor = Color.Gold;
            analyzeButton.Location = new Point(213, 126);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(368, 48);
            analyzeButton.TabIndex = 2;
            analyzeButton.Text = "Analyze Word";
            analyzeButton.UseVisualStyleBackColor = false;
            analyzeButton.Click += analyzeButton_Click;
            // 
            // resultsListBox
            // 
            resultsListBox.BackColor = Color.FromArgb(192, 192, 0);
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 25;
            resultsListBox.Location = new Point(61, 225);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(520, 204);
            resultsListBox.TabIndex = 3;
            // 
            // PalindromeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(resultsListBox);
            Controls.Add(analyzeButton);
            Controls.Add(wordTextBox);
            Controls.Add(labelPhraseBox);
            Name = "PalindromeForm";
            Text = "Type in a Word to see if it is a Palindrome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPhraseBox;
        private TextBox wordTextBox;
        private Button analyzeButton;
        private ListBox resultsListBox;
    }
}