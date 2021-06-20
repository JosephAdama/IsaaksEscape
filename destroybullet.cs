using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybullet : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem bulletparticle;
    public Transform player;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(bulletparticle, transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (collision.gameObject.tag == "Player")
        {
            collision.transform.GetComponent<Takedamage>().Takedamageplayer();
        }

    }
}
