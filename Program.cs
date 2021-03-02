using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNumber = "42";

            Console.WriteLine("Hello! Want to have some fun? Guess my secret number!");

            string question = "What's your guess, dummy?";

            int num = 0;
            while (num < 4)
            {

                Console.Write($"{question}: ");
                string answer = Console.ReadLine();

                if (answer != secretNumber)
                {
                    Console.WriteLine($"Oh dear, I'm afraid you're wrong. You have tried {num + 1} times.");
                    num++;
                }
                else if (answer == secretNumber)
                {
                    Console.WriteLine($"Ding Dong! You got it, dummy!");
                    return;
                }


            }


        }
    }
}
