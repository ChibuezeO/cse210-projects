using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is your magic number? ");
        //string UserEntry = Console.ReadLine();
        //int number = int.Parse(UserEntry);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("What is your guess? ");

        string UserEntry1 = Console.ReadLine();
        int guess = int.Parse(UserEntry1);
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");

        while (guess != number)
        {


            if (guess > number)
            {
                Console.WriteLine("Your guess is greater than the magic number.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is lower than the magic number.");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed right!!");
            }
            else
            {
                Console.WriteLine("Please put a valid number.");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed right!!");
    }
}