using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public BG bg;
    public GameObject buttonAddTask;
    public GameObject task;   //��today, complete, ��inputSearch�T�Ӥl����զ�������
    public GameObject inputSearch;
    public GameObject today;
    public RectTransform todayPos;
    public GameObject complete;
    public RectTransform completePos;
    public GameObject addUI;   //���U��欰AddUI���ⶵ��J
    public InputField textTitle;
    public InputField textDesc;
    public List<GameObject> taskToday;
    public List<GameObject> taskComplete;
    public float distanceToday = 125.5f;
    public float distanceComplete = 112.5f;
    public float distanceBetweenTasks = 88f;
    public float distanceBetweenTasksFirst = 67.5f;
    public Vector3 completePosOrg = new Vector3(-112.5f, 157.5f, 0);

    /*========AddTask========*/

    public void showAddUI()
    {
        addUI.SetActive(true);
    }
    public void hideAddUI()
    {
        addUI.SetActive(false);
    }

    /*========SaveTask========*/

    public void addTaskToday(GameObject task)
    {
        taskToday.Add(task);
    }

    public void resetInput()
    {
        textTitle.text = "";
        textDesc.text = "";
    }
    public void updateCompletePos()
    {
        completePos.position = completePosOrg - new Vector3(0, taskToday.Count * distanceBetweenTasks, 0);
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
