using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinadder : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.transform.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            other.transform.GetComponent<coincounter>().coincount++;
            
            Destroy(gameObject);
        }


    }


}
