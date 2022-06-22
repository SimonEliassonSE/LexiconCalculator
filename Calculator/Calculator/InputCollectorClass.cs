using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class InputCollectorClass
    {

        public static string GetStringFromUser()
        {
            string userString = Console.ReadLine().ToLower();
            return userString;

        }

        public static double GetDoubbleFromUser(string input)
        {
            double num = 0;
            double.TryParse(input, out num);
            return num;
        }

        public static decimal GetDecimalFromUser(string input)
        {
            decimal num = 0;
            decimal.TryParse(input, out num);

            return num;
        }

    }
}
