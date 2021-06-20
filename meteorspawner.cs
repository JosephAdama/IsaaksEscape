using UnityEngine;

public class meteorspawner : MonoBehaviour
{
    public float lxvalue;
    public float rxvalue;
    public float timebeetweenspawns;
    public GameObject meteor;
    float countdown;
    
    public float countdowndis;
    public GameObject arrow;
    GameObject curmet;
    bool time;
    public Transform player;


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
            Vector2 spawnpos = new Vector2(Random.Range((player.position.x - 15), (player.position.x + 15)), 50);

            GameObject curmett = Instantiate(meteor, spawnpos, Quaternion.identity);
            curmet = curmett;


            countdown = timebeetweenspawns;
            time = true;





        }


        if (time && curmet != null)
        {
            arrow.SetActive(true);
            arrow.transform.LookAt(curmet.transform);
        }
        else
        {
            arrow.SetActive(false);
        }

        countdown -= Time.deltaTime;


    }







}
