// See https://aka.ms/new-console-template for more information   

bool isActive = true;

// Täcker hela pogramet, om false = Exit
while (isActive == true)
{
    // Lägg till fler funktioner när grunden är satt, t.ex. Upphöjt med, roten ur, -- klar
    // Yterligare fördjupning, Låt vissa metoder fortsätta tills användren skriver = t.ex. 3 + 3 + 3 + 3 + 3 =


    CallMenu(); // kallar på menyn   
    string userInput = GetStringFromUser(); // User Input method, styr villket case som aktiveras. 

    switch (userInput)
    {

        case "+":
            {
                // Tömmer (tar bort) tidigare text för mindre "Clutter"
                Console.Clear();

                // Specificierar input samt tar in input
                Console.WriteLine("Please enter the 2 numbers to do Addition on");
                decimal num1 = GetDecimalFromUser(Console.ReadLine());
                decimal num2 = GetDecimalFromUser(Console.ReadLine());

                // uträkningsmetod, tar in 2 inputs och gör uträkningen. 
                Console.WriteLine(DoAddition(num1, num2));
                CallEndStatment();
                break;
            }


        case "-":
            {
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Subtraction on");
                decimal num1 = GetDecimalFromUser(Console.ReadLine());
                decimal num2 = GetDecimalFromUser(Console.ReadLine());

                Console.WriteLine(DoSubtraction(num1, num2));
                CallEndStatment();
                break;
            }

        case "/":
            {   // Kom ihåg att om man tar 0/x eller x/0 skall ett felmedellande gå ut samt en felhanterare som antingen gör om eller stopar.
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Division on");

                bool isNotZero = false;

                while (isNotZero == false)
                {
                    decimal num1 = GetDecimalFromUser(Console.ReadLine());
                    decimal num2 = GetDecimalFromUser(Console.ReadLine());

                    if (num1 == 0 || num2 == 0)
                    {

                        Console.WriteLine(
                        "One ore more of your enterd values are = 0\n" +
                        "Please enter 2 new values");

                    }

                    else
                    {
                        isNotZero = true;
                        Console.WriteLine(DoDivision(num1, num2));
                        CallEndStatment();
                        break;
                    }
                }
                break;
            }

        case "*":
            {
                Console.Clear();
                Console.WriteLine("Please enter the 2 numbers to do Multiplication on");
                decimal num1 = GetDecimalFromUser(Console.ReadLine());
                decimal num2 = GetDecimalFromUser(Console.ReadLine());

                Console.WriteLine(DoMultiplication(num1, num2));
                CallEndStatment();
                break;
            }
        case "square":
            {
                Console.Clear();
                Console.WriteLine("Please enter a value to calculate");
                double num1 = GetDoubbleFromUser(Console.ReadLine());


                Console.WriteLine(DoSquareRoot(num1));
                CallEndStatment();
                break;
            }

        case "power":
            {
                Console.Clear();
                Console.WriteLine("Please enter 2 values, first power of second to calculate");
                double num1 = GetDoubbleFromUser(Console.ReadLine());
                double num2 = GetDoubbleFromUser(Console.ReadLine());

                Console.WriteLine(DoPowerOf(num1, num2));
                CallEndStatment();
                break;
            }

        case "0":
            {
                Console.Clear();
                Console.WriteLine(
                    "\nThank you for using this calculator\n" +
                    "Cya around.\n");
                // Ändrar bool till falskt, stoppar while loopen som sluter hela pogramet. (Exit metod)
                isActive = false;
                break;
            }

        default:
            {
                // Retunerar användaren till huvudmenyn om något annat än case symbolerna är input t.ex. Abba
                Console.Clear();
                Console.WriteLine("Wrong input, returning to main menu");
                break;
            }

    }


}

static string GetStringFromUser()
{
    string userString = Console.ReadLine();
    return userString;

}

static double GetDoubbleFromUser(string input)
{
    double num = 0;
    double.TryParse(input, out num);
    return num;
}

static decimal GetDecimalFromUser(string input)
{
    decimal num = 0;
    decimal.TryParse(input, out num);

    return num;
}

static decimal DoAddition(decimal num1, decimal num2)
{
    decimal result = (num1 + num2);
    return result;
}

static decimal DoSubtraction(decimal num1, decimal num2)
{
    // Byte från double till decimal då doubble hade precisions problem (float?)
    decimal result = (num1 - num2);
    return result;

}

static decimal DoMultiplication(decimal num1, decimal num2)
{
    decimal result = (num1 * num2);
    return result;

}

static decimal DoDivision(decimal num1, decimal num2)
{
    decimal result = (num1 / num2);
    return result;
}

static double DoSquareRoot(double num1)
{

    double result = Math.Sqrt(num1);
    return result;
}

static double DoPowerOf(double num1, double num2)
{

    double result = Math.Pow(num1, num2);
    return result;
}

static void CallMenu()
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

static void CallEndStatment()
{
    Console.WriteLine("\n\n Press any key to return to main menu");
    Console.ReadLine();
}
/*
Advancerad tilläg till metoder, press 1 for simpel calculator, press 2 for advanceded
    if (userInput == "1"){ do while(continue != false){}}
    else if (userInput == "2"){}
    else {"The input was not correct"}
*/