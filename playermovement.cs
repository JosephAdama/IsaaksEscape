using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb2d;
    public float speed;
    public LayerMask ground;
    public bool Isgrounded;
    public Transform groundcheck;
    public float jumpForce;
    public GameObject jumpsound;
    public ParticleSystem jumpparticle;
    public AudioSource walk;
    public float timebeetweensound;
    float countdown;
    public float GroundremeberTime;
    public float groundedcountownd = 0;
    public float xInput;
    public  bool plusimput;
    public  bool minusimput;
    public bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        countdown = timebeetweensound;
        
       
    }


    public void Jump()
    {
        
        if(groundedcountownd > 0)
        {

            rb2d.AddForce(new Vector2(0, jumpForce));
            ParticleSystem currentparticle = Instantiate(jumpparticle, groundcheck.position, Quaternion.identity);
            jumpsound.GetComponent<AudioSource>().Play();
            groundedcountownd = 0;

        }
        
    }

    private void Update()
    {
        Isgrounded = Physics2D.OverlapCircle(groundcheck.position, 0.5f, ground);
        animator.SetBool("isgrounded", Isgrounded);


        


        groundedcountownd -= Time.deltaTime;
        if (Isgrounded)
        {
            groundedcountownd = GroundremeberTime;
            


        }


        if(transform.position.y <= -10)
        {
            GetComponent<die>().enabled = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        
      

        if(rb2d != null)
        {
            MyInput();
        }
        else
        {
            Debug.Log("no rigidbody attachet to Gameobject" + gameObject.name);
        }



    }

   



    public void PlusInputpointerdown()
    {


        plusimput = true;
    }

    public void PlusInputpointerup()
    {


        plusimput = false;
    }

    public void MinusImputpointerdown()
    {
        minusimput = true;
    }
    public void MinusImputpointerup()
    {
        minusimput = false;
    }




    public void MyInput()
    {
       




        if (plusimput && minusimput)
        {
            xInput = 0;
        }
        else if (plusimput && !minusimput)
        {
            xInput = 1;
        }
        else if(!plusimput && minusimput)
        {
            xInput = -1;
        }
        else if(!plusimput && !minusimput)
        {
            xInput = 0;
        }

        

        rb2d.AddForce(new Vector2(xInput, 0) * speed);

       
       if(xInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
           
            if (Mathf.Round(countdown) <= 0 && Isgrounded)
            {
                walk.Play();
                countdown = timebeetweensound;
            }

        }
        else if(xInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            if(Mathf.Round(countdown) <= 0 && Isgrounded)
            {
                walk.Play();
                countdown = timebeetweensound;
            }
            
        }


        countdown -= Time.deltaTime;


        animator.SetFloat("speed", Mathf.Abs(xInput));




    }

    
}
