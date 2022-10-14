using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public Data data;
    public BG bg;
    public GameObject taskTemplate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        data.hideAddUI();
        Complete newTask = Instantiate(taskTemplate, data.today.transform).GetComponent<Complete>();
        newTask.updateData(data, data.textTitle.text, new Vector3(data.distanceToday, data.taskToday.Count * -data.distanceBetweenTasks - data.distanceBetweenTasksFirst, 0));
        data.addTaskToday(newTask.gameObject);
        data.resetInput();
        data.updateCompletePos();
        bg.whetherShowBgNoTask();
        data.showTask();
    }
}
