using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            if (_count == _target)
                return GetPoints() + _bonus;

            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} (Completed {_count}/{_target})";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_count}";
    }
}