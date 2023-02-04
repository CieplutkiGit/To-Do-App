using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskDisplay : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI DescriptionText;
    public TextMeshProUGUI StartTimeText;
    public TextMeshProUGUI EndTimeText;
    public Button CompleteButton;

    private Task _task;


    public void Init(Task task)
    {
        _task = task;
        NameText.text = task.Name;
        DescriptionText.text = task.Description;
        StartTimeText.text = task.StartTime.ToString();
        EndTimeText.text = task.EndTime.ToString();

        CompleteButton.onClick.AddListener(() => CompleteTask());
    }

    private void CompleteTask()
    {
        _task.IsCompleted = true;
        gameObject.SetActive(false);
        TaskManager.Instance.RemoveTask(_task);
        TaskManager.Instance.SaveTasks();
    }
}
