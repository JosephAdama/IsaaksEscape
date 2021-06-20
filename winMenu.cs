using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winMenu : MonoBehaviour
{

    private void Update()
    {
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
