using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkjump : MonoBehaviour
{
    public GameObject walk;
    public GameObject jump;
    public GameObject unötig4;
    public GameObject unötig3;
    public GameObject unötig2;
    public GameObject unötig1;
    public GameObject unötig5;
    




    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            walk.SetActive(true);
            jump.SetActive(false);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {


        if(collision.transform.tag == "Player")
        {
            walk.SetActive(false);
            jump.SetActive(true);
            unötig1.SetActive(false);
            unötig2.SetActive(false);
            unötig3.SetActive(false);
            unötig4.SetActive(false);

        }



    }
}
