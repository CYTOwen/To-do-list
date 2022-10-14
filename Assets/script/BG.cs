using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public Data data;
    public GameObject bgMain;
    public GameObject bgNoTask;
    public void whetherShowBgNoTask()
    {
        if (data.taskToday.Count + data.taskComplete.Count == 0)
            bgNoTask.SetActive(true);
        else
            bgNoTask.SetActive(false);
    }
}
