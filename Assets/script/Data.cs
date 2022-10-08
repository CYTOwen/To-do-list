using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public GameObject buttonAddTask;
    public GameObject defaultBG;
    public GameObject task;
    public GameObject inputSearch;
    public GameObject today;
    public GameObject complete;
    public GameObject addUI;
    public InputField textTitle;
    public InputField textDesc;
    public List<GameObject> taskToday;
    public List<GameObject> taskComplete;
    public float distanceToday = 125.5f;
    public float distanceComplete = 112.5f;
    public float distanceBetweenTasks = 88f;
    public float distanceBetweenTasksFirst = 67.5f;
}
