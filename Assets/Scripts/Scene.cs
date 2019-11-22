using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene
{
    public Scene(string title, string content)
    {
        this.title = title;
        this.content = content;
        this.id = ID.getNewID();
        this.images = new List<ImageInText>();
    }

    public string title;
    public string content;
    public int id;
    public List<ImageInText> images;
}
