using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidocamarascript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float TimebeetweenThrows;
    public Transform wapeonspot;

    bool readytoshoot;
    public float force;
    
    public GameObject shootsound;

    private void Start()
    {
        readytoshoot = true;
    }
    private void Update()
    {
        if (readytoshoot)
        {
            Trow();


        }


    }


    void Trow()
    {

        GameObject curenntstring = Instantiate(bullet, wapeonspot.position, Quaternion.identity);
        curenntstring.transform.rotation = Quaternion.Euler(0, 0, 33);
        curenntstring.GetComponent<Rigidbody2D>().AddForce(wapeonspot.forward * force, ForceMode2D.Impulse);
        shootsound.GetComponent<AudioSource>().Play();


        float resettime = TimebeetweenThrows;
        readytoshoot = false;

        Invoke("Throwreset", resettime);


    }





    void Throwreset()
    {
        readytoshoot = true;





    }

}
