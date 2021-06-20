using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Forestdata
{
    public float lastscoreig;
    public float Highscore;

    public Forestdata(winlvl2 winlvl2)
    {
        lastscoreig = winlvl2.mayHighscore;
        Highscore = winlvl2.Highscore;




    }
}
