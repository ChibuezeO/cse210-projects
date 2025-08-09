using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type=> 1. Simple 2. Eternal 3. Checklist");
        string choice = Console.ReadLine();
        Console.Write("What is the goal name? ");
        string name = Console.ReadLine();
        Console.Write("Description your goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points for this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("What is the target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetAwardedPoints();
            UpdateLevel();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void UpdateLevel()
    {
        int newLevel = _score / 1000 + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 Level Up! You are now a Level {_level} Ninja Unicorn!");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} points | Level: {_level} Ninja Unicorn");
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_level);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);
            _goals.Clear();
            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] details = parts[1].Split(",");

                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2]))
                    {
                    });
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[5]))
                    {
                    });
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}