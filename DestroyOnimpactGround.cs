using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnimpactGround : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
}
