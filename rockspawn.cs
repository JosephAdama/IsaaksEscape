using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockspawn : MonoBehaviour
{

    public float timebeetweenspawns;
    public GameObject meteor;
    float countdown;

    public float countdowndis;
    public Transform spawn;
    
    bool time;
    


    private void Start()
    {
        countdown = timebeetweenspawns;
        time = false;
    }

    private void Update()
    {
        countdowndis = Mathf.Round(countdown);

        if (Mathf.Round(countdown) == 0)
        {
            

            Instantiate(meteor, spawn.position, Quaternion.identity);
           


            countdown = timebeetweenspawns;
            time = true;





        }




        countdown -= Time.deltaTime;


    }






}
