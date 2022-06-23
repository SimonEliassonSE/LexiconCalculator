using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class DisplayClass
    {


        public static void CallMainMenu()
        {
            Console.WriteLine(
                                "\nPress + for multiplication\n" +
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
            Console.WriteLine("\n\n Press any key to return to main menu");
            Console.ReadLine();
        }

        public static void CallCanNotDivideByZero()
        {
            Console.WriteLine(
                        "You can not divide with 0!\n" +
                        "Please enter 2 new values");
        }       
        
    }
}
