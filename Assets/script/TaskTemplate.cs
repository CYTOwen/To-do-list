using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTemplate
{
    public string Title;
    public string Desc;
    public string Time;
    public bool IsComplete;
    public TaskTemplate(string title, string desc, string time)
    {
        Title = title;
        Desc = desc;
        Time = time;
        IsComplete = false;
    }
}
