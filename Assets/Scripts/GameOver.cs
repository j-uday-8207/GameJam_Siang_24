using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AstroLife ast;
    [SerializeField] private AudioSource clicksoundEffect3;


    public void Restart()
    {
        clicksoundEffect3.Play();
        Debug.Log(PlayerPrefs.GetInt("Scene_State"));
        SceneManager.LoadScene(PlayerPrefs.GetInt("Scene_State"));
    }

    public void MainMenu()
    {
        clicksoundEffect3.Play();
        SceneManager.LoadScene(0);
    }


}
