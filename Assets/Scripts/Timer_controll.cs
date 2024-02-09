using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer_controll : MonoBehaviour
{
    public Image timer_linear_remaning;
    public AstroLife aa;
    public float max_time = 30f;
    float time_rem;
    private bool check = false;
    private bool flag = false;
    [SerializeField] public AudioSource o2depletedsoundEffect;
    
    void Start()
    {
        time_rem = max_time;
    }

    // Update is called once per frame
    void Update()
    {
        if(time_rem > 0)
        {
            timer_linear_remaning.fillAmount = time_rem / max_time;
            time_rem -= Time.deltaTime;
        } 
        else if(time_rem<0f && check == false)
        {
            aa.deathsoundEffect.Play();
            PlayerPrefs.SetInt("Scene_State", SceneManager.GetActiveScene().buildIndex);
            o2depletedsoundEffect.Stop();
            aa.Die();
            check = true;
        }

        if(time_rem < 0.3f * max_time && flag == false )
        {
            o2depletedsoundEffect.Play();
            flag = true;
        }
        
    }

}
