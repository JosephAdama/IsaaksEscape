using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerkiller : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<die>().enabled = true;
        }
    }
}
