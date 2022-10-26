using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTask : MonoBehaviour
{
    public Data data;
    public BG bg;
    public GameObject taskTemplate;
    // Start is called before the first frame update
    public void saveTask()
    {
        data.hideAddUI();
        Complete newTask = Instantiate(taskTemplate, data.today.transform).GetComponent<Complete>();
        newTask.updateData(data, new TaskTemplate(data.textTitle.text, data.textDesc.text, "Not Today"));
        data.resetInput();
        data.updateAllPos();
        bg.whetherShowBgNoTask();
        data.showTask();
    }
}
