using System;

// Namespace
namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //run app info

            GreetUser(); //Ask for users name and greet



            while (true)
            {

                // Set correct number
                // int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 15);


                //Init guess var
                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 15");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Does That Look Like a Number to You?");



                        // keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                       
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number Sucka! go ahead try again");

                    }

                }


                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You Filthy Animal!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }







                //Keeps the console open 
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
            }
        }
        // Getand display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Joshua Harris";

            // Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        // ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }


                     //Print color message
                 static void PrintColorMessage(ConsoleColor color, string message)
                 {
                        // Change text color 
                         Console.ForegroundColor = color;

                        // Tell user its not a  number
                         Console.WriteLine(message);

                        // Reset text color
                         Console.ResetColor();
                 }

    }
}
