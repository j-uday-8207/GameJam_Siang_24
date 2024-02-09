using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AstroLife ast;


    public void Restart()
    {
        Debug.Log(PlayerPrefs.GetInt("Scene_State"));
        SceneManager.LoadScene(PlayerPrefs.GetInt("Scene_State"));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
