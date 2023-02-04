using UnityEngine;
using UnityEngine.UI;

public class TaskDisplay : MonoBehaviour
{
    public Text NameText;
    public Text DescriptionText;
    public Text StartTimeText;
    public Text EndTimeText;
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
    }
}
