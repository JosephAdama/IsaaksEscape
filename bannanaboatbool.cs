using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class bananaboatbool
{
    public bool unlocked;
    public bool selected;

    public bananaboatbool(Mainmenu main)
    {
        unlocked = main.bananaunlocked;
        selected = main.bananasselcted;

    }



}

