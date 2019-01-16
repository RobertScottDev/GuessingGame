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
            }
            //To Low
            else if (userGuess.Equals("1"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }
            else if (userGuess.Equals("2"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }
            else if (userGuess.Equals("3"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }
            else if (userGuess.Equals("4"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }
            else if (userGuess.Equals("5"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }
            else if (userGuess.Equals("6"))
            {
                Console.WriteLine("You Lost, Guess Higher");
            }       
            // To High
            else if (userGuess.Equals("8"))
            {
                Console.WriteLine("You Lost, Guess Lower");
            }
            else if (userGuess.Equals("9"))
            {
                Console.WriteLine("You Lost, Guess Lower");
            }
            else if (userGuess.Equals("10"))
            {
                Console.WriteLine("You Lost, Guess Lower");
            }
            else
            {
                Console.WriteLine("Press 0 for rules");
            }


        }
    }
}
    

