using System;


int secretNumber = new Random().Next(1, 100);
Console.WriteLine(secretNumber);

Console.WriteLine("Hello! Want to have some fun? Guess my secret number!");


string question = "What's your guess, dummy?";

int num = 4;
while (num > 0)
{

    Console.Write($"{question}: ");
    string answer = Console.ReadLine();
    int parsedAnswer = Int32.Parse(answer);

    if (parsedAnswer != secretNumber)
    {
        Console.WriteLine($"Oh dear, I'm afraid you're wrong. You have {num - 1} more tries.");
        num--;
    }
    else if (parsedAnswer == secretNumber)
    {
        Console.WriteLine($"Ding Dong! You got it!");
        return;
    }


}





