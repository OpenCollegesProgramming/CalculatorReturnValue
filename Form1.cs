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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAnswer.Text =  calculateAnswer("Add");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Multiply");
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Modulus");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Subtract");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = calculateAnswer("Divide");
        }

        public string calculateAnswer(string operation)
        {
            CalculatorUtility.Lib.Calculator calculator = new CalculatorUtility.Lib.Calculator();
            return calculator.calculateAnswer(txtNumber1.Text, txtNumber2.Text, operation);
        }
    }
}
