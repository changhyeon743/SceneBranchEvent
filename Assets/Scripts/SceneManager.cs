using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
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
            b.transform.SetParent(canvas.transform);//= canvas.transform;
            b.GetComponent<Text>().text = i.content;
            b.tag = i.eventId.ToString();
            b.name = i.branchId.ToString();
            RectTransform rect = b.GetComponent<RectTransform>();

            EventTrigger eventTrigger = b.AddComponent<EventTrigger>();

            EventTrigger.Entry entry_Click = new EventTrigger.Entry();
            entry_Click.eventID = EventTriggerType.PointerClick;
            entry_Click.callback.AddListener((data) => { OnPointerClick((PointerEventData)data); });
            eventTrigger.triggers.Add(entry_Click);


            //rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, 0);
            //rect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, 0);
            rect.localScale = new Vector2(1, 1);
            rect.offsetMin = new Vector2(100, rect.offsetMin.y);
            rect.offsetMax = new Vector2(-100, rect.offsetMax.y);
            rect.localPosition = new Vector2(rect.localPosition.x, -400-height);
            height += 350 / destinList.Count;
            //rect.SetInsetAndSizeFromParentEdge()
            //b.GetComponent<RectTransform>().
            //b.GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x, -500 - height); // .anchoredPosition.x = -500 - height;
        }
        

    }

    void OnPointerClick(PointerEventData data)
    {
        int eventID = int.Parse(data.pointerEnter.transform.tag);
        int branchID = int.Parse(data.pointerEnter.transform.name);

        Debug.Log(eventID.ToString() + branchID.ToString());
    }

    void SetUI(int id)
    {
        mainText.text = branches[id].content;
        titleText.text = branches[id].title;
        
    }
}
