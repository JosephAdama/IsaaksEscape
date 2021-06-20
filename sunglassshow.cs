using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class sunglassshow : MonoBehaviour
{

    public GameObject sunglasses;
    private void Update()
    {


        if(File.Exists(Application.persistentDataPath + "/sunglass.save"))
        {
            sunglassdata data = savesunglass.LoadData();

            if (data.unlocked)
            {
                sunglasses.SetActive(true);
            }
            else
                sunglasses.SetActive(false);
        }
        else
        {
            sunglasses.SetActive(false);
        }

       


    }
}
