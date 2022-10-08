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
    private float distanceToday;
    private float distanceComplete;
    private float distanceBetweenTasks;
    private float distanceBetweenTasksFirst;
    // Start is called before the first frame update
    void Start()
    {
        complete = data.complete;
        today = data.today;
        taskComplete = data.taskComplete;
        taskToday = data.taskToday;
        distanceToday = data.distanceToday;
        distanceComplete = data.distanceComplete;
        distanceBetweenTasks = data.distanceBetweenTasks;
        distanceBetweenTasksFirst = data.distanceBetweenTasksFirst;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void completeTask()
    {
        if (this.transform.parent.name == "Today")
        {
            for(int i = 0;i < taskToday.Count;i++)
            {
                if (taskToday[i].transform.position.y < this.transform.position.y)
                    taskToday[i].transform.position += new Vector3(0, distanceBetweenTasks, 0);
            }
            taskToday.Remove(this.gameObject);
            taskComplete.Add(this.gameObject);
            this.transform.SetParent(complete.transform);
            this.transform.localPosition = new Vector3(distanceComplete, (taskComplete.Count-1) * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
            complete.transform.position += new Vector3(0, distanceBetweenTasks, 0);
            
        }
        else if (this.transform.parent.name == "Complete")
        {
            for (int i = 0; i < taskComplete.Count; i++)
            {
                if (taskComplete[i].transform.position.y < this.transform.position.y)
                    taskComplete[i].transform.position += new Vector3(0, distanceBetweenTasks, 0);
            }
            taskToday.Add(this.gameObject);
            taskComplete.Remove(this.gameObject);
            this.transform.SetParent(today.transform);
            this.transform.localPosition = new Vector3(distanceToday, (taskToday.Count-1) * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
            complete.transform.position += new Vector3(0, -distanceBetweenTasks, 0);
        }
        else
            Debug.Log("WR");
    }
}
