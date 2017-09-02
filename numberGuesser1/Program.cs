using System;

//Namespace
namespace numberGuesser1
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run GetAppInfo Function to get info
            GetAppInfo();

            //Ask for users name and greet
            GreetUser();
           
            while (true)
            {
            //Create a new random object
            Random random = new Random();

            //Init Correct Number
            int correctNumber = random.Next(1, 10);

            //Init Guess Var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");


            // While guess is not correct
            while(guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();


                // Make sure its a number
                if(!int.TryParse(input, out guess))
                {
                    // Print Error Message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                    
                    // keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {     
                   // Set Error Message     
                   PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }
            }


                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You guessed it!");

                // Ask to PLay Again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            //Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Eric Pineda";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change Text Color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
