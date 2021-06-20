using UnityEngine;

public class destroyapple : MonoBehaviour
{
    public GameObject limbs;
    public ParticleSystem applejuice;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        ParticleSystem currentjuice = Instantiate(applejuice, transform.position, Quaternion.identity);


        if (collision.collider.tag == "doktor")
        {
            Instantiate(limbs, collision.transform.position, transform.rotation);
            Destroy(collision.gameObject);
            
            Destroy(gameObject);
        }
        if (collision.collider.tag == "enemy" && applethrower.candestroypolice) 
        {

            
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }


        if(collision.transform.tag == "boss")
        {
            collision.transform.GetComponent<bossai>().Takedamage(3);



        }


        if(collision.collider.tag == "ground")
        {
            Destroy(gameObject);
        }



    }


}
