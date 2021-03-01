using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNumber = "42";

            Console.WriteLine("Hello! Want to have some fun? Guess my secret number!");

            string question = "What's your guess?";

            int num = 0;

            while (num < 4)
            {

                Console.Write($"{question}: ");
                string answer = Console.ReadLine();
                if (answer != secretNumber)
                {
                    Console.WriteLine("Oh dear, I'm afraid you're wrong");
                }
                else
                {
                    Console.WriteLine("Ding Dong! You got it, dummy!");
                }
                num++;


            }








        }
    }
}
