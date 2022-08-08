
using Calculator;
bool isActive = true;

while (isActive == true) // Täcker hela pogramet, om false = Exit
{

    DisplayClass.CallMainMenu(); // kallar på menyn      
    string userInput = InputCollectorClass.GetStringFromUser(); // callar på GetString Metoden och ger värdet till userInput 
    
    switch (userInput)
    {

        case "+":
            { 
                bool doAgain = false;
                do {
                    string menuChoice = DisplayClass.BasicOrAdvancedText(userInput);
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
                bool doAgain = false;
                do
                {
                    string menuChoice = DisplayClass.BasicOrAdvancedText(userInput);
                    if (menuChoice == "1")
                    {
                        DisplayClass.BasicSubtractionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                    else if (menuChoice == "2")
                    {
                        DisplayClass.AdvancedSubtractionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                } while (doAgain);                                
               
                break;
            }

        case "/":
            {
                bool doAgain = false;
                do 
                {
                    string menuChoice = DisplayClass.BasicOrAdvancedWithNoArray(userInput);
                    if (menuChoice == "1")
                    {
                        DisplayClass.BasicDivisionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                    else if (menuChoice == "2")
                    {
                        DisplayClass.AdvancedDivisionDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                } while (doAgain);

                break;
            }

        case "*":
            {
                bool doAgain = false;
                do
                {
                    string menuChoice = DisplayClass.BasicOrAdvancedWithNoArray(userInput);
                    if (menuChoice == "1")
                    {
                        DisplayClass.BasicMultiplicationDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                    else if (menuChoice == "2")
                    {
                        DisplayClass.AdvancedMultiplicationDisplay();
                        doAgain = InputCollectorClass.GetBoolFromUser();
                    }

                } while (doAgain);

                break;
            }
        case "square":
            {
                bool doAgain = false;
                do 
                {
                    DisplayClass.BasicSquareRootDisplay();
                    doAgain = InputCollectorClass.GetBoolFromUser();
                } while (doAgain);

                break;
            }

        case "power":
            {
                bool doAgain = false;
                do
                {
                    DisplayClass.BasicPowerOfDisplay();
                    doAgain = InputCollectorClass.GetBoolFromUser();
                } while (doAgain);

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
                Console.WriteLine("|-------------|\n" +
                                  "| Wrong input |\n" +
                                  "|-------------|\n");
                break;
            }

    }


}



