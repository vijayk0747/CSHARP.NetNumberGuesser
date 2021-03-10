using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //App Data
            string appName = "Vijay's Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vijay";
            int runProg = 1;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("Welcome to Vijay's Number Guessing Game!");

            System.Threading.Thread.Sleep(3000);

            //Entering the Game
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string userName = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("Hello {0}, Welcome to {1}...", userName, appName);

            //Using a bigger while loop to allow for the use of the continue function
            while (runProg == 1)
            {
                //Declaring vars
                int guess = 0;
                int numTries = 0;
                System.Random random = new System.Random();
                int correctNum = random.Next(100);

                System.Threading.Thread.Sleep(3000);


                Console.WriteLine("Guess a number between 1 and 100");

                //Logic of the game
                while (guess != correctNum)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string input = Console.ReadLine();
                    guess = Int32.Parse(input);
                    Console.ResetColor();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Please Enter an Integer");
                        Console.ResetColor();
                        numTries++;
                    }
                    else if (guess > correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Your guess was too high!");
                        Console.ResetColor();
                        numTries++;
                    }
                    else if (guess < correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Your guess was too low!");
                        Console.ResetColor();
                        numTries++;
                    }
                }

                //Messages after user wins
                if (guess == correctNum)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You guessed the correct Answer!");
                    System.Threading.Thread.Sleep(2000);

                    if (numTries == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Definitely a Fluke!");
                        Console.ResetColor();
                        numTries = 0;
                    }
                    else if (numTries <= 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Amazing! You guessed the correct number in {0} tries!", numTries);
                        Console.ResetColor();
                        numTries = 0;
                    }
                    else if (numTries > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It took you {0} tries to guess right.... Pathetic!", numTries);
                        Console.ResetColor();
                        numTries = 0;
                    }
                }

                //Allows for replayability.
                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Thank you for playing today!");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Beep Beep Boop");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
