using System;

//setup game with random number generator, intro message and level question/answer:
int secretNumber = new Random().Next(1, 100);
Console.WriteLine(secretNumber);

Console.WriteLine("Hello! Want to have some fun? Let's play a guessing game.");

string questionLevel = "Choose a level: Easy, Medium, or Hard? (E/M/H)";

Console.Write($"{questionLevel}: ");
string answerLevel = Console.ReadLine().ToLower();

//IF player chooses easy:
if (answerLevel == "e")
{
    Console.Write("Easy means you have 8 guesses! Choose a number between 1 and 100: ");
    int num = 8;
    while (num > 0)
    {
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);

        if (parsedAnswer != secretNumber)
        {
            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine($"Too high. You have {num - 1} of 8 more tries.");
                num--;
            }
            else
            {
                Console.WriteLine($"Sigh, I'm afraid your answer is too low. You have {num - 1} of 8 more tries.");
                num--;
            }
        }
        else if (parsedAnswer == secretNumber)
        {
            Console.WriteLine($"I knew you could do it!");
            return;
        }

    }
}
else if (answerLevel == "m")
{
    Console.Write("Medium means you have 6 guesses! Choose a number between 1 and 100: ");
    int num = 6;
    while (num > 0)
    {
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);

        if (parsedAnswer != secretNumber)
        {
            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine($"Too high. You have {num - 1} of 6 more tries.");
                num--;
            }
            else
            {
                Console.WriteLine($"Sigh, I'm afraid your answer is too low. You have {num - 1} of 6 more tries.");
                num--;
            }
        }
        else if (parsedAnswer == secretNumber)
        {
            Console.WriteLine($"I knew you could do it!");
            return;
        }
    }
}
else if (answerLevel == "h")
{
    Console.Write("Hard means you have 4 guesses! Choose a number between 1 and 100: ");
    int num = 4;
    while (num > 0)
    {
        string answer = Console.ReadLine();
        int parsedAnswer = Int32.Parse(answer);

        if (parsedAnswer != secretNumber)
        {
            if (parsedAnswer > secretNumber)
            {
                Console.WriteLine($"Too high. You have {num - 1} of 4 more tries.");
                num--;
            }
            else
            {
                Console.WriteLine($"Sigh, I'm afraid your answer is too low. You have {num - 1} of 4 more tries.");
                num--;
            }
        }
        else if (parsedAnswer == secretNumber)
        {
            Console.WriteLine($"I knew you could do it!");
            return;
        }
    }
}







