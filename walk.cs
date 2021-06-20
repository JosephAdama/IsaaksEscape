using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{

    public AudioSource walksound;
    bool readytoreset;
    public float timebeetweensound;



    private void Update()
    {


        if (readytoreset)
        {
            walksound.Play();
            readytoreset = false;
            Invoke("Soundreset", timebeetweensound);
        }


    }



    public void Soundreset()
    {
        readytoreset = true;
    }



}
