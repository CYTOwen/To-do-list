using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BG : MonoBehaviour
{
    public Data data;
    public GameObject bgMain;
    public GameObject bgNoTask;
    public GameObject bgTaskInfo;
    public Text textInfoTitle;
    public Text textInfoDesc;
    public Complete taskInfoName;
    public void Start()
    {
        whetherShowBgNoTask();
    }
    public void whetherShowBgNoTask()
    {
        if (data.taskToday.Count + data.taskComplete.Count == 0)
        {
            bgNoTask.SetActive(true);
            data.hideTask();
        }
        else
        {
            bgNoTask.SetActive(false);
            data.showTask();
        }
    }
    public void showBGMain()
    {
        bgMain.SetActive(true);
    }
    public void hideBGMain()
    {
        bgMain.SetActive(false);
    }
    public void showBGTaskInfo()
    {
        bgTaskInfo.SetActive(true);
    }
    public void hideBGTaskInfo()
    {
        bgTaskInfo.SetActive(false);
    }
    public void setBGTaskInfoData(Complete task)
    {
        taskInfoName = task;
        textInfoTitle.text = task.name;
        textInfoDesc.text = task.desc;
    }
    public void resetTaskInfoName()
    {
        taskInfoName = null;
    }
}
