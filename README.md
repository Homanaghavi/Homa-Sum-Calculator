# Homa-Sum-Calculator
A simple C# console application that adds •two integers
using System;
class Program
{
    static void Main()
    {
        int score = 0;
        string answer;
        Console.WriteLine("************************");
        Console.WriteLine("     MINI QUIZ GAME");
        Console.WriteLine("************************");
        Console.WriteLine("\n1. What is the capital of France?");
        Console.WriteLine("a) London");
        Console.WriteLine("b) Paris");
        Console.WriteLine("c) Berlin");
        Console.Write("Your answer: ");
        answer = Console.ReadLine();
        if (answer == "b")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
        Console.WriteLine("\n2. What is 5 + 7?");
        Console.Write("Your answer: ");
        answer = Console.ReadLine();
        if (answer == "12")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
        Console.WriteLine("\n3. Which language are we learning?");
        Console.WriteLine("a) Python");
        Console.WriteLine("b) C#");
        Console.WriteLine("c) Java");
        Console.Write("Your answer: ");
        answer = Console.ReadLine();
        if (answer == "b")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
        Console.WriteLine("\n************************");
        Console.WriteLine("Your score: " + score + "/3");
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("************************");
    }
}
