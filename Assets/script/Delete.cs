using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
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
    public void deleteTask()
    {
        data.removeTaskToday(this.transform as RectTransform);
        bg.hideBGTaskInfo();
        bg.showBGMain();
    }
}
