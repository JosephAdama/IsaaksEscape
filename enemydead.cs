using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead : MonoBehaviour
{
    public ParticleSystem impact;
    public GameObject pistol;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "enemy")
        {
            Instantiate(pistol, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Instantiate(impact, transform.position, transform.rotation);
            Destroy(gameObject);
        }




    }


}
