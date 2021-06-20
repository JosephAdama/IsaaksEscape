using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class followplayer : MonoBehaviour
{

    public GameObject player;
    public float xoffset;


    // Update is called once per frame
    void Update()
    {
        Vector3 campos = new Vector3(player.transform.position.x - xoffset, 0, -10);
        transform.position = campos;




    }
}
