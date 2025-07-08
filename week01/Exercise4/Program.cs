using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        float total = 0;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                total += userNumber;
            }
        }
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        float average = total / numbers.Count;
        Console.WriteLine($"The Sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The maximum nmber is {max}");
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
    }
}