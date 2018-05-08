using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the numberuppercase method accepts a string argument and returns the number of uppercase letters it contains
        private int NumberUpperCase(string str)
        {
            int upperCase = 0; //the number of uppercase letters
            //count the uppercase characters in str
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            //return the number of uppercase characters
            return upperCase;
        }

        //the numberlowercase method accepts a string argument and returns the number of lowercase letters it contains 
        private int NumberLowercase(string str)
        {
            int lowerCase = 0; // the number of lowercase letters

            //count the lowercase characters in str
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }
            //return the number of lowercase characters
            return lowerCase;
        }

        //the numberdigits method accepts a string argument and returns the number of numeric digits it contains. 
        private int NumberDigits(string str)
        {
            int digits = 0; //the number of digits
            //count the digits in str
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            //return the number of digits
            return digits;
        }


        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; //passwords minimum length

            //get the password from the textbox
            string password = passwordTextBox.Text;

            try
            {
                //validate the password
                if (password.Length >= MIN_LENGTH &&
                    NumberUpperCase(password) >= 1 &&
                    NumberLowercase(password) >= 1 &&
                    NumberDigits(password) >= 1)
                {
                    MessageBox.Show("The password is valid");

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;

                }
                else
                {
                    MessageBox.Show("The password does not meet " + "the requirements");

                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
