using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform weaponspot;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {

            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            
            collision.transform.GetComponent<applethrower>().enabled = false;
            collision.transform.GetComponent<Rigidbody2D>().gravityScale = 0;
            GetComponent<BoxCollider2D>().enabled = false;
            transform.localRotation = Quaternion.Euler(0, 180,152);
            transform.localPosition = new Vector3(0.8f, -1.6f);

            transform.parent = collision.transform;


        }




    }
}
