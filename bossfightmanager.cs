using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossfightmanager : MonoBehaviour
{

    public GameObject healthbar;
    public GameObject wall;
    public Cinemachine.CinemachineVirtualCamera cm;
   

    private void Start()
    {
        cm.m_Lens.OrthographicSize = 10
            ;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.transform.tag == "Player")
        {
            wall.GetComponent<BoxCollider2D>().enabled = true;
            wall.GetComponent<SpriteRenderer>().enabled = true;
            cm.m_Lens.OrthographicSize = 20;
            
            if (healthbar != null)
            {
                healthbar.SetActive(true);
            }
        }

      
        


    }
}
