using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takedamage : MonoBehaviour
{
    public int health;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Hurtsound;



    private void Start()
    {
        health = 3;
    }



    private void Update()
    {
         if(health < 3)
        {
            Heart3.SetActive(false);
        }

        if (health < 2)
        {
            Heart2.SetActive(false);
        }

        if (health < 1)
        {
            Heart1.SetActive(false);
        }


        if(health == 0)
        {

            GetComponent<die>().enabled = true;
        }

    }



    public void Takedamageplayer()
    {

        
        health--;

        if(health > 0)
        {
            Hurtsound.GetComponent<AudioSource>().Play();
        }

    }


}
