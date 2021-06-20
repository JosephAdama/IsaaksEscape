using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class lvl1hillData 
{

    public float lastscoreig;
    public float Highscore;

    public lvl1hillData(winlvl1 winlvl1)
    {
        lastscoreig = winlvl1.mayHighscore;
        Highscore = winlvl1.Highscore;




    }
}
