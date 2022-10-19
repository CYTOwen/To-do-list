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
        newTask.updateData(data, bg, data.textTitle. text,data.textDesc.text, new Vector3(data.distanceToday, data.taskToday.Count * -data.distanceBetweenTasks - data.distanceBetweenTasksFirst, 0));
        data.resetInput();
        data.updateCompletePos();
        bg.whetherShowBgNoTask();
        data.showTask();
    }
}
