using System;
using System.Collections.Generic;


namespace rockPaperScissors
{
    class Program
    {
        static void Restart(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Would you like to play again?");
                Console.ResetColor();
                string reset = Console.ReadLine();
                if (reset == "yes".ToLower())
                {
                    Game(args);
                }
                else if (reset == "no".ToLower())
                {
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("Please respond with yes or no.");
                    continue;
                }
            }
        }
        static void Win(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN!!!");
            Console.ResetColor();
            Restart(args);
        }
        static void Lose(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU LOSE!!!");
            Console.ResetColor();
            Restart(args);
        }
        static void Tie(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We have tied! Let's keep going!");
            Console.ResetColor();

        }
        static void Main(string[] args)
        {
            string programName = "Rock Paper Scissors Game";
            string programVersion = "1.0.0";
            string programAuthor = "Jack Dean";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} version: {1} created by {2}", programName, programVersion, programAuthor);
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine("Welcome to the rock, paper scissors game! What is your name?");
                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine("Please enter your name.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Welcome, {0}! Now lets play rock, paper, scissors!", name);

                }
                Game(args);
            }
        }
        
        static void Game(string[] args)
        {
        
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("So what will you choose?");
                    Console.ResetColor();
                    string userChoice = Console.ReadLine().ToLower();
                    Random random = new Random();
                    var list = new List<string> { "rock", "paper", "scissors" };
                    var index = random.Next(list.Count);
                    if (userChoice == "rock" || userChoice == "paper" || userChoice == "scissors")
                    {
                        Console.WriteLine("I choose " + list[index]);

                    }

                    if (userChoice == "rock" && index == 2)
                    {
                        Win(args);
                        break;
                    }
                    else if (userChoice == "rock" && index == 1)
                    {
                        Lose(args);
                        break;

                    }
                    else if (userChoice == "rock" && index == 0)
                    {
                        Tie(args);
                        continue;
                    }
                    else if (userChoice == "paper" && index == 0)
                    {
                        Win(args);
                    }
                    else if (userChoice == "paper" && index == 2)
                    {
                        Lose(args);
                    }
                    else if (userChoice == "paper" && index == 1)
                    {
                        Tie(args);
                    }
                    else if (userChoice == "scissors" && index == 1)
                    {
                        Win(args);
                    }
                    else if (userChoice == "scissors" && index == 0)
                    {
                        Lose(args);
                    }
                    else if (userChoice == "scissors" && index == 2)
                    {
                        Tie(args);
                    }
                    else if (userChoice != "rock" || userChoice != "paper" || userChoice != "scissors")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter either rock, paper or scissors!");
                        Console.ResetColor();
                        continue;
                    }
                }





            


        }
    }
}
