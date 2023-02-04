using UnityEngine;
using System;

[System.Serializable]
public class Task
{
    public string Name;
    public string Description;
    public DateTime StartTime;
    public DateTime EndTime;
    public bool IsCompleted;

    public Task(string name, string description, DateTime startTime, DateTime endTime)
    {
        Name = name;
        Description = description;
        StartTime = startTime;
        EndTime = endTime;
        IsCompleted = false;
    }
}
