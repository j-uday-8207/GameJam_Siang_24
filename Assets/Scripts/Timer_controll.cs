using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_controll : MonoBehaviour
{
    public Image timer_linear_remaning;
    public AstroLife aa;
    public float max_time = 30f;
    float time_rem;
    private bool check = false;
    
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
        else if(time_rem<=0f && check == false)
        {
            aa.Die();
            check = true;
        }


        
    }

}
