using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyarm : MonoBehaviour
{
    Transform targetpoint;

    Rigidbody2D rb;
    public Transform playerbody;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        targetpoint = playerbody;



       

        transform.LookAt(new Vector3(targetpoint.position.x, targetpoint.position.y, 0));
    }
}
