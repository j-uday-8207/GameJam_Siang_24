using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(16);
    }
    public void InfoPage()
    {
        SceneManager.LoadScene(1);
    }
}
