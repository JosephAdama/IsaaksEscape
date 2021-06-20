using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class DieMenu : MonoBehaviour
{









    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
