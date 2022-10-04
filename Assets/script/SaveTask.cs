using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public GameObject defaultBG;
    public GameObject addUI;
    public InputField textTitle;
    public InputField textDesc;
    public GameObject taskTemplate;
    public Text templateTitle;
    public GameObject today;
    public GameObject complete;
    private GameObject task;
    public GameObject taskIndex;
    private int numOfTaskTo;
    // Start is called before the first frame update
    void Start()
    {
        taskIndex.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveTask()
    {
        addUI.SetActive(false);
        templateTitle.text = textTitle.text;
        task = Instantiate(taskTemplate);
        task.transform.SetParent(today.transform);
        numOfTaskTo = today.transform.childCount - 1;
        Debug.Log(numOfTaskTo);
        task.transform.localPosition = new Vector3(125.5f, numOfTaskTo * -88f - 67.5f, 0);
        task.SetActive(true);
        textTitle.text = "";
        textDesc.text = "";
        complete.transform.position += new Vector3(0, -88f, 0);
        defaultBG.SetActive(false);
        taskIndex.SetActive(true);
    }
}
