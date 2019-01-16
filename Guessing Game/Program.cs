using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Guessing Game");
            Console.WriteLine("Please Guess a number 1-10 or 0 for help");
            string userGuess = Console.ReadLine();
            int userGuessAsInt = Convert.ToInt32(userGuess);
            Console.WriteLine("You guessed: " + userGuess);
            if (userGuess.Equals("0"))
            {
                Console.WriteLine("====INTRUCTIONS====");
                Console.WriteLine("You must guess a whole number between 1-10.");
                Console.WriteLine("Submit your answer with 0");
                userGuess = Console.ReadLine();

            }
            // if they guess 7
            else if (userGuess.Equals("7"))
            {
                //They Win
                Console.WriteLine("YOU WIN");
            }
            //To Low           
            else if (userGuessAsInt <7 )
            {
                Console.WriteLine("You Lost, Guess Higher");
            }       
            // To High
            else if (userGuessAsInt >8)
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
    

