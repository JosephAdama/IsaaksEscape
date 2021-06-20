using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawner : MonoBehaviour
{
    public GameObject coins;
    public float timebetweenspawns;
    private float spawntime;

    public float y;
    // Update is called once per frame



    private void Start()
    {
        spawntime = timebetweenspawns;
    }
    void Update()
    {

        if (0 >= Mathf.Round(spawntime))
        {
            Spawn();
            spawntime = timebetweenspawns;
        }


        spawntime -= Time.deltaTime;






    }

    void Spawn()
    {
        Vector2 spawnpos = new Vector2((transform.position.x + 40), Random.Range(-y, y));
        Instantiate(coins, spawnpos, Quaternion.identity);
    }
}
