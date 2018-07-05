using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidNumbers() // using a bool variable to see if the numbers a valid for number box 1 and 2
        {
            if (txtNumber1.Text == "") // if the textbox number 1 is blank
            {
                MessageBox.Show("Please enter a number.");
                return false; // will return false if blank
            }
            try
            {
                int.Parse(txtNumber1.Text); // is number an integer in the number 1 box
            }
            catch
            {
                MessageBox.Show("The number field has to be a whole integer"); // catch if it isn't a whole integer
                txtNumber1.Text = "";
                return false; // return false if not an integer or whole number
            }
            if (txtNumber2.Text == "") // if number 2 textbox is blank
            {
                MessageBox.Show("Please enter a second number.");
                return false; //return false if blank
            }
            try
            {
                int.Parse(txtNumber2.Text); // to see if number 2 text box is an integer
            }
            catch
            {
                MessageBox.Show("The number field has to be a whole integer"); // catch if not a whole integer
                txtNumber2.Text = "";
                return false; // return false if not an integer or whole number
            }
            return true; // return true if they are both valid numbers
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidNumbers() == false) return; // run valid numbers method to check numbers
            txtAnswer.Text = calculateAnswer("Add");
        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (ValidNumbers() == false) return;// run valid numbers method to check numbers
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            if (ValidNumbers() == false) return;// run valid numbers method to check numbers
            if (txtNumber2.Text == "0" || txtNumber2.Text == "-0") // if text box number 2 is = to 0 or is == -0 = exception
            {
                MessageBox.Show("cannot be divisible by 0."); // cannot divide by 0 for modulus
                return;
            }
            txtAnswer.Text = calculateAnswer("Modulus");
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (ValidNumbers() == false) return;// run valid numbers method to check numbers
            txtAnswer.Text = calculateAnswer("Subtract");
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidNumbers() == false) return;// run valid numbers method to check numbers
            if (txtNumber2.Text == "0" || txtNumber2.Text == "-0") // if text box number 2 is = to 0 or is == -0 = exception
            {
                MessageBox.Show("cannot be divisible by 0."); // cannot divide by 0 for division
                return;
            }
            txtAnswer.Text = calculateAnswer("Divide");
        }


        public string calculateAnswer(string operation) // case swtich statements
        {
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int sum = 0;


            switch (operation)
            {
                case "Add":
                    {
                        sum = number1 + number2; // changed from minus to plus operation
                        break;
                    }
                case "Subtract":
                    {
                        sum = number1 - number2; // changed from plus to minus operation
                        break;
                    }
                case "Multiply":
                    {
                        sum = number1 * number2; // changed from divide to multiply operation
                        break;
                    }
                case "Divide":
                    {
                        sum = number1 / number2; // changed from multiply to divide operation
                        break;
                    }
                case "Modulus":
                    {
                        sum = number1 % number2; // correct
                        break;
                    }
            }


            return sum.ToString();
        }
    }
}

