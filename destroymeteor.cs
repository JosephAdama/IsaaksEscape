using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymeteor : MonoBehaviour
{
    public ParticleSystem impact;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.tag == "Player")
        {
            collision.transform.GetComponent<die>().enabled = true;
        }

        Instantiate(impact, transform.position, Quaternion.Euler(0,0,180));
        Destroy(gameObject);
    }


}
