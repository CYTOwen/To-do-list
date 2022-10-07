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
    private GameObject complete;
    private GameObject task;
    private GameObject taskIndex;
    private List<GameObject> taskToday;
    // Start is called before the first frame update
    void Start()
    {
        defaultBG = data.defaultBG;
        addUI = data.addUI;
        textTitle = data.textTitle;
        textDesc = data.textDesc;
        today = data.today;
        complete = data.complete;
        taskIndex = data.task;
        taskIndex.SetActive(false);
        taskToday = data.taskToday;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        addUI.SetActive(false);
        task = Instantiate(taskTemplate);
        task.GetComponent<Complete>().data = data;
        task.name = textTitle.text;
        taskTitle = task.GetComponentInChildren<Text>();
        taskTitle.text = textTitle.text;
        task.transform.SetParent(today.transform);
        taskToday.Add(task);
        Debug.Log(taskToday.Count);
        task.transform.localPosition = new Vector3(125.5f, (taskToday.Count-1) * -88f - 67.5f, 0);
        textTitle.text = "";
        textDesc.text = "";
        complete.transform.position += new Vector3(0, -88f, 0);
        defaultBG.SetActive(false);
        taskIndex.SetActive(true);
    }
}
