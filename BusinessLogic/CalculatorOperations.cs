using System;

namespace Calculator.BusinessLogic
{
    public static class CalculatorOperations
    {
        public static string CalculateAnswer(string operation, string txtNumber1, string txtNumber2)
        {
            double sum = 0;

            if (String.IsNullOrEmpty(txtNumber1) || String.IsNullOrEmpty(txtNumber2))
            {
                throw new FormatException("Missing Input");
            }

            try
            {
                double number1 = int.Parse(txtNumber1);
                double number2 = int.Parse(txtNumber2);

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
            catch
            {
                throw new FormatException("Invalid Input");
            }
        }

    }
}
