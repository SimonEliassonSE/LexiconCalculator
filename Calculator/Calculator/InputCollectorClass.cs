using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputCollectorClass
    {

        public static bool GetBoolFromUser()
        {
            bool goAgain = true;
            Console.WriteLine("Enter [yes] to start over, or [no] to return to main menu");
            string userInput = GetStringFromUser();
            if (userInput == "yes")
            {
                goAgain = true; 
            }
            else if (userInput == "no")
            {
                goAgain = false;    
            }
            
            return goAgain;
        }

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
            bool isNumeric;
            double num;
            do 
            { 
                string input = GetStringFromUser();
                isNumeric = double.TryParse(input, out num);

                if (isNumeric) 
                    { return num; }
                else { Console.WriteLine("The input was not correct, try again!(may not contain letters)"); }

            } while (!isNumeric);

            return num;
        }

        public static decimal GetDecimalFromUser()
        {
            bool isNumeric;
            decimal num;

            do
            {
                string input = GetStringFromUser();                
                isNumeric = decimal.TryParse(input, out num);
                
                if (isNumeric) 
                    { return num; }
                else { Console.WriteLine("The input was not correct, try again!(may not contain letters)"); }

            } while (!isNumeric);

            return num;
        }
    }
}
