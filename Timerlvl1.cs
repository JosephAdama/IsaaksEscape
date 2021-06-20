using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timerlvl1 : MonoBehaviour
{
    public float startTime;
    public float minutes;
    public float seconds;
    public static string endtime;
    public static float hightime;
    float value = 0f;
    void Start()
    {
        startTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Mathf.Round(startTime) >= 59)
        {
            startTime = 0f;
            minutes++;
        }

        startTime += Time.deltaTime;
        value += Time.deltaTime;
        hightime = Mathf.Round(value);
        


        seconds = startTime;


        if (Mathf.Round(startTime) <= 9)
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
