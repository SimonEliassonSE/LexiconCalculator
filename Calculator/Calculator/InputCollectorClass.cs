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
            string userString;
            do
            {                
              userString = Console.ReadLine().ToLower();
            } while (string.IsNullOrWhiteSpace(userString));
            return userString;
              

        }

        public static double GetDoubbleFromUser()
        {
            string input = GetStringFromUser();
            double num = 0;
            double.TryParse(input, out num);
            return num;
        }

        public static decimal GetDecimalFromUser()
        {
            string input = GetStringFromUser();
            decimal num = 0;     
            decimal.TryParse(input, out num);  
            return num;
        }
    }
}
