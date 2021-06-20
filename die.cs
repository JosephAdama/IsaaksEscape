using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class die : MonoBehaviour
{
    public GameObject Arm;
    public GameObject DieUi;
    public GameObject Canvas;
    public GameObject Pause;
    public GameObject[] limbs;
    public GameObject enemy;
    public GameObject Die;
    public GameObject Backroundmusic;
    public GameObject panal;


    private void Start()
    {





        if(panal != null)
        {
            panal.SetActive(false);
        }

        Destroy(enemy);

        transform.DetachChildren();
        Time.timeScale = 0.3F;
        Die.GetComponent<AudioSource>().Play();
        Backroundmusic.GetComponent<AudioSource>().pitch = 0.4f;
        Arm.GetComponent<arm>().enabled = false;

        foreach(GameObject deadlimbs in limbs)
        {
            deadlimbs.transform.DetachChildren();
            deadlimbs.AddComponent<Rigidbody2D>();
            deadlimbs.AddComponent<BoxCollider2D>();
        }

       
        Destroy(gameObject);
        Canvas.GetComponent<Pausemenu>().enabled = false; 
        DieUi.SetActive(true);
        Pause.SetActive(false);






    }




}
