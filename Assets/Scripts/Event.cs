using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : Scene
{

    public int id;
    public Event(string title, string content) : base(title,content) {}

    public Event(string title, string content, int id) : base(title,content)
    {
        this.id = id;
    }
}


