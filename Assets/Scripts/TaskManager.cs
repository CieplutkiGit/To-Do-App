using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class TaskManager : MonoBehaviour
{
    public List<Task> TaskList = new List<Task>();
    private readonly string fileName = "tasks.json";

    public static TaskManager Instance;

    void Awake()
    {
        Instance = this;
    }

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
        SaveTasks();
    }

    public void SaveTasks()
    {
        string json = JsonConvert.SerializeObject(TaskList, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/" + fileName, json);
    }

    public void LoadTasks()
    {
        if (File.Exists(Application.persistentDataPath + "/" + fileName))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/" + fileName);
            TaskList = JsonConvert.DeserializeObject<List<Task>>(json);
        }
    }
}
