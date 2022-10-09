using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public Data data;
    private GameObject defaultBG;
    private GameObject addUI;
    private InputField textTitle;
    private InputField textDesc;
    public GameObject taskTemplate;
    private Text taskTitle;
    private GameObject today;
    private RectTransform completePos;
    private GameObject task;
    private RectTransform taskPos;
    private GameObject taskIndex;
    private List<GameObject> taskToday;
    private float distanceToday;
    private float distanceBetweenTasks;
    private float distanceBetweenTasksFirst;
    // Start is called before the first frame update
    void Start()
    {
        defaultBG = data.defaultBG;
        addUI = data.addUI;
        textTitle = data.textTitle;
        textDesc = data.textDesc;
        today = data.today;
        completePos = data.completePos;
        taskIndex = data.task;
        taskIndex.SetActive(false);
        taskToday = data.taskToday;
        distanceToday = data.distanceToday;
        distanceBetweenTasks = data.distanceBetweenTasks;
        distanceBetweenTasksFirst = data.distanceBetweenTasksFirst;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        addUI.SetActive(false);
        task = Instantiate(taskTemplate);
        taskPos = task.transform as RectTransform;
        task.GetComponent<Complete>().data = data;
        task.name = textTitle.text;
        taskTitle = task.GetComponentInChildren<Text>();
        taskTitle.text = textTitle.text;
        task.transform.SetParent(today.transform);
        taskToday.Add(task);
        taskPos.anchoredPosition3D = new Vector3(distanceToday, (taskToday.Count-1) * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
        textTitle.text = "";
        textDesc.text = "";
        completePos.anchoredPosition3D += new Vector3(0, -distanceBetweenTasks, 0);
        defaultBG.SetActive(false);
        taskIndex.SetActive(true);
    }
}
