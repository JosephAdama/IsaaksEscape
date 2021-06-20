using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class winice : MonoBehaviour
{
    public ParticleSystem Chocolate;
    public GameObject WinUi1;
    public GameObject enemy;
    public Canvas canvas;
    public GameObject Diecounter;
    public GameObject Endtime;
    public GameObject timeender;
    public float mayHighscore;
    public float Highscore;
    public TextMeshProUGUI highscoretext;
    public int minutes;
    public int seconds;
    bool setdata;


    private void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/player.Playscore3"))
        {
            Icelvldata data = Saveicelvl.LoadData();

            Highscore = data.Highscore;

            if (data.Highscore == 0)
            {
                Highscore = data.lastscoreig;
            }



            Debug.Log(data.lastscoreig);

            setdata = true;
        }
        else
            setdata = false;

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {






            Endtime.GetComponent<TextMeshProUGUI>().enabled = false;

            if (Mathf.Round(Timer.seconds) >= 9)
                Diecounter.GetComponent<TextMeshProUGUI>().text = "your final time was : " + Timer.minutes + ":" + Mathf.Round(Timer.seconds);
            else if (Mathf.Round(Timer.seconds) <= 9)
                Diecounter.GetComponent<TextMeshProUGUI>().text = "your final time was : " + Timer.minutes + ":" + "0" + Mathf.Round(Timer.seconds);


            if (!File.Exists(Application.persistentDataPath + "/player.Playscore3"))
            {
                if (Mathf.Round(Timer.seconds) <= 9)
                {
                    highscoretext.text = "your new Highscore is : " + Mathf.Round(Timer.minutes) + ":0" + Mathf.Round(Timer.seconds);
                }
                else if (Mathf.Round(Timer.seconds) >= 9)
                    highscoretext.text = "your new Highscore is : " + Mathf.Round(Timer.minutes) + ":" + Mathf.Round(Timer.seconds);
            }

            WinUi1.SetActive(true);
            Instantiate(Chocolate, transform.position, Quaternion.identity);
            Destroy(enemy);
            mayHighscore = Timer.hightime;
            Debug.Log(Timer.hightime);


            canvas.GetComponent<Pausemenu>().enabled = false;
            if (Highscore > mayHighscore)
            {
                float Highscorenow;
                Highscorenow = Highscore;
                Highscore = mayHighscore;




                highscoretext.text = "you broke your Highscore by" + (Highscorenow - mayHighscore) + "sec";
            }
            else if (Mathf.Round(Highscore) == Mathf.Round(mayHighscore))
            {
                highscoretext.text = "you almost made a new Highscore";
            }
            else if (Highscore < mayHighscore)
            {
                float minutsnow;
                float secondsnow;
                minutsnow = Mathf.Floor(Highscore / 60);
                secondsnow = Highscore;
                if (secondsnow <= 9 && setdata)
                {
                    highscoretext.text = "you missed you Highscore which is : " + minutsnow + ":0" + secondsnow;
                }
                else if (secondsnow >= 9)
                    highscoretext.text = "you missed you Highscore which is : " + minutsnow + ":" + secondsnow;




            }
            else if (Highscore == 0)
            {
                Highscore = mayHighscore;
            }


            Saveicelvl.SavePlayer(this);





        }
    }

}
