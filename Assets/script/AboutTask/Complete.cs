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
    public void updateData(Data data, TaskTemplate newTask)
    {
        setScriptRef(this.gameObject, data, bg);
        RectTransform posThis = this.transform as RectTransform;
        data.addTaskToday(posThis);
        this.data = data;
        this.task = newTask;
    }
    public void setScriptRef(GameObject task, Data data, BG bg)
    {
        Info info = task.GetComponent<Info>();
        info.bg = bg;
        info.data = data;
        Delete delete = task.GetComponent<Delete>();
        delete.bg = bg;
        delete.data = data;
    }
    public void completeTask()
    {
        data.switchTask(this.transform as RectTransform);
        data.updateAllPos();
    }
    public void completeTaskFromInfo()
    {
        data.switchTask(bg.taskInfoName.transform as RectTransform);
        bg.resetTaskInfoName();
        bg.hideBGTaskInfo();
        bg.showBGMain();
        data.showTask();
        data.updateAllPos();
    }
}
