using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void Run()
    {
        ShowStartingMessage();
        PerformActivity();
        ShowEndingMessage();
    }

    private void ShowStartingMessage()
    {
        Console.WriteLine($"\n{_name}");
        Console.WriteLine(_description);
        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            if (int.TryParse(Console.ReadLine(), out _duration) && _duration > 0)
                break;
            Console.WriteLine("Please enter a valid positive number.");
        }
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    private void ShowEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(2);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] frames = { '-', '\\', '|', '/' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char frame in frames)
            {
                Console.Write($"\r{frame}");
                Thread.Sleep(200);
            }
        }
        Console.Write("\r   ");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   ");
    }

    protected abstract void PerformActivity();

    protected int Duration => _duration;
}
