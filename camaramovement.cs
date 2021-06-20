using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaramovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static float cameraspeed;
   


    private void Start()
    {
        cameraspeed = 10;
    }

    private void Update()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(cameraspeed * Time.deltaTime, 0);
        cameraspeed += 0.1f * Time.deltaTime;
    }
}
