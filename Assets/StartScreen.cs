using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private AudioSource clicksoundEffect;
    public void StartGame()
    {
        clicksoundEffect.Play();
        SceneManager.LoadScene(16);
    }
    public void InfoPage()
    {
        clicksoundEffect.Play();
        SceneManager.LoadScene(1);
    }
}
