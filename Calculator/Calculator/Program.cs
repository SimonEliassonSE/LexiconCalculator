
using Calculator;
bool isActive = true;

while (isActive == true) // Täcker hela pogramet, om false = Exit
{

    // Lägg till functionalitet så att användaren kan välja att addera flera tal istället för 2
        // Lägg till en metod som frågar om användaren vill räkna igen eller återgå till huvudmenyn
          // Yterligare fördjupning, Låt vissa metoder fortsätta tills användren skriver = t.ex. 3 + 3 + 3 + 3 + 3 =



    DisplayClass.CallMainMenu(); // kallar på menyn      
    string userInput = InputCollectorClass.GetStringFromUser(); // callar på GetString Metoden och ger värdet till userInput 
    

    switch (userInput)
    {

        case "+":
            { 
                bool doAgain = false;
                do {
                    string menuChoice = DisplayClass.BasicOrAdvancedText();
                    if (menuChoice == "1")
                    {
                        DisplayClass.BasicAdditionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                        
                    }

                    else if (menuChoice == "2")
                    {
                        DisplayClass.AdvancedAdditionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                        
                        
                    }
                } while (doAgain); 
                
                break;
            }


        case "-":
            {
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Subtraction on");
                decimal num1 = InputCollectorClass.GetDecimalFromUser();
                decimal num2 = InputCollectorClass.GetDecimalFromUser();
                Console.WriteLine(CalculationMethodsClass.DoSubtraction(num1, num2));
                DisplayClass.CallEndStatment();

                break;
            }

        case "/":
            {   
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Division on");

                bool isNotZero = false;
                while (isNotZero == false)
                {
                    decimal num1 = InputCollectorClass.GetDecimalFromUser();
                    decimal num2 = InputCollectorClass.GetDecimalFromUser();

                    if (num1 == 0 || num2 == 0)
                    {
                        DisplayClass.CallCanNotDivideByZero();
                    }

                    else
                    {
                        isNotZero = true;
                        Console.WriteLine(CalculationMethodsClass.DoDivision(num1, num2));
                        DisplayClass.CallEndStatment();
                        break;
                    }
                }
                break;
            }

        case "*":
            {
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Multiplication on");
                decimal num1 = InputCollectorClass.GetDecimalFromUser();
                decimal num2 = InputCollectorClass.GetDecimalFromUser();
                Console.WriteLine(CalculationMethodsClass.DoMultiplication(num1, num2));
                DisplayClass.CallEndStatment();

                break;
            }
        case "square":
            {
                Console.Clear();
                Console.WriteLine("Please enter a value to calculate");
                double num1 = InputCollectorClass.GetDoubbleFromUser();
                Console.WriteLine(CalculationMethodsClass.DoSquareRoot(num1));
                DisplayClass.CallEndStatment();

                break;
            }

        case "power":
            {
                Console.Clear();
                Console.WriteLine("Please enter 2 values, first power of second to calculate");
                double num1 = InputCollectorClass.GetDoubbleFromUser();
                double num2 = InputCollectorClass.GetDoubbleFromUser();
                Console.WriteLine(CalculationMethodsClass.DoPowerOf(num1, num2));
                DisplayClass.CallEndStatment();

                break;
            }

        case "0":
            {
                Console.Clear();
                Console.WriteLine(
                    "\nThank you for using this calculator\n" +
                    "Cya around.\n");
                
                isActive = false;
                break;
            }

        default:
            {
                // Retunerar användaren till huvudmenyn om något annat än case symbolerna är input t.ex. Abba
                Console.Clear();
                Console.WriteLine("Wrong input");
                break;
            }

    }


}



