using System;

// NameSpace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Poit Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet 

            while (true)
            {

                // Set correct number 

                // int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Inite guess var 

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct 

                while (guess != correctNumber)
                {
                    // Get users input

                    string input = Console.ReadLine();

                    // Make sure its a number 

                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Yellow, "Please use an actual number! ");

                        // keep going 

                        continue;
                    }
                    // cast to int and put in the guess

                    guess = Int32.Parse(input);

                    // match guess to correct number 
                    if (guess != correctNumber)
                    {
                        // Print Erroe Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again! ");
                    }
                }
                // Output success meassage

                // Print Succes Message
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT! You guessed it!");

                // Ask user if he want to play again

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Play Again? [Y or N]");


                Console.ResetColor();

                // Get Answer 

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {

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
        static void GetAppInfo(){
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "George Hira";

            // Change text color

            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info 

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color

            Console.ResetColor();

        }
        // Ask users name and greet 
        static void GreetUser()
        {
            // Ask users name

            Console.WriteLine("What is your name? ");

            // Get user input

            string inputam = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game... ", inputam);
        }

        // Print color message 

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }




    }
}

