using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblPalindrome.Text = textBoxWord.Text;
            String word = textBoxWord.Text.ToLower();
            bool isPalindrome = palindromeChecker(word);
            
            if (isPalindrome)
            {
                lblPalindrome.Text += " is a Palindrome.";
            }
            else
            {
                lblPalindrome.Text += " is not a Palindrome.";
            }
        }

        //method will check whether string is palindrome
        private bool palindromeChecker(String word)
        {
            //split word into array of letters to check values
            char[] letters = word.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if(letters[letters.Length - 1 - i] == letters[i])
                {
                    continue;
                } else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
