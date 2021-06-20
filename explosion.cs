using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public ParticleSystem explosionparticle;
    public float force;
    public float radius;
    public GameObject limbs;
    public float playerforce;
    public ParticleSystem stonepar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple" || collision.gameObject.tag == "bullet"  )
        {
            Instantiate(explosionparticle, transform.position, Quaternion.Euler(0,0,180)) ;
            Destroy(gameObject);

            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (Collider2D newarbyObject in colliders)
            {


                if (newarbyObject.tag == "doktor")
                {
                    

                    Instantiate(limbs, newarbyObject.transform.position, transform.rotation);
                    Destroy(newarbyObject);


                    Destroy(gameObject);
                }


                if(newarbyObject.tag == "Player")
                {

                    Rigidbody2D rbop = newarbyObject.GetComponent<Rigidbody2D>();
                    Vector2 directionplayer = newarbyObject.transform.position - transform.position;
                    rbop.AddForce(directionplayer * -playerforce);
                }

                if(newarbyObject.transform.tag == "stone")
                {
                    Instantiate(stonepar, newarbyObject.transform.position, transform.rotation);
                    Destroy(newarbyObject.gameObject);
                }

                Rigidbody2D rb = newarbyObject.GetComponent<Rigidbody2D>();
                if(rb != null)
                {
                    Vector2 direction = newarbyObject.transform.position - transform.position;
                    rb.AddForce(direction * force);
                }
            }

        }
    }
}
