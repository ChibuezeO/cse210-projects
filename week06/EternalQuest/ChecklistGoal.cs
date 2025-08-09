using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{_targetCount},{_currentCount},{_bonusPoints}";
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Recorded '{Name}'! You earned {Points} points! ({_currentCount}/{_targetCount})");
            if (_currentCount == _targetCount)
            {
                Console.WriteLine($"Goal '{Name}' completed! Bonus: {_bonusPoints} points!");
                Console.WriteLine("🎉 Achievement Unlocked: Checklist Champion!");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[{(_currentCount >= _targetCount ? "X" : " ")}] {Name}: {Description} ({Points} points each, {_currentCount}/{_targetCount}, Bonus: {_bonusPoints} points)";
    }

    public override int GetAwardedPoints()
    {
        int total = _currentCount * Points;
        if (_currentCount >= _targetCount)
            total += _bonusPoints;
        return total;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}