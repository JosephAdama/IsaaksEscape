using UnityEngine;
using TMPro;
using System.IO;

public class coincounter : MonoBehaviour
{




    public float coincount;
    public GameObject diepanal;
    bool count;
    public GameObject coindis;
    public TextMeshProUGUI coinhighscore;
    public static float currentcoin;
    public static bool coinsub;
    public static bool sunglasses;
    public static bool bananaboat;
    public static bool thosand;
    



    private void Start()
    {
        count = true;
        currentcoin = 0;
        sunglasses = false;
        bananaboat = false;
        thosand = false;
    }

    private void Update()
    {
        coindis.transform.GetComponent<TextMeshProUGUI>().text = coincount.ToString();
    }



    public void Countcoins()
    {


        if(File.Exists(Application.persistentDataPath + "/coin.coindata"))
        {
            coindata data = savecoindata.LoadData();

            coindis.SetActive(false);





            if (coinsub)
            {
                coincount = data.coincounterglobal -= 80f;
                savecoindata.SavePlayer(this);
                coinsub = false;
            
            }

            if (sunglasses)
            {
                coincount = data.coincounterglobal -= 120f;
                savecoindata.SavePlayer(this);
                sunglasses = false;
            }

            if (bananaboat)
            {
                coincount = data.coincounterglobal -= 200;
                savecoindata.SavePlayer(this);
                bananaboat = false;

            }

            if (thosand)
            {
                coincount = data.coincounterglobal += 100;
                savecoindata.SavePlayer(this);
                thosand = false;
            }


            if(data.coincounterglobal <= 0)
            {
                coincount = 0;
                savecoindata.SavePlayer(this);
            }

         
            coindata dataa = savecoindata.LoadData();
            coinhighscore.text = dataa.coincounterglobal.ToString();
            Debug.Log(dataa.coincounterglobal);
        }
        else
        {
            savecoindata.SavePlayer(this);
        }


        







        count = false;



    }

}
