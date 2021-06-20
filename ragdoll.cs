using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragdoll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject limbs;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "apple")
        {
            Debug.Log("died");
            Instantiate(limbs, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
