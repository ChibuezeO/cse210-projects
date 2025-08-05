using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Gordon B. Hinckley", "Teachings of The Presidents Of The church");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("James E. Talmage", "Jesus The Christ", "Lord of The Sabbath");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}