using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pistolscript : MonoBehaviour
{
    public Transform wapeonspot;
    public GameObject apple;
    public GameObject pickupapple;
    public GameObject applethrow;
    public TextMeshProUGUI appleinventory;
    public Transform playerarmholder;
    RaycastHit2D hit;

    Vector3 targetpoint;

    Rigidbody2D rb;

    public float Force;
   
    string inv;



    public int inventory;




    private void Update()
    {




        wapeonspot.Rotate(Input.mousePosition);
        


        PickUp();
        Throw();

    }


    void PickUp()
    {

        inventory += 5;

    }


    void Throw()
    {



        float xInput = Input.GetAxis("Horizontal");

        targetpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);



        Vector2 direction = targetpoint - wapeonspot.position;
        Vector2 direction2 = new Vector2(direction.x, direction.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;



        if (inventory > 0 && Input.GetMouseButtonDown(1))
        {


            GameObject currentapple = Instantiate(apple, wapeonspot.position, Quaternion.identity);
            applethrow.GetComponent<AudioSource>().Play();




            inventory--;
            currentapple.GetComponent<Rigidbody2D>().AddForce(playerarmholder.forward * Force, ForceMode2D.Impulse);




        }


    }





}
