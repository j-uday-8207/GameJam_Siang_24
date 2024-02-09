using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 2f;
    private bool follow = false;

    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1)
        {
            follow = true;
        }
        if (follow)
        {
            FollowFunc();
        }
    }

    void FollowFunc()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
    }
}
