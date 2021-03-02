using System;


int secretNumber = new Random().Next(1, 100);
Console.WriteLine(secretNumber);

Console.WriteLine("Hello! Want to have some fun, dummy?");


string question = "Guess my secret number!";

int num = 4;
while (num > 0)
{

    Console.Write($"{question}: ");
    string answer = Console.ReadLine();
    int parsedAnswer = Int32.Parse(answer);

    if (parsedAnswer != secretNumber)
    {
        if (parsedAnswer > secretNumber)
        {
            Console.WriteLine($"Oh dear, I'm afraid you're answer is too high. You have {num - 1} more tries.");
            num--;
        }
        else
        {
            Console.WriteLine($"Oh dear, I'm afraid you're answer is too low. You have {num - 1} more tries.");
            num--;
        }
    }
    else if (parsedAnswer == secretNumber)
    {
        Console.WriteLine($"Nice job! You got it!");
        return;
    }


}





