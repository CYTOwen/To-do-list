using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTemplate
{
    public string Title;
    public string Desc;
    public Vector3 Positon;
    public TaskTemplate(string title, string desc, Vector3 position)
    {
        Title = title;
        Desc = desc;
        Positon = position;
    }
}
