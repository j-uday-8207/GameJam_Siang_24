using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AstroLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public int Level_index;
    public bool Check = true;
    [SerializeField] public AudioSource deathsoundEffect;
    public Timer_controll tim2;


    private void Start()
    {
satron        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            tim2.o2depletedsoundEffect.Stop();
            deathsoundEffect.Play();
            if (Check)
            {
                PlayerPrefs.SetInt("Scene_State", SceneManager.GetActiveScene().buildIndex);
                Check = false;
            }
            Debug.Log(Level_index);
            Die();
        }
    }


    public void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(17);
    }

    
}
