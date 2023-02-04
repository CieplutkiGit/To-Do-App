using System;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public List<Task> TaskList = new List<Task>();

    public void AddTask(Task task)
    {
        TaskList.Add(task);
    }

    public void RemoveTask(Task task)
    {
        TaskList.Remove(task);
    }

    public void EditTask(Task task, string name, string description, DateTime startTime, DateTime endTime)
    {
        task.Name = name;
        task.Description = description;
        task.StartTime = startTime;
        task.EndTime = endTime;
    }
}
