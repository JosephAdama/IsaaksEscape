using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appledropper : MonoBehaviour
{
    public GameObject apple;
    public ParticleSystem cratepar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
        {
            Instantiate(apple, transform.position, transform.rotation);
            Instantiate(cratepar, transform.position, transform.rotation);

            Destroy(gameObject);
        }

        if(collision.transform.tag == "apple" && applethrower.candestroypolice)
        {
            Instantiate(apple, transform.position, transform.rotation);
            Instantiate(cratepar, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

}
