using UnityEngine;

public class volcano : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem sys;
    public Transform wapeon;
    bool timeset;
    public float time;
    ParticleSystem currentparticle;

    void Start()
    {

        time = Random.Range(0, 5);
        timeset = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (!timeset)
        {
            time = Random.Range(0, 5);
            timeset = true;
           
        }
        else
        {
            float currenttime = time;
            time -= Time.deltaTime;
            if (Mathf.Round(time) <= 0)
            {
                currentparticle = Instantiate(sys, wapeon.position, Quaternion.Euler(-90, 90, 0));

                currenttime -= Time.deltaTime;

                if(Mathf.Round(currenttime) <= 0)
                {
                    if (currentparticle != null)
                    {
                        Destroy(currentparticle);
                        timeset = false;
                    }

                    
                }



             



            }


        }






    }



    
}
