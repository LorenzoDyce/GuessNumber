using System;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point method
        static void Main(string[] args)
        {


            GetAppInfo(); // Run GetAppInfo function to get app info

            GreetUser(); // Ask for users name and greet

            while (true)
            {




                // Create a new Random object
                Random random = new Random();


                int correctNumber = random.Next(1, 100);

                // Init guess var 
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 100");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Rrint error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;


                    }

                    // cast to inti and put in guess
                    guess = Int32.Parse(input);


                    // Match guess to correct number 
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

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

        // get and display app info

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Lorenzo Dyce";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            // Reset text color
            Console.ResetColor();

        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Tell user it's the wrong number
            Console.WriteLine(message);


            // Reset text color
            Console.ResetColor();
        }
    }
}
