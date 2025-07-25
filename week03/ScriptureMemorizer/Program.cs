/*I had my program work with a library of scriptures rather than a single one. 
To do this, I enhanced the program by adding a ScriptureLibrary class to manage a collection 
of scriptures and randomly select one each time the program runs. This enabled the program to
accommodate multiple scriptures and select one at randon to display. I also created the methods
to interact with the class.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.AddScripture(new Reference("Jacob 2:17-18"),
            @"17. Think of your brethren like unto yourselves, and be familiar 
        with all and free with your substance, that they may be rich like unto you. 
        18. But before ye seek for riches, seek ye for the kingdom of God.");
        library.AddScripture(new Reference("Doctrine_and_Covenants 19:29-30"),
            @"And thou shalt declare glad tidings, yea, publish it upon the mountains, 
            and upon every high place, and among every people that thou shalt be permitted 
            to see. 30. And thou shalt do it with all humility, trusting in me, reviling not against revilers.");
        library.AddScripture(new Reference("Mathew 12:25-26"),
            @"And Jesus knew their thoughts, and said unto them, Every kingdom divided against 
            itself is brought to desolation; and every city or house divided against itself shall not stand:
            26. And if Satan cast out Satan, he is divided against himself; how shall then his kingdom stand?");

        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n Please Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. The program ends here.");
    }
}