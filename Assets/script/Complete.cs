using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Complete : MonoBehaviour
{
    public Data data;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateData(Data data, string title, Vector3 position)
    {
        RectTransform posThis = this.transform as RectTransform;
        posThis.anchoredPosition3D = position;
        data.addTaskToday(posThis);
        this.data = data;
        this.GetComponentInChildren<Text>().text = title;
        this.name = title;
    }
    public void completeTask()
    {
        data.switchTask(this.transform as RectTransform);
        data.updateAllPos();
    }
}
