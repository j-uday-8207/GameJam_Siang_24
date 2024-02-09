using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void level1()
    {
        SceneManager.LoadScene(2);
    }
    public void level2() 
    {
        SceneManager.LoadScene(10);
    }    

    public void level3 ()
    {
        SceneManager.LoadScene(11);
    }

    public void backqq()
    {
        SceneManager.LoadScene(0);
    }
    public void story()
    {
        SceneManager.LoadScene(2);
    }
}
