using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneManager : MonoBehaviour {

    public static SceneManager instance;

    public List<Branch> branches = new List<Branch>();
    public List<Event> events = new List<Event>();

    public Text mainText;
    public GameObject content;
    public Text titleText;

    public GameObject destinText;
    public GameObject canvas;


    private List<Destination> destinList;

    int currentBranchId = 0;
  

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

        branches.Add(new Branch("조웅이 칼을 들었다.", "멋있엉멋있엉멋있엉멋있엉멋있엉멋엉멋있엉멋있엉멋있엉멋있엉멋있엉멋있엉멋있엉", new Destination[] {
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

    void Start()
    {
        SetUI();
    }

    void SetUI()
    {
        mainText.text = branches[currentBranchId].content;
        titleText.text = branches[currentBranchId].title;

        destinList = branches[currentBranchId].destination;

        int height = 350 / destinList.Count;

        foreach (Destination i in destinList)
        {
            GameObject b = Instantiate(destinText);
            b.transform.parent = canvas.transform;
            b.GetComponent<RectTransform>().anchoredPosition.x = -500 - height;
        }
        

    }

    void SetUI(int id)
    {
        mainText.text = branches[id].content;
        titleText.text = branches[id].title;
        
    }
}
