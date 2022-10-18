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
    public void whetherShowBgNoTask()
    {
        if (data.taskToday.Count + data.taskComplete.Count == 0)
            bgNoTask.SetActive(true);
        else
            bgNoTask.SetActive(false);
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
    public void setBGTaskInfoText()
    {
        textInfoTitle.text = this.name;
    }
}
