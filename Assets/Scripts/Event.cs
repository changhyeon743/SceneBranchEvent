using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : Scene
{

    public int detail; //자원 소모와 추가에 관련된 디테일 추후 추가 요망
    public Event(string title, string content) : base(title,content) {}

    public Event(string title, string content, int id) : base(title,content)
    {
        this.id = id;
    }
}


