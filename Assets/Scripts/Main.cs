using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    public TMP_InputField NameInput;
    public TMP_InputField DescriptionInput;
    public TMP_InputField StartTimeInput;
    public TMP_InputField EndTimeInput;
    public Button AddTaskButton;
    public GameObject TaskPrefab;
    public Transform TaskContainer;
    public TaskManager TaskManager;

     private void Start()
    {
        AddTaskButton.onClick.AddListener(AddTask);
        TaskManager.LoadTasks();
        DisplayTasks();
    }

    private void DisplayTasks()
    {
        foreach (Task task in TaskManager.TaskList)
        {
            GameObject taskGO = Instantiate(TaskPrefab, TaskContainer);
            taskGO.GetComponent<TaskDisplay>().Init(task);
        }
    }

    private void AddTask()
    {

        string name = NameInput.text;
        string description = DescriptionInput.text;
        DateTime startTime = DateTime.Parse(StartTimeInput.text);
        DateTime endTime = DateTime.Parse(EndTimeInput.text);

        Task task = new Task(name, description, startTime, endTime);
        TaskManager.AddTask(task);

        GameObject taskGO = Instantiate(TaskPrefab, TaskContainer);
        taskGO.GetComponent<TaskDisplay>().Init(task);


        TaskManager.SaveTasks();
    }
}
