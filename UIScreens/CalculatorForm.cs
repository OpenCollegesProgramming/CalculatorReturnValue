using Calculator.BusinessLogic;
using System;
using System.Windows.Forms;

namespace Calculator.UIScreens
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAnswer.Text =  CalculatorOperations.CalculateAnswer("Add", txtNumber1.Text, txtNumber2.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = CalculatorOperations.CalculateAnswer("Multiply", txtNumber1.Text, txtNumber2.Text);
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = CalculatorOperations.CalculateAnswer("Modulus", txtNumber1.Text, txtNumber2.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = CalculatorOperations.CalculateAnswer("Subtract", txtNumber1.Text, txtNumber2.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = CalculatorOperations.CalculateAnswer("Divide", txtNumber1.Text, txtNumber2.Text);
        }

    }
}
