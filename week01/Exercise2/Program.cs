using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score percentage? ");
        string UserEntry = Console.ReadLine();
        int score = int.Parse(UserEntry);
        string grade = " ";

        if (score >= 90)
        {
            grade = "A";
        }

        else if (score >= 80)
        {
            grade = "B";
        }

        else if (score >= 70)
        {
            grade = "C";
        }

        else if (score >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your score grade is {grade}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed!!");
        }

        else
        {
            Console.WriteLine("Kindly work harder next time.");
        }

    }
}