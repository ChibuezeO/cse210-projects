using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        int userNumber = PromptUserNumber();
        string userName = PromptUserName();

        int numbersquare = SquareNumber(userNumber);
        DisplayResult(userName, numbersquare);

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            int favnumber = int.Parse(Console.ReadLine());

            return favnumber;
        }

        static int SquareNumber(int favnumber)
        {
            int square = favnumber * favnumber;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the sqrae root of your number is {square}");
        }
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
}