using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    [SerializeField] private AudioSource clicksoundEffect1;
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Skip()
    {
        SceneManager.LoadScene(8);
    }

    public void Skip2()
    {
        SceneManager.LoadScene(15);
    }

    public void Quitgame()
    {
        clicksoundEffect1.Play();
        Application.Quit();
    }

    public void land()
    {
        SceneManager.LoadScene(12);
    }
}
