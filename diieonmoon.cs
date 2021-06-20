using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diieonmoon : MonoBehaviour
{



    private void OnParticleCollision(GameObject other)
    {

        Debug.Log("collison");
        GetComponent<Takedamage>().Takedamageplayer();
        
    }
}
