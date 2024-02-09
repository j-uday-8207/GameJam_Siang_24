using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_Button : MonoBehaviour
{
    [SerializeField] private AudioSource clicksoundEffect2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void level1()
    {
        clicksoundEffect2.Play();
        SceneManager.LoadScene(2);
    }
    public void level2() 
    {
        clicksoundEffect2.Play();
        SceneManager.LoadScene(10);
    }    

    public void level3 ()
    {
        clicksoundEffect2.Play();
        SceneManager.LoadScene(11);
    }

    public void backqq()
    {
        clicksoundEffect2.Play();
        SceneManager.LoadScene(0);
    }
    public void story()
    {
        clicksoundEffect2.Play();
        SceneManager.LoadScene(2);
    }
}
