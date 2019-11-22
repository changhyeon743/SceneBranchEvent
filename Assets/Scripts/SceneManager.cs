using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SceneManager : MonoBehaviour {

    public static SceneManager instance;

    public List<Branch> branches = new List<Branch>();
    public List<Event> events = new List<Event>();

    public Branch getBranch(int id)
    {
        foreach (Branch i in branches)
        {
            if (i.id == id)
            {
                return i;
            }
        }
        return null;
    }

    //public List<Event> getEvents(int parentToken)
    //{
    //    List<Event> temp = new List<Event>();
    //    foreach (Event i in events)
    //    {
    //        if (i.id == parentToken)
    //        {
    //            temp.Add(i);
    //        }
    //    }
    //    return temp;
    //}

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        events.Add(new Event("으악", "적이 죽었다.",0));
        events.Add(new Event("으악", "내가 죽었다.",1));

        branches.Add(new Branch("조웅이 칼을 들었다.","멋있엉",new Destination[] {
            new Destination("휘두른다.",0,4),
            new Destination("도망간다.",1,3),
        },2));

        branches.Add(new Branch("패배.", "으악", new Destination[] {
        },3));
        branches.Add(new Branch("승리.", "야호!", new Destination[] {
        },4));

       // Debug.Log("1213: "+branches[0].destination[0].content);

        branches[0].printInfo();
    }
}
