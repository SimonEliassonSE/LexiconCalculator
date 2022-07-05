using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DisplayClass
    {



        public static void CallMainMenu()
        {
            Console.WriteLine(
                                "\nPress + for Addition\n" +
                                "Press - for Subtraction\n" +
                                "Press * for Multiplication\n" +
                                "Press / for Division\n" +

                                // Tilläggsfunktioner 
                                "Enter [square] for square root calculation\n" +
                                "Enter [power] for power of calculation\n" +
                                "Press 0 to Exit the program\n");
        }

        public static void CallEndStatment()
        {
            Console.WriteLine("\n\nPress any key to return to main menu");
            Console.ReadLine();
        }
        public static string BasicOrAdvancedText()
        {      
            string menuChoice;
            bool correctInput = false;

            do
            {
                Console.WriteLine(
                    "Please enter [1] for basic calculator\n" +
                    "Please enter [2] for advanced calculator\n");
                menuChoice = InputCollectorClass.GetStringFromUser();

                if (menuChoice == "1")
                {
                    correctInput = true;
                }
                else if (menuChoice == "2")
                {
                    correctInput = true;
                }

            } while (!correctInput);
            return menuChoice;
        }

        public static void BasicAdditionDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter the 2 numbers to do Addition on");
            decimal num1 = InputCollectorClass.GetDecimalFromUser();
            decimal num2 = InputCollectorClass.GetDecimalFromUser();
            Console.WriteLine(CalculationMethodsClass.DoAddition(num1, num2));
            
        }

        public static void AdvancedAdditionDisplay()
        {
            Console.Clear();
            Console.WriteLine(
                "You choosed [advanced calculator]\n" +
                "The calculator will continue to add new numbers until you enter = ");
            Console.WriteLine(CalculationMethodsClass.DoAdvancedAddition());
        }

        public static void CallCanNotDivideByZero()
        {
            Console.WriteLine(
                        "You can not divide with 0!\n" +
                        "Please enter 2 new values");
        }
    }
}
