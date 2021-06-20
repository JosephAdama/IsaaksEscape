using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenapple : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            applethrower.candestroypolice = true;
            Destroy(gameObject);



        }



    }


}
