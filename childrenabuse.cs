using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childrenabuse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "apple")
        {
           
            Destroy(gameObject);
        }
    }
}
