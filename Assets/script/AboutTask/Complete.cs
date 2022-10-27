using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Complete : MonoBehaviour
{
    public Data data;
    public BG bg;
    public TaskTemplate task;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateData(Data dataa, BG bgg, TaskTemplate newTask)
    {
        data = dataa;
        bg = bgg;
        setScriptRef(data, bg);
        RectTransform posThis = this.transform as RectTransform;
        data.addTaskToday(posThis);
        task = newTask;
        this.name = newTask.Title;
        updateTaskUI();
    }
    public void setScriptRef(Data data, BG bg)
    {
        Info info = this.GetComponent<Info>();
        info.bg = bg;
        info.data = data;
        Delete delete = this.GetComponent<Delete>();
        delete.bg = bg;
        delete.data = data;
    }
    public void updateTaskUI()
    {
        transform.GetChild(0).gameObject.GetComponent<Text>().text = task.Title;
        transform.GetChild(1).gameObject.GetComponent<Text>().text = task.Time;
    }
    public void completeTask()
    {
        data.switchTask(this.transform as RectTransform);
        data.updateAllPos();
        Debug.Log(data.taskToday.Count + "\n" + data.taskComplete.Count);
    }
    public void completeTaskInInfo()
    {
        data.switchTask(bg.taskInfoTargetName.transform as RectTransform);
        bg.resetTaskInfoName();
        bg.hideBGTaskInfo();
        bg.showBGMain();
        data.showTask();
        data.updateAllPos();
    }
}
