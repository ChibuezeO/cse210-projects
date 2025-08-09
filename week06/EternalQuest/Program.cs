/* To show creativity, I added some lines of codes from lines 130 through 135 in the GoalManager class
to check and ensure that a user first of all completes and saves at least one goal before trying to
load or view saved goals When you try to load before saving any goal, the system reminds you of
the need to save a goal first before trying to view or load one and still gives you an oppotunity
to create a goal instead of causing an error or terminating.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.RecordEvent();
            else if (choice == "3") manager.ListGoals();
            else if (choice == "4") manager.DisplayScore();
            else if (choice == "5") manager.SaveGoals();
            else if (choice == "6") manager.LoadGoals();
            else if (choice == "7") break;
            else Console.WriteLine("Invalid option.");
        }
    }
}