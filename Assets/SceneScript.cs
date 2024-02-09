using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
   
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Skip()
    {
        SceneManager.LoadScene(9);
    }

    public void Skip2()
    {
        SceneManager.LoadScene(15);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void land()
    {
        SceneManager.LoadScene(12);
    }
}
