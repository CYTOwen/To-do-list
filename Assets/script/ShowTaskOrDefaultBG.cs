using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTaskOrDefaultBG : MonoBehaviour
{
    public GameObject defaultBG;
    public GameObject task;
    private int numOfTask;
    // Start is called before the first frame update
    void Start()
    {
        numOfTask = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfTask == 0)
        {
            defaultBG.SetActive(true);
            task.SetActive(false);
        }
        else
        {
            defaultBG.SetActive(false);
            task.SetActive(true);
        }
    }
    public void hide()
    {
        task.SetActive(false);
    }
    public void addTask()
    {
        numOfTask++;
    }
}
