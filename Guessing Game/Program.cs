using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Guessing Game");
            Console.WriteLine("Please Guess a number 1-10");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);
            if (userGuess.Equals("0"))
            {
                Console.WriteLine("You must guess a number between 1-10");
            }
            // if they guess 7
            else if (userGuess.Equals("7"))
            {
                //They Win
                Console.WriteLine("YOU WIN");
            } else
            {
                Console.WriteLine("You Lost");
            }
            }


        }
    }

