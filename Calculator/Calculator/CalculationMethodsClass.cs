using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculationMethodsClass
    {

        public static decimal DoAddition(decimal num1, decimal num2)
        {
            decimal result = (num1 + num2);
            return result;
        }

        public decimal DoAddition(params decimal[] numbers)
        {
            decimal sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static decimal DoAdvancedAddition()
        {
            bool displayValue = false;
            decimal result = 0;
            decimal num;
            string input;

            do
            {
                input = InputCollectorClass.GetStringFromUser();
                if (input == "=")
                {
                    displayValue = true;

                }
                else if (input != "=")
                {
                    //num = InputCollectorClass.GetDecimalFromUser();
                    num = InputCollectorClass.TryParseStringToDecimal(input);
                    result = (result + num);

                }


            }
            while (!displayValue);
            return result;
        }     

        public static decimal DoSubtraction(decimal num1, decimal num2)
        {
            // Byte från double till decimal då doubble hade precisions problem (float?)
            decimal result = (num1 - num2);
            return result;

        }

        public decimal DoSubtraction(params decimal[] numbers)
        {
            decimal placeHolder = numbers[0] * 2;
            decimal sum = placeHolder;

            for (var i = 0; i < numbers.Length; i++)
            {
                sum = sum - numbers[i];
            }
            return sum;

        }// I want the first value to be seen as positiv and then reduce that value with the rest of the values
                                                                 // So i have made it so that this is true. (1 value 100, 2 100 = 0)
        public static decimal DoAdvancedSubtraction()
        {
            bool displayValue = false;
            decimal result = 0;
            decimal num;
            string input;
            int index = 0;
            do
            {

                input = InputCollectorClass.GetStringFromUser();
                if (input == "=")
                {
                    displayValue = true;

                }
                else if (input != "=")
                {
                    //num = InputCollectorClass.GetDecimalFromUser();
                    
                    num = InputCollectorClass.TryParseStringToDecimal(input);
                    if(index == 0 ) 
                    { 
                        result = num;
                    }

                    else if (index > 0)
                    {
                        result = result - num;
                    }

                    index++;

                }


            }
            while (!displayValue);
            return result;
        }// Same approache as DoSubtraction (params array)
                                                       

        public static decimal DoMultiplication(decimal num1, decimal num2)
        {
            decimal result = (num1 * num2);
            return result;

        }

        public static decimal DoAdvancedMultiplication()
        {
            bool displayValue = false;
            decimal result = 0;
            decimal num;
            string input;
            do
            {

                input = InputCollectorClass.GetStringFromUser();
                if (input == "=")
                {
                    displayValue = true;

                }
                else if (input != "=")
                {
                    num = InputCollectorClass.TryParseStringToDecimal(input);


                    if (result == 0 && num != 0)// prevents first number to be 0 
                    {
                        result = num;
                    }

                    else if (num == 0) // prevents division with 0 
                    {
                        do
                        {
                            Console.WriteLine("Input may not contain 0 \n" +
                                                "Enter a new letter!");
                            input = InputCollectorClass.GetStringFromUser();
                            num = InputCollectorClass.TryParseStringToDecimal(input);

                        } while (num == 0);

                        if (result == 0)
                        {
                            result = num;
                        }

                        else if (result != 0)
                        {
                            result = result * num;
                        }

                    }

                    else
                    {
                        result = result * num;
                    }
                }
            }
            while (!displayValue);
            return result;
            
        }

        public static decimal DoDivision(decimal num1, decimal num2)
        {
            decimal result;
            
            if (num1 == 0)
            {
                return 0;
            }

            else if (num2 == 0)
            {
                return num1;
            }
            
            else { result = (num1 / num2); }

            return result;
        }

        public static decimal DoAdvancedDivision()
        {
            bool displayValue = false;
            decimal result = 0;
            decimal num;
            string input;
            do
            {

                input = InputCollectorClass.GetStringFromUser();
                if (input == "=")
                {
                    displayValue = true;

                }
                else if (input != "=")
                {
                    num = InputCollectorClass.TryParseStringToDecimal(input);
                    

                    if (result == 0 && num != 0)// prevents first number to be 0 
                    {
                        result = num;
                    }

                    else if (num == 0) // prevents division with 0 
                    {                        
                        do 
                        { 
                        Console.WriteLine("Input may not contain 0 \n" +
                                            "Enter a new letter!");
                            input = InputCollectorClass.GetStringFromUser();
                            num = InputCollectorClass.TryParseStringToDecimal(input);
                            
                        } while (num == 0);

                        if (result == 0)
                        {
                            result = num;
                        }

                        else if (result != 0)
                        {
                            result = result / num;
                        }

                    }

                    else 
                    {
                        result = result / num;
                    }
                }
            }
            while (!displayValue);
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
