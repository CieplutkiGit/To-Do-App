using System;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public InputField NameInput;
    public InputField DescriptionInput;
    public InputField StartTimeInput;
    public InputField EndTimeInput;
    public Button AddTaskButton;
    public GameObject TaskPrefab;
    public Transform TaskContainer;
    public TaskManager TaskManager;

    private void Start()
    {
        AddTaskButton.onClick.AddListener(AddTask);
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
    }
}
