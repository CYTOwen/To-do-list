using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public Data data;
    public BG bg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openTaskInfo()
    {
        bg.hideBGMain();
        data.hideTask();
        bg.showBGTaskInfo();
        bg.setBGTaskInfoData(this.GetComponent<Complete>());
    }
}
