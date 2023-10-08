//Author: Josh Werlein
//Purpose: to create a program that allows a user to enter a word and inform them if it is a palindrome.
//Date: 09/06/2023

namespace PalindromesLab_Jwerlein2
{
    public partial class PalindromeForm : Form
    {
        public PalindromeForm()
        {
            InitializeComponent();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int wordLength;
            string tempWord;
            string output;
            bool isPalindrome = true;

            //Assign Variables
            tempWord = wordTextBox.Text;
            wordLength = tempWord.Length;

            //Loop through the word to check if it is a palindrome.  
            for (int counter = 1; counter <= wordLength; counter++)
            {
                if (tempWord.Substring(counter - 1, 1) == tempWord.Substring(wordLength - counter, 1))
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            //Determine the results
            if (isPalindrome)
            {
                output = tempWord + " is a palindrome.";
            }
            else
            {
                output = tempWord + " is NOT a palindrome.";
            }

            //Display the results in resultslistBox
            resultsListBox.Items.Add(output);
        }
    }
}