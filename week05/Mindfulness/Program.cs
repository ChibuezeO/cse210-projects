/*To show creativity, I added lines of code in the activity class from lines 31 to 34 to check that the user enters
a valid number instead of another character n which case the program displays a message and gives the user anoher 
opportunity to make the correct entry. I also added a  check in the program.cs to display a message to the user in 
case they make the wrong input when selectin the activity so that the program does not terminate but allows them to 
correct their rntry  */

using System;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Activity> activities = new Dictionary<string, Activity>
            {
                { "1", new BreathingActivity() },
                { "2", new ReflectionActivity() },
                { "3", new ListingActivity() }
            };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please choose an option (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            if (activities.ContainsKey(choice))
            {
                Console.Clear();
                activities[choice].Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                Thread.Sleep(2000);
            }
        }
    }
}