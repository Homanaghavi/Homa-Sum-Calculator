
using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to Homa's Quiz Game!");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("1. What is the capital of France?");
        string answer1 = Console.ReadLine();

        if (answer1.ToLower() == "paris")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is Paris.");
        }

        Console.WriteLine();

        Console.WriteLine("2. How many days are in a week?");
        string answer2 = Console.ReadLine();

        if (answer2 == "7")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is 7.");
        }

        Console.WriteLine();

        Console.WriteLine("3. What is 5 + 5?");
        string answer3 = Console.ReadLine();

        if (answer3 == "10")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is 10.");
        }

        Console.WriteLine();
        Console.WriteLine("Your final score: " + score + "/3");

        Console.WriteLine("Thanks for playing!");
    }
}
