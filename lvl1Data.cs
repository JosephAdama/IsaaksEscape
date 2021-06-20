using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class lvl1Data 
{

    public float lastscoreig;
    public float Highscore;

    public lvl1Data (winlvl0 win)
    {
        lastscoreig = win.mayHighscore;
        Highscore = win.Highscore;

      
       
        
    }


}
