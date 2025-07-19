using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool working = true;

        while (working)
        {
            Console.WriteLine("\nJournal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Please select from the options provided by writing the number: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Please enter your response: ");
                string response = Console.ReadLine();
                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    _promptText = prompt,
                    _entryText = response
                };
                journal.AddEntry(newEntry);
                Console.WriteLine("Your response has been added.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Please enter a filename to save journal: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == "4")
            {
                Console.Write("Please enter the filename of the journal to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                working = false;
                Console.WriteLine("Thank you for stopping by!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number between 1-5.");
            }
        }
    }
}