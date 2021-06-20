using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class sunglassdata
{
    public bool unlocked;
    public bool selected;

    public sunglassdata(Mainmenu main)
    {
        unlocked = main.sunglassunlocked;
        selected = main.sunglassselcted;

    }



}
