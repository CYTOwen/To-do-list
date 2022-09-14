using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_task : MonoBehaviour
{
    public GameObject addUI;
    // Start is called before the first frame update
    void Start()
    {
        addUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTask()
    {
        addUI.SetActive(true);
    }
}
