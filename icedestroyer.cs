using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icedestroyer : MonoBehaviour
{
    public float probability;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ice") {
            {
                int range = 5;
                 probability = Mathf.Round(Random.Range(0, range));

                if(probability  == 5)
                {
                    Destroy(collision.transform);
                }



            } 
        }
    }
}
