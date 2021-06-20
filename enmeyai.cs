using UnityEngine;

public class enmeyai : MonoBehaviour
{
    public GameObject String;
    public float TimebeetweenThrows;
    public Transform wapeonspot;
    public Transform player;
    bool readytoshoot;
    public float force;
    public float reach;
    public Transform enemyarmholder;
    public GameObject shootsound;

    private void Start()
    {
        readytoshoot = true;
    }
    private void Update()
    {
        if (readytoshoot && Vector2.Distance(transform.position, player.position) < reach)
        {
            Trow();


        }
        

    }


    void Trow()
    {

        GameObject curenntstring = Instantiate(String, wapeonspot.position,wapeonspot.rotation);
      
        curenntstring.GetComponent<Rigidbody2D>().AddForce (enemyarmholder.forward * force, ForceMode2D.Impulse);
        shootsound.GetComponent<AudioSource>().Play();

        readytoshoot = false;

        Invoke("Throwreset", 2);


    }





    void Throwreset()
    {
        readytoshoot = true;
        




    }

}
