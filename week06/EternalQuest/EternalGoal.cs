using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded '{Name}'! You earned {Points} points!");
        if (Points >= 100)
            Console.WriteLine("🌟 Achievement Unlocked: Consistent Questor!");
    }

    public override string GetStatus()
    {
        return $"[ ] {Name}: {Description} ({Points} points each time)";
    }

    public override int GetAwardedPoints()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return false;
    }
}