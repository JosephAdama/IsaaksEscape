using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Dieinspace : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem impact;
    public GameObject bg;
    public GameObject Diepanel;
    public GameObject timer;
    public float seconds;
    public float minutes;
    public GameObject backroundmusic;
    public GameObject timerdis;
    public AudioSource Die;
    public GameObject Highscore;
    
    
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die.Play();


        timer.SetActive(false);
        Diepanel.SetActive(true);
        seconds = Mathf.Round(Timer.seconds);
        minutes = Mathf.Round(Timer.minutes);
        Instantiate(impact, transform.position, Quaternion.identity);
        camaramovement.cameraspeed = 1f;
        bg.transform.GetComponent<Backroundlooping>().Backroundspeed = 0.1f;
        backroundmusic.GetComponent<AudioSource>().pitch = 0.3f;




        if(File.Exists(Application.persistentDataPath + "/player.Playscore4"))
        {

            geodata data = Savegeodata.LoadData();

            if (seconds <= 9)
            {
                timerdis.GetComponent<TextMeshProUGUI>().text = "Your time was " + minutes + ":0" + seconds;
            }
            else
            {
                timerdis.GetComponent<TextMeshProUGUI>().text = "Your time was " + minutes + ":" + seconds;
            }






            if (data.Highscoremin == minutes)
            {

                if (data.Highscore > seconds)
                {


                    if (data.Highscore <= 9)
                    {
                        Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + data.Highscoremin + ":0" + data.Highscore;
                    }
                    else
                    {
                        Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + data.Highscoremin + ":" + data.Highscore;
                    }



                }
                else if (data.Highscore == seconds)
                {
                    Highscore.GetComponent<TextMeshProUGUI>().text = "You almost broke your Highscore ";

                }
                else if (data.Highscore < seconds)
                {
                    if (seconds <= 9)
                    {
                        Highscore.GetComponent<TextMeshProUGUI>().text = "Your new Highscore is " + minutes + ":0" + seconds;
                        Savegeodata.SavePlayer(this);
                    }
                    else
                    {
                        Highscore.GetComponent<TextMeshProUGUI>().text = "Your new Highscore is " + minutes + ":" + seconds;
                        Savegeodata.SavePlayer(this);
                    }



                }



            }
            else if (data.Highscoremin < minutes)
            {
                if (seconds <= 9)
                {
                    Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + minutes + "0:" + seconds;
                    Savegeodata.SavePlayer(this);
                }
                else
                {
                    Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + minutes + ":" + seconds;
                    Savegeodata.SavePlayer(this);
                }
            }
            else if (data.Highscoremin > minutes)
            {
                if (data.Highscore <= 9)
                {
                    Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + data.Highscoremin + "0:" + data.Highscore;
                }
                else
                {
                    Highscore.GetComponent<TextMeshProUGUI>().text = "Your Highscore is " + data.Highscoremin + ":" + data.Highscore;
                }
            }





            GetComponent<coincounter>().Countcoins();



            
        }
        else
        {
            if (seconds <= 9)
            {
                timerdis.GetComponent<TextMeshProUGUI>().text = "Your time was " + minutes + ":0" + seconds;
            }
            else
            {
                timerdis.GetComponent<TextMeshProUGUI>().text = "Your time was " + minutes + ":" + seconds;
            }
            if (seconds <= 9)
            {
                Highscore.GetComponent<TextMeshProUGUI>().text = "Your new Highscore is " + minutes + ":0" + seconds;
                
            }
            else
            {
                Highscore.GetComponent<TextMeshProUGUI>().text = "Your new Highscore is " + minutes + ":" + seconds;
               
            }




            Savegeodata.SavePlayer(this);
        }

        Destroy(gameObject);


    }


}
