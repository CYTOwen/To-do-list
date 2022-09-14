using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_task : MonoBehaviour
{
    public GameObject addUI;
    public GameObject title;
    public GameObject desc;
    InputField textTitle;
    InputField textDesc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveTask()
    {
        addUI.SetActive(false);
        textTitle = title.GetComponent<InputField>();
        textDesc = desc.GetComponent<InputField>();
        Debug.Log(textTitle.text + '\n' + textDesc.text);
        textTitle.text = "";
        textDesc.text = "";
    }
}
