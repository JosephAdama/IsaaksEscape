using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class geodata 
{
    public float minutes;
    public float seconds;
    public float Highscore;
    public float Highscoremin;


    public geodata(Dieinspace die)
    {


        Highscore = die.seconds;
        Highscoremin = die.minutes;
             


        


    }


}
