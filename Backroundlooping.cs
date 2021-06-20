using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backroundlooping : MonoBehaviour
{

    public float Backroundspeed;
    public Renderer backroundrenderer;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        backroundrenderer.material.mainTextureOffset += new Vector2(Backroundspeed * Time.deltaTime, 0);

    }

}


