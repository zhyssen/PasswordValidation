using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordValidation
{
    public partial class PasswordValidationForm : Form
    {
        public PasswordValidationForm()
        {
            InitializeComponent();
        }

        // NumberUppercase function checks to make sure there is an uppercase
        // character in the password
        private int NumberUpperCase (string str)
        {
            int upperCase = 0;      // Number of uppercase characters

            // Count the number of uppercase characters
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            return upperCase;
        }

        // NumberLowercase function checks to make sure there is a lowercase
        // character in the password
        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;      // Number of lowercase characters

            // Count the number of lowercase characters
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }
            return lowerCase;
        }

        // NumberNumeric function checks to make sure there is a numberic
        // character in the password
        private int NumberNumeric(string str)
        {
            int digit = 0;      // Number of numeric characters

            // Count the number of numeric characters
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digit++;
                }
            }
            return digit;
        }

        // NumberSpecial function checks to make sure there is a special
        // character in the password
        private int NumberSpecial(string str)
        {
            int special = 0;      // Number of special characters

            // Count the number of special characters
            foreach (char ch in str)
            {
                if (char.IsSymbol(ch))
                {
                    special++;
                }
            }
            return special;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;       // Minimum length for the password

            // Get the password from the textbox
            string password = passwordTextBox.Text;

            // Validate the password
            if (password.Length >= MIN_LENGTH && NumberUpperCase(password) >= 1 && 
                NumberLowerCase(password) >= 1 && NumberNumeric(password) >= 1 && 
                NumberSpecial(password) >= 1)
            {
                MessageBox.Show("The password is valid");
            }
            else
            {
                MessageBox.Show("The password does not meet the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
