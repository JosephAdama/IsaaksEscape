using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;


public class arm : MonoBehaviour
{

    Vector3 targetpoint;
    public Transform wapeonspot;
    Rigidbody2D rb;
    public LayerMask UI;
    Touch touch;
    float time;

   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        }

        targetpoint = Camera.main.ScreenToWorldPoint(touch.position);

        



        Vector2 direction = targetpoint - wapeonspot.position;
        Vector2 direction2 = new Vector2(direction.x, direction.y);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;


        Vector2 raycastPosition = targetpoint;
        RaycastHit2D hit = Physics2D.Raycast(raycastPosition, Vector2.zero);

       
        

        
        
       int id = touch.fingerId;
      if (!EventSystem.current.IsPointerOverGameObject(id) )
            {
                
                

                    transform.LookAt(new Vector3(targetpoint.x, targetpoint.y, 0));

                
            }
        



      
   
        

        
    }




}
