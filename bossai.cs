using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossai : MonoBehaviour
{
    public GameObject String;
    public float TimebeetweenThrows;
    public Transform wapeonspot;
    public Transform player;
    bool readytoshoot;
    public float force;
    public float reach;
    public Transform enemyarmholder;
    public GameObject shootsound;
    public float health;
    public float shoottime;
    bool readytolocalshoot;
    public GameObject wall1;

    private void Start()
    {
        readytoshoot = true;
        readytolocalshoot = true;
    }
    private void Update()
    {
        if (readytoshoot && Vector2.Distance(transform.position, player.position) < reach && readytolocalshoot)
        {
            Trow();


        }


        if(health <= 0)
        {
            Destroy(gameObject);
            wall1.GetComponent<SpriteRenderer>().enabled = false;
            wall1.GetComponent<BoxCollider2D>().enabled = false;

        }


    }


    void Trow()
    {

        GameObject curenntstring = Instantiate(String, wapeonspot.position, wapeonspot.rotation);
   
        curenntstring.GetComponent<Rigidbody2D>().AddForce(enemyarmholder.forward * force, ForceMode2D.Impulse);
        
        shootsound.GetComponent<AudioSource>().Play();

        if (readytoshoot)
        {
            readytolocalshoot = false;
            Invoke("localThrowreset", .5f);

        }

        

        Invoke("Throwreset", 5);


    }



    void localThrowreset()
    {
        readytolocalshoot = true;
    }

    void Throwreset()
    {

        Invoke("Readyagain", 5);
        readytoshoot = false;





    }

    void Readyagain()
    {
        readytoshoot = true;
    }


    public void Takedamage(float damage)
    {
        health -= damage;
    }
}
