using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTask : MonoBehaviour
{
    public GameObject addUI;
    public GameObject defaultBG;
    // Start is called before the first frame update
    void Start()
    {
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
