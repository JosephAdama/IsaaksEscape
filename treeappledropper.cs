using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeappledropper : MonoBehaviour
{

    public GameObject apple;
    public Transform appledropper;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "apple")
        {
            Instantiate(apple, appledropper.position, transform.rotation);
        } 
    }

}
