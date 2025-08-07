using System;
class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt: {prompt}");
        ShowCountdown(5);
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items (press Enter after each item, type 'done' when finished):");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            if (!string.IsNullOrWhiteSpace(item)) items.Add(item);
        }
        Console.WriteLine($"\nYou listed {items.Count} items.");
    }
}
