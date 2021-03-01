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
            Console.Write($"{question}: ");
            string answer = Console.ReadLine();
            Console.Write(answer);



        }
    }
}
