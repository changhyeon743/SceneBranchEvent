using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination
{
    public Destination(string content, int eventId, int branchId)
    {
        this.branchId = branchId;
        this.content = content;
        this.eventId = eventId;
    }
    public string content;
    public int branchId;
    public int eventId;
}