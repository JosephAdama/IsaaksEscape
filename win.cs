using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class win : MonoBehaviour
{

    public ParticleSystem Chocolate;
    public GameObject WinUi;
    public GameObject enemy;
    public Canvas canvas;
    public GameObject panal;
  


    private void Start()
    {
       
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            WinUi.SetActive(true);
            Instantiate(Chocolate, transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(enemy);
            Destroy(gameObject);
            panal.SetActive(false);
            canvas.GetComponent<Pausemenu>().enabled = false;
        }
    }






}
