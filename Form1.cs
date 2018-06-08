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

        private bool ValidInputs()
        {
            if(txtNumber1.Text == "")
            {
                MessageBox.Show("Please enter a first value.");
                txtNumber1.Focus();
                return false;
            }
            try
            {
                int.Parse(txtNumber1.Text);
            }
            catch
            {
                MessageBox.Show("The first number must be a whole number");
                txtNumber1.Text = "";
                txtNumber1.Focus();
                return false;
            }
            if (txtNumber2.Text == "")
            {
                MessageBox.Show("Please enter a second value.");
                txtNumber2.Focus();
                return false;
            }
            try
            {
                int.Parse(txtNumber2.Text);
            }
            catch
            {
                MessageBox.Show("The second number must be a whole number");
                txtNumber2.Text = "";
                txtNumber2.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == false) return;
            txtAnswer.Text =  calculateAnswer("Add");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == false) return;
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == false) return;
            if (txtNumber2.Text == "0" || txtNumber2.Text == "-0")
            {
                MessageBox.Show("You cannot divide by zero.");
                return;
            }
            txtAnswer.Text = calculateAnswer("Modulus");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == false) return;
            txtAnswer.Text = calculateAnswer("Subtract");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == false) return;
            if (txtNumber2.Text == "0" || txtNumber2.Text == "-0")
            {
                MessageBox.Show("You cannot divide by zero.");
                return;
            }
            txtAnswer.Text = calculateAnswer("Divide");
        }

        public string calculateAnswer(string operation)
        {          
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int sum = 0;

            switch (operation)
            {
                case "Add":
                    {
                        sum = number1 + number2;
                        break;
                    }
                case "Subtract":
                    {
                        sum = number1 - number2;
                        break;
                    }
                case "Multiply":
                    {
                        sum = number1 * number2;
                        break;
                    }
                case "Divide":
                    {
                        sum = number1 / number2;
                        break;
                    }
                case "Modulus":
                    {
                        sum = number1 % number2;
                        break;
                    }
            }

            return sum.ToString();
        }
    }
}
