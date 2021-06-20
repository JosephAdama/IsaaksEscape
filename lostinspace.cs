using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostinspace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Lost", 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Lost()
    {
        Time.timeScale = 0;
    }
}
