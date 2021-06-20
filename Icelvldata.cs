using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Icelvldata
{
    public float lastscoreig;
    public float Highscore;

    public Icelvldata(winice winice)
    {
        lastscoreig = winice.mayHighscore;
        Highscore = winice.Highscore;




    }
}
