using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTask : MonoBehaviour
{
    public Data data;
    private GameObject addUI;
    // Start is called before the first frame update
    void Start()
    {
        addUI = data.addUI;
        addUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addTask()
    {
        addUI.SetActive(true);
    }
}
