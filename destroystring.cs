using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroystring : MonoBehaviour
{
    public ParticleSystem stringparticle;
    public Transform player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(stringparticle, transform.position, Quaternion.identity);
        Destroy(gameObject);

        if(collision.gameObject.tag == "Player")
        {
            collision.transform.GetComponent<Takedamage>().Takedamageplayer();
        }

    }

}
