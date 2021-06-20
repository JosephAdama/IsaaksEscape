using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class booldata 
{
    public bool unlocked;

    public booldata(Mainmenu main)
    {
        unlocked = main.unlock;

    }



}
