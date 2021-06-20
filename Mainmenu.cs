using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.IO;
using TMPro;
public class Mainmenu : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject Levelselector;
    public GameObject Optionsmenu;
    public AudioMixer audiomixer;
    public AudioMixer audiosfx;
    public GameObject selectsound;
    public GameObject sfxslider;
    public GameObject musicslider;
    public GameObject secondPage;
    public GameObject unlocklevel;
    public TextMeshProUGUI coindisplay;
    public bool unlock;
    float currentcoins;
    public GameObject Shop;
    public GameObject sunglasses;
    public GameObject bananaboat;
    public bool sunglassunlocked;
    public bool sunglassselcted;
    public bool bananaunlocked;
    public bool bananasselcted;






    private float GetMasterMusic()
    {
        float value;
        bool result = audiomixer.GetFloat("Music", out value);
        if (result)
        {
            return value;
        }
        else
        {
            return 0f;
        }
    }
    public float GetMasterSFX()
    {
        float value;
        bool result = audiosfx.GetFloat("SFX", out value);
        if (result)
        {
            return value;
        }
        else
        {
            return 0f;
        }
    }

    private void Start()
    {
        musicslider.GetComponent<Slider>().value = GetMasterMusic();
        sfxslider.GetComponent<Slider>().value = GetMasterSFX();
        sunglassunlocked = false;
        



    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapeBacktoMenu();
        }



        if (File.Exists(Application.persistentDataPath + "/coin.coindata"))
        {
            coindata coindata = savecoindata.LoadData();



            coindisplay.text = coindata.coincounterglobal.ToString();
        }
        else
        {
            coindisplay.text = "0";
        }





    }

    public void Tutorial()
    {

        SceneManager.LoadScene(8);
    }
    public void PlayGame()
    {
        MainMenu.SetActive(false);
        Levelselector.SetActive(true);
        selectsound.GetComponent<AudioSource>().Play();

    }

    public void BacktoMenu()
    {

        MainMenu.SetActive(true);
        Levelselector.SetActive(false);
        Optionsmenu.SetActive(false);
        Levelselector.SetActive(false);
        secondPage.SetActive(false);
        selectsound.GetComponent<AudioSource>().Play();
        unlocklevel.SetActive(false);
        Shop.SetActive(false);
        sunglasses.SetActive(false);
        bananaboat.SetActive(false);
    }

    public void EscapeBacktoMenu()
    {
        MainMenu.SetActive(true);
        Levelselector.SetActive(false);
        Optionsmenu.SetActive(false);
        Levelselector.SetActive(false);
        secondPage.SetActive(false);
        unlocklevel.SetActive(false);
        Shop.SetActive(false);
        sunglasses.SetActive(false);
        bananaboat.SetActive(false);
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
        selectsound.GetComponent<AudioSource>().Play();
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
        selectsound.GetComponent<AudioSource>().Play();
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
        selectsound.GetComponent<AudioSource>().Play();
    }
    public void Level4()
    {
        SceneManager.LoadScene(4);
        selectsound.GetComponent<AudioSource>().Play();
    }
    public void Quitgame()
    {
        Application.Quit();
        selectsound.GetComponent<AudioSource>().Play();
    }

    public void OptionsMenu()
    {
        MainMenu.SetActive(false);
        Optionsmenu.SetActive(true);
        selectsound.GetComponent<AudioSource>().Play();
    }

    public void SetMusicVolume(float volume)
    {
        audiomixer.SetFloat("Music", volume);

    }

    public void SetSFXVolume(float volume)
    {
        audiosfx.SetFloat("SFX", volume);
    }


    public void NextPage()
    {
        Levelselector.SetActive(false);
        secondPage.SetActive(true);
        selectsound.GetComponent<AudioSource>().Play();



    }

    public void PreviousPage()
    {
        Levelselector.SetActive(true);
        secondPage.SetActive(false);
        selectsound.GetComponent<AudioSource>().Play();
    }

    public void LEvel5()
    {
        selectsound.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(5);




    }


    public void Level6()
    {
        selectsound.GetComponent<AudioSource>().Play();
        if (File.Exists(Application.persistentDataPath + "/coin.unlocked"))
        {
            booldata data = savebool.LoadData();

            if (data.unlocked)
            {
                SceneManager.LoadScene(6);
            }
            else
            {
                secondPage.SetActive(false);
                unlocklevel.SetActive(true);
            }
        }
        else
        {

            savebool.SavePlayer(this);
            secondPage.SetActive(false);
            unlocklevel.SetActive(true);


        }













    }

    public void Unlocklevel()
    {


        if (File.Exists(Application.persistentDataPath + "/coin.unlocked"))
        {
            selectsound.GetComponent<AudioSource>().Play();
            coindata data = savecoindata.LoadData();
            Debug.Log(data.coincounterglobal);



            if (data.coincounterglobal - 80 >= 0)
            {
                unlock = true;
                savebool.SavePlayer(this);
                coincounter.coinsub = true;
                GetComponent<coincounter>().Countcoins();
                secondPage.SetActive(true);
                unlocklevel.SetActive(false);

            }
            {
                secondPage.SetActive(true);
                unlocklevel.SetActive(false);

            }
        }
        else
        {
            secondPage.SetActive(true);
            unlocklevel.SetActive(false);
            selectsound.GetComponent<AudioSource>().Play();
        }




    }



    public void ShopMenü()
    {

        MainMenu.SetActive(false);
        Shop.SetActive(true);
        selectsound.GetComponent<AudioSource>().Play();



    }


    public void Unlocksunglasses()
    {

        selectsound.GetComponent<AudioSource>().Play();
        if (File.Exists(Application.persistentDataPath + "/sunglass.save"))
        {
            sunglassdata data = savesunglass.LoadData();

            if (!data.unlocked)
            {
                sunglasses.SetActive(true);
                Shop.SetActive(false);
            }

        }
        else
        {

            savesunglass.SavePlayer(this);
            Shop.SetActive(false);
            sunglasses.SetActive(true);


        }


    }

    public void Unlockglasseslock()
    {


        selectsound.GetComponent<AudioSource>().Play();
        coindata data = savecoindata.LoadData();
        sunglassdata sundata = savesunglass.LoadData();
        Debug.Log(data.coincounterglobal);



        if (data.coincounterglobal - 120 >= 0 && !sundata.unlocked)
        {





            sunglassunlocked = true;
            sunglassselcted = true;
            savesunglass.SavePlayer(this);
            coincounter.sunglasses = true;
            GetComponent<coincounter>().Countcoins();
            Shop.SetActive(true);
            sunglasses.SetActive(false);


        }
        {
            Shop.SetActive(true);
            sunglasses.SetActive(false);

        }

        sunglassdata sdata = savesunglass.LoadData();

        Debug.Log(sdata.selected.ToString() + sdata.unlocked);






    }
    public void Unlockbanana()
    {

        selectsound.GetComponent<AudioSource>().Play();
        if (File.Exists(Application.persistentDataPath + "/bananaboat.save"))
        {
            bananaboatbool data = savesunglass.LoadDataban();

            if (!data.unlocked)
            {
                bananaboat.SetActive(true);
                Shop.SetActive(false);
            }

        }
        else
        {

            savesunglass.SavePlayerban(this);
            Shop.SetActive(false);
            bananaboat.SetActive(true);


        }


    }

    public void Unlockbananalock()
    {


        selectsound.GetComponent<AudioSource>().Play();
        coindata data = savecoindata.LoadData();
        bananaboatbool sundata = savesunglass.LoadDataban();
        Debug.Log(data.coincounterglobal);



        if (data.coincounterglobal - 200 >= 0 && !sundata.unlocked)
        {





            bananasselcted = true;
            bananaunlocked = true;
            savesunglass.SavePlayerban(this);
            coincounter.bananaboat = true;
            GetComponent<coincounter>().Countcoins();
            Shop.SetActive(true);
            bananaboat.SetActive(false);


        }
        {
            Shop.SetActive(true);
            bananaboat.SetActive(false);

        }

        bananaboatbool sdata = savesunglass.LoadDataban();

        Debug.Log(sdata.selected.ToString() + sdata.unlocked);
    }



    public void Thousandcoins()
    {
        
        coincounter.thosand = true;
        GetComponent<coincounter>().Countcoins();
        coincounter.thosand = false;



    }

    public void Fullscreen(bool isfullscreen)
    {

        Screen.fullScreen = isfullscreen;
    }
}




   
