using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class bananashow : MonoBehaviour
{

    public GameObject banana;
    // Update is called once per frame
    void Update()
    {

        if (File.Exists(Application.persistentDataPath + "/bananaboat.save"))
        {
            bananaboatbool data = savesunglass.LoadDataban();

            if (data.unlocked)
            {
                banana.SetActive(true);
                GetComponent<SpriteRenderer>().enabled = false;
            }
            else
                banana.SetActive(false);
        }
        else
        {
            banana.SetActive(false);
        }



    }
}
