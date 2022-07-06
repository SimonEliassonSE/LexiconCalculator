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
            string userInput;
            do
            {
                Console.WriteLine("Enter [yes] to start over, or [no] to return to main menu");
                userInput = GetStringFromUser();
                if (userInput == "yes")
                {
                    goAgain = true;
                }
                else if (userInput == "no")
                {
                    goAgain = false;
                }
            } while (userInput != "yes" && userInput != "no");
            return goAgain;
        }

        public static string GetStringFromUser()
        {

            string userString;
            
            do
            {                
              userString = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(userString))
                {
                    bool isNullOrEmpty = true;
                    InputAccepted(isNullOrEmpty); // for unit testing

                }

                else if (!string.IsNullOrEmpty(userString))
                {
                    bool isNullOrEmpty = false;
                    InputAccepted(isNullOrEmpty); // for unit testing
                }

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

        public static decimal TryParseStringToDecimal(string userInput)
        {
            bool isNumeric;
            decimal num;
            string input = userInput;

            do
            {
                
                isNumeric = decimal.TryParse(input, out num);

                if (isNumeric)
                { return num; }

                else 
                { 
                    Console.WriteLine("The input was not correct, try again!(may not contain letters)");
                    input = InputCollectorClass.GetStringFromUser();
                }

            } while (!isNumeric);

            return num;
        }

        public static bool InputAccepted(bool setBool) //For unit testing, sending a true oor false back to test to see weith er the input was accepted or not
        {
            bool inputStatus = setBool;
            return inputStatus;
        }


    }
}
