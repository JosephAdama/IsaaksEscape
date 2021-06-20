using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stonespawner : MonoBehaviour
{
    public GameObject stone;


    private void Start()
    {
        stone.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "apple")
        {
            stone.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic; ;

        }
    }

}
