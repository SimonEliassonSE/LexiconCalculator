using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculationMethodsClass
    {

        public static decimal DoAddition(decimal num1, decimal num2)
        {
            decimal result = (num1 + num2);
            return result;
        }

        public static decimal DoSubtraction(decimal num1, decimal num2)
        {
            // Byte från double till decimal då doubble hade precisions problem (float?)
            decimal result = (num1 - num2);
            return result;

        }

        public static decimal DoMultiplication(decimal num1, decimal num2)
        {
            decimal result = (num1 * num2);
            return result;

        }

        public static decimal DoDivision(decimal num1, decimal num2)
        {
            decimal result = (num1 / num2);
            return result;
        }

        public static double DoSquareRoot(double num1)
        {

            double result = Math.Sqrt(num1);
            return result;
        }

        public static double DoPowerOf(double num1, double num2)
        {

            double result = Math.Pow(num1, num2);
            return result;
        }

    }
}
