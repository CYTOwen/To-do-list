using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public Data data;
    private GameObject complete;
    private GameObject today;
    private List<GameObject> taskComplete;
    private List<GameObject> taskToday;
    // Start is called before the first frame update
    void Start()
    {
        complete = data.complete;
        today = data.today;
        taskComplete = data.taskComplete;
        taskToday = data.taskToday;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void completeTask()
    {
        if (this.transform.parent.name == "Today")
        {
            foreach (Transform child in today.transform)
            {
                if (child.transform.position.y < this.transform.position.y)
                    child.transform.position += new Vector3(0, 88f, 0);
            }
            taskToday.Remove(this.gameObject);
            taskComplete.Add(this.gameObject);
            this.transform.SetParent(complete.transform);
            this.transform.localPosition = new Vector3(112.5f, (taskComplete.Count-1) * -88f - 67.5f, 0);
            complete.transform.position += new Vector3(0, 88f, 0);
            
        }
        else if (this.transform.parent.name == "Complete")
        {
            foreach (Transform child in complete.transform)
            {
                if (child.transform.position.y < this.transform.position.y)
                    child.transform.position += new Vector3(0, 88f, 0);
            }
            taskToday.Add(this.gameObject);
            taskComplete.Remove(this.gameObject);
            this.transform.SetParent(today.transform);
            this.transform.localPosition = new Vector3(125.5f, (taskToday.Count-1) * -88f - 67.5f, 0);
            complete.transform.position += new Vector3(0, -88f, 0);
        }
        else
            Debug.Log("WR");
    }
}
