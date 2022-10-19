using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public BG bg;
    public GameObject buttonAddTask;
    public GameObject task;   //由today, complete, 及inputSearch三個子物件組成的物件
    public GameObject inputSearch;
    public GameObject today;
    public RectTransform todayPos;
    public GameObject complete;
    public RectTransform completePos;
    public GameObject addUI;   //底下兩行為AddUI的兩項輸入
    public InputField textTitle;
    public InputField textDesc;
    public List<RectTransform> taskToday;
    public List<RectTransform> taskComplete;
    public float distanceToday = 125.5f;
    public float distanceComplete = 112.5f;
    public float distanceBetweenTasks = 88f;
    public float distanceBetweenTasksFirst = 67.5f;
    public Vector3 completePosOrg = new Vector3(-112.5f, 157.5f, 0);
    public void showAddUI()
    {
        addUI.SetActive(true);
    }
    public void hideAddUI()
    {
        addUI.SetActive(false);
    }
    public void addTaskToday(RectTransform task)
    {
        taskToday.Add(task);
    }
    public void removeTaskToday(RectTransform task)
    {
        taskToday.Remove(task);
    }
    public void addTaskComplete(RectTransform task)
    {
        taskComplete.Add(task);
    }
    public void removeTaskComplete(RectTransform task)
    {
        taskComplete.Remove(task);
    }
    public void switchTask(RectTransform task)
    {
        if (taskToday.Exists(x => x.name == task.name))
        {
            taskToday.Remove(task);
            taskComplete.Add(task);
            task.SetParent(complete.transform);
        }
        else
        {
            taskComplete.Remove(task);
            taskToday.Add(task);
            task.SetParent(today.transform);
        }
    }
    public void updateAllPos()
    {
        for(int i = 0; i < taskToday.Count; i++)
            taskToday[i].anchoredPosition3D = new Vector3(distanceToday, i * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
        completePos.anchoredPosition3D = completePosOrg - new Vector3(0, taskToday.Count * distanceBetweenTasks, 0);
        for (int i = 0; i < taskComplete.Count; i++)
            taskComplete[i].anchoredPosition3D = new Vector3(distanceComplete, i * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
    }
    public void resetInput()
    {
        textTitle.text = "";
        textDesc.text = "";
    }
    public void updateCompletePos()
    {
        completePos.anchoredPosition3D = completePosOrg - new Vector3(0, taskToday.Count * distanceBetweenTasks, 0);
    }
    public void showTask()
    {
        task.SetActive(true);
    }
    public void hideTask()
    {
        task.SetActive(false);
    }
}
