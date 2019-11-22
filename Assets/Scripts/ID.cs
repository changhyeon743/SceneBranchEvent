using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ID  {
    public static int currentID;

    public static int getNewID() {
        return (++currentID);
    } 
}
