using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public GameObject addUI;
    public GameObject title;
    public GameObject desc;
    InputField textTitle;
    InputField textDesc;
    public GameObject taskTemplate;
    public GameObject parent;
    private GameObject task;
    private int numOfTask;
    // Start is called before the first frame update
    void Start()
    {
        numOfTask = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        addUI.SetActive(false);
        textTitle = title.GetComponent<InputField>();
        textDesc = desc.GetComponent<InputField>();
        Debug.Log(textTitle.text + '\n' + textDesc.text);
        task = Instantiate(taskTemplate);
        task.transform.parent = parent.transform;
        task.transform.localPosition = new Vector3(0, numOfTask * -88, 0);
        task.SetActive(true);
        textTitle.text = "";
        textDesc.text = "";
        numOfTask++;
    }
}
