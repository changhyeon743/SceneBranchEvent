using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Branch : Scene
{
    public Branch(string title, string content, Destination[] destination) : base(title,content)
    {
        this.destination = new List<Destination>();
        this.destination.AddRange(destination);
    }

    public Branch(string title, string content, Destination[] destination, int id)  : base(title, content)
    {
        this.destination = new List<Destination>();
        this.destination.AddRange(destination);
        this.id = id;
    }

    public List<Destination> destination;

    public void printInfo()
    {
        Debug.Log("현재 분기의 제목: "+title);
        Debug.Log("현재 컨텐츠: "+content);
        int i=0;
        foreach (Destination j in destination)
        {
            Debug.Log("목적지"+(i++).ToString()+ j.content);
        }
    }
}
