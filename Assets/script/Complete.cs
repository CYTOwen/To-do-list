using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public Data data;
    private RectTransform posThis;
    private RectTransform posOther;
    private GameObject complete;
    private RectTransform completePos;
    private GameObject today;
    private RectTransform todayPos;
    private List<GameObject> taskComplete;
    private List<GameObject> taskToday;
    private float distanceToday;
    private float distanceComplete;
    private float distanceBetweenTasks;
    private float distanceBetweenTasksFirst;
    // Start is called before the first frame update
    void Start()
    {
        posThis = this.transform as RectTransform;
        complete = data.complete;
        completePos = data.completePos;
        today = data.today;
        todayPos = data.todayPos;
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
        if (posThis.parent.name == "Today")
        {
            for(int i = 0;i < taskToday.Count;i++)
            {
                posOther = taskToday[i].transform as RectTransform;
                if (posOther.anchoredPosition3D.y < posThis.anchoredPosition3D.y)
                    posOther.anchoredPosition3D += new Vector3(0, distanceBetweenTasks, 0);
            }
            taskToday.Remove(this.gameObject);
            taskComplete.Add(this.gameObject);
            posThis.SetParent(completePos);
            posThis.anchoredPosition3D = new Vector3(distanceComplete, (taskComplete.Count-1) * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
            completePos.anchoredPosition3D += new Vector3(0, distanceBetweenTasks, 0);
            
        }
        else if (posThis.parent.name == "Complete")
        {
            for (int i = 0; i < taskComplete.Count; i++)
            {
                posOther = taskComplete[i].transform as RectTransform;
                if (posOther.anchoredPosition3D.y < posThis.anchoredPosition3D.y)
                    posOther.anchoredPosition3D += new Vector3(0, distanceBetweenTasks, 0);
            }
            taskToday.Add(this.gameObject);
            taskComplete.Remove(this.gameObject);
            posThis.SetParent(todayPos);
            posThis.anchoredPosition3D = new Vector3(distanceToday, (taskToday.Count-1) * -distanceBetweenTasks - distanceBetweenTasksFirst, 0);
            completePos.anchoredPosition3D += new Vector3(0, -distanceBetweenTasks, 0);
        }
        else
            Debug.Log("WR");
    }
}
