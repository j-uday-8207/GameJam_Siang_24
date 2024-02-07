using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject[] cherries;

    [SerializeField] TextMeshProUGUI finish_text;
    private void Start()
    {
        finish_text.text = "";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Astro")
        {
            int count = CountCherries();
            Debug.Log(count);
            if (count <= 2)
            {
                finish_text.text = "Need at least 3 collectibles";
                Invoke("EmptyText", 2f);
            }
            else
            {
                Invoke("CompleteLevel", 2f);
            }
        }
        
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private int CountCherries()
    {
        int count;
        count = 0;
        for (int i = 0; i < cherries.Length; i++)
        {
            if (cherries[i].activeSelf == false)
            {
                count++;
            }
        }
        return count;
    }

    private void EmptyText()
    {
        finish_text.text = "";
    }
}
