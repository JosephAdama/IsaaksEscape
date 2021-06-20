using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spaceship : MonoBehaviour
{

    Rigidbody2D rb;
    public float force;
    public float upwardforce;
    public const float Jumpamount = 10f;
    public AudioSource jump;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if(Input.touchCount > 0)
        {
            Jump();
        }

        Vector2 v = rb.velocity;
        float angle = Mathf.Atan2(v.y, 10) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * Jumpamount;
        rb.velocity = Vector2.up * Jumpamount;
        jump.Play();
    }
}
