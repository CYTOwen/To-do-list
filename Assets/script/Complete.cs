using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public Data data;
    private GameObject complete;
    private GameObject today;
    private int numOfTaskCo;
    private int numOfTaskTo;
    private GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        complete = data.complete;
        today = data.today;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void completeTask()
    {
        parent = this.transform.parent.gameObject;
        if (parent.transform.parent.name == "Today")
        {
            foreach(Transform child in today.transform)
            {
                if(child.transform.position.y < parent.transform.position.y)
                    child.transform.position += new Vector3(0, 88f, 0);
            }
            parent.transform.SetParent(complete.transform);
            numOfTaskCo = complete.transform.childCount - 1;
            parent.transform.localPosition = new Vector3(112.5f, numOfTaskCo * -88f - 67.5f, 0);
            complete.transform.position += new Vector3(0, 88f, 0);
        }
        else if (parent.transform.parent.name == "Complete")
        {
            foreach (Transform child in complete.transform)
            {
                if (child.transform.position.y < parent.transform.position.y)
                    child.transform.position += new Vector3(0, 88f, 0);
            }
            parent.transform.SetParent(today.transform);
            numOfTaskTo = today.transform.childCount - 1;
            parent.transform.localPosition = new Vector3(125.5f, numOfTaskTo * -88f - 67.5f, 0);
            complete.transform.position += new Vector3(0, -88f, 0);
        }
        else
            Debug.Log("WR");
    }
}
