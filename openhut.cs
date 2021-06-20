using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openhut : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }

    }
}
