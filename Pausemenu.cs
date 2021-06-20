using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject Pausebutten;
    public GameObject Player;


    public GameObject PauseMenu;

    // Update is called once per frame


    private void Start()
    {
        
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
      
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
                
            }



        }

    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Pausebutten.SetActive(true);
        Player.GetComponent<playermovement>().enabled = true;
        Player.GetComponent<applethrower>().enabled = true;

    }

    public void Pause()
    {

        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Pausebutten.SetActive(false);
        Player.GetComponent<playermovement>().enabled = false;
        Player.GetComponent<applethrower>().enabled = false;


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

}
