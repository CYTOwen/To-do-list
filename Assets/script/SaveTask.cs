using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public GameObject addUI;
    public GameObject title;
    public GameObject desc;
    public InputField textTitle;
    public InputField textDesc;
    public GameObject taskTemplate;
    public Text templateTitle;
    public GameObject today;
    public GameObject complete;
    private GameObject task;
    private int numOfTask;
    private int numOfTaskCo;
    // Start is called before the first frame update
    void Start()
    {
        numOfTask = 0;
        numOfTaskCo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        addUI.SetActive(false);
        Debug.Log(textTitle.text + '\n' + textDesc.text);
        templateTitle.text = textTitle.text;
        task = Instantiate(taskTemplate);
        task.transform.SetParent(today.transform);
        task.transform.localPosition = new Vector3(125.5f, numOfTask * -88f - 67.5f, 0);
        task.SetActive(true);
        textTitle.text = "";
        textDesc.text = "";
        numOfTask++;
    }
    public void Complete()
    {
        task.transform.SetParent(complete.transform);
        task.transform.localPosition = new Vector3(112.5f, numOfTaskCo * -88f - 67.5f, 0);
        numOfTaskCo++;
    }
}
