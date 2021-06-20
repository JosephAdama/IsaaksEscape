using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public ParticleSystem Wall;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Wall, transform.position, Quaternion.identity);
    }


}
