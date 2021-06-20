using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
   
    public float startTime;
    public static float minutes;
    public static float seconds;
    public static string endtime;
    public static float hightime;
    public float value;
    void Start()
    {
        startTime = 0;
        minutes = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(startTime >= 59)
        {
            startTime = 0f;
            minutes++;
        }

        value += Time.deltaTime;
        hightime = Mathf.Round(value);


        startTime += Time.deltaTime;
        seconds = startTime;
        

        if(Mathf.Round(seconds) <= 9)
        {
           
            GetComponent<TextMeshProUGUI>().text = minutes.ToString() + ":0" + Mathf.Round(seconds).ToString();
            endtime = minutes.ToString() + ":0" + Mathf.Round(seconds).ToString();
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = minutes.ToString() + ":" + Mathf.Round(seconds).ToString();
            endtime = minutes.ToString() + ":" + Mathf.Round(seconds).ToString();
        }
        
    }
}
