using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextVisibility : MonoBehaviour
{
    [SerializeField] private Transform Astro;
    [SerializeField] private GameObject Text;
    [SerializeField] private int x_begin;
    [SerializeField] private int x_end;
    void Update()
    {
        if (Astro.position.x >=x_begin && Astro.position.x <=x_end)
        {
            IsVisible();
        }
        else
        {
            IsNotVisible();
        }
    }

    private void IsVisible()
    {
        Text.SetActive(true);
    }

    private void IsNotVisible()
    {
        Text.SetActive(false);
    }
}
