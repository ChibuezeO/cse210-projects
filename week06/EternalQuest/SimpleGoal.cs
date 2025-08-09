using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{_isComplete}";
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points!");
            if (Points >= 1000)
                Console.WriteLine("🏆 Achievement Unlocked: Epic Goal Master!");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {Name}: {Description} ({Points} points)";
    }

    public override int GetAwardedPoints()
    {
        return _isComplete ? Points : 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}
