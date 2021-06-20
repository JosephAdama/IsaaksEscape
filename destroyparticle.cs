using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyparticle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroyparticle", 1);
    }
    
    void Destroyparticle()
    {
        Destroy(gameObject);
    }
}
