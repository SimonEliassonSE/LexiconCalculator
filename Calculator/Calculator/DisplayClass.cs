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

        public static string BasicOrAdvancedText(string userInput)
        {
            Console.Clear();
            string calculationType = "a";
            if (userInput == "+")
            {
                calculationType = "addition";
            }
            if (userInput == "-")
            {
                calculationType = "subtraction";
            }
            string menuChoice;
            bool correctInput = false;

            do
            {
                Console.WriteLine(
                    "\nPlease enter [1] for basic calculator\n" +
                    $"- basic calculator contains 2 input {calculationType}\n" +
                    $"- basic calculator dose also contain several input {calculationType} (array based method)\n\n" +
                    "Please enter [2] for advanced calculator\n" +
                    "- advanced calculator will continue add until you enter [ = ]");
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

        public static string BasicOrAdvancedWithNoArray(string userInput)

        {
            Console.Clear();
            string calculationType = "a";

            if (userInput == "*")
            {
                calculationType = "multiplication";
            }

            if (userInput == "/")
            {
                calculationType = "division";
            }

            string menuChoice;
            bool correctInput = false;

            do
            {
                Console.WriteLine(
                    "\nPlease enter [1] for basic calculator\n" +
                    $"- basic calculator contains 2 input {calculationType}\n\n" +
                    
                    "Please enter [2] for advanced calculator\n" +
                    "- advanced calculator will continue add until you enter [ = ]");
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
            string userInput;

            do
            {
                Console.WriteLine("enter [two] to do 2 input addition, or [several] for more then 2 input addition\n");
                userInput = InputCollectorClass.GetStringFromUser().ToLower();
            } while (userInput != "two" && userInput != "several");

            if (userInput == "two")
            {
                Console.WriteLine("Please enter the 2 numbers to do Addition on");
                decimal num1 = InputCollectorClass.GetDecimalFromUser();
                decimal num2 = InputCollectorClass.GetDecimalFromUser();
                Console.WriteLine(CalculationMethodsClass.DoAddition(num1, num2));
            }

            else if (userInput == "several")
            {
                Console.WriteLine("Please enter several numbers divded by [ , ] to do addition on");
                string num1 = InputCollectorClass.GetStringFromUser();
                string[] stringContainter = num1.Split(',');
                decimal[] decimalContainer = new decimal[stringContainter.Length];

                for (int i = 0; i < stringContainter.Length; i++)
                {
                    decimalContainer[i] = Convert.ToDecimal(stringContainter[i]);
                }

                CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
                decimal result = calculationMethodsClass.DoAddition(decimalContainer);
                Console.WriteLine(result);
            }

        }

        public static void AdvancedAdditionDisplay()
        {
            Console.Clear();
            Console.WriteLine(
                "You choosed [advanced calculator]\n" +
                "The calculator will continue to add new numbers until you enter = ");
            Console.WriteLine(CalculationMethodsClass.DoAdvancedAddition());
        }

        public static void BasicSubtractionDisplay()
        {
            Console.Clear();
            string userInput;
            do
            {
                Console.WriteLine("enter [two] to do 2 input subtraction, or [several] for more then 2 input's");
                userInput = InputCollectorClass.GetStringFromUser().ToLower();
            } while (userInput != "two" && userInput != "several");

            if (userInput == "two")
            {
                Console.WriteLine("Please enter the 2 numbers to do Subtraction on");
                decimal num1 = InputCollectorClass.GetDecimalFromUser();
                decimal num2 = InputCollectorClass.GetDecimalFromUser();
                Console.WriteLine(CalculationMethodsClass.DoSubtraction(num1, num2));
            }

            else if (userInput == "several")
            {
                Console.WriteLine("Please enter several numbers divded by [ , ]");
               
                string num1 = InputCollectorClass.GetStringFromUser();                
                string[] stringContainter = num1.Split(',');
                decimal[] decimalContainer = new decimal[stringContainter.Length];
                for (int i = 0; i < stringContainter.Length; i++)
                {
                    decimalContainer[i] = Convert.ToDecimal(stringContainter[i]);
                }

                CalculationMethodsClass calculationMethodsClass = new CalculationMethodsClass();
                decimal result = calculationMethodsClass.DoSubtraction(decimalContainer);
                Console.WriteLine(result);
            }
        }

        public static void AdvancedSubtractionDisplay()
        {
            Console.Clear();
            Console.WriteLine(
                "You choosed [advanced calculator]\n" +
                "The calculator will continue to add new numbers until you enter = ");
            Console.WriteLine(CalculationMethodsClass.DoAdvancedSubtraction());
        }
        public static void BasicMultiplicationDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter the 2 numbers to do Multiplication on");
            decimal num1 = InputCollectorClass.GetDecimalFromUser();
            decimal num2 = InputCollectorClass.GetDecimalFromUser();
            Console.WriteLine(CalculationMethodsClass.DoMultiplication(num1, num2));
        }

        public static void AdvancedMultiplicationDisplay()
        {
            Console.Clear();
            Console.WriteLine(
                "You choosed [advanced calculator]\n" +
                "The calculator will continue to add new numbers until you enter = ");
            Console.WriteLine(CalculationMethodsClass.DoAdvancedMultiplication());
        }

        public static void BasicDivisionDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter the 2 numbers to do Division on");
            //decimal result = LogicLayer.PreventDivisonByZeroAndReturnResult();
            decimal num1 = InputCollectorClass.GetDecimalFromUser();
            decimal num2 = InputCollectorClass.GetDecimalFromUser();
            Console.WriteLine(CalculationMethodsClass.DoDivision(num1, num2));
        }

        public static void AdvancedDivisionDisplay()
        {
            Console.Clear();
            Console.WriteLine(
                "You choosed [advanced calculator]\n" +
                "The calculator will continue to add new numbers until you enter = ");
            Console.WriteLine(CalculationMethodsClass.DoAdvancedDivision());
        }
        
        public static void BasicPowerOfDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter 2 values, first power of second to calculate");
            double num1 = InputCollectorClass.GetDoubbleFromUser();
            double num2 = InputCollectorClass.GetDoubbleFromUser();
            Console.WriteLine(CalculationMethodsClass.DoPowerOf(num1, num2));
        }
        public static void BasicSquareRootDisplay()
        {
            Console.Clear();
            Console.WriteLine("Please enter a value to calculate");
            double num1 = InputCollectorClass.GetDoubbleFromUser();
            Console.WriteLine(CalculationMethodsClass.DoSquareRoot(num1));
        }
        public static void CallCanNotDivideByZero()
        {
            Console.WriteLine(
                        "You can not divide with 0!\n" +
                        "Please enter 2 new values");
        }
    }
}
