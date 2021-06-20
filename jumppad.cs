using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppad : MonoBehaviour
{
    public float jumppadforce;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.transform.GetComponent<Rigidbody2D>() != null)
            collision.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jumppadforce),ForceMode2D.Impulse);  
        
    }
}
