using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private BoxCollider2D coll;

    private float dirx = 0f;
    private float multiplier = 1f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private GameObject[] cherries;

    [SerializeField] private LayerMask jumpableGround;

    [SerializeField] private TextMeshProUGUI cherries_text;

    [SerializeField] private int cherries_count = 0;

    private enum MovementState { idle, running, jumping, falling}


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        if (cherries_count <= 1)
        {
            multiplier = 1f;
        }
        else if (cherries_count == 2)
        {
            multiplier = 0.8f;
        }
        else if (cherries_count == 3)
        {
            multiplier = 0.5f;
        }
        else
        {
            multiplier = 0f;
        }
        rb.velocity = new Vector2(dirx * moveSpeed * multiplier, rb.velocity.y);
        AnimationUpdateState();



        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * multiplier);
        }

        if(Input.GetKeyDown("1"))
        {
            ItemDrop();
        }


        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            cherries_count++;
            collision.gameObject.SetActive(false);
            cherries_text.text = "Object : " + cherries_count.ToString();
        }
    }
    private void AnimationUpdateState()
    {
        MovementState state;
        if (dirx > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirx < 0f)
        {
            state =MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state=MovementState.idle;
        }

        if (rb.velocity.y > 0.1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -0.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    private void ItemDrop()
    {
        for (int i = 0; i < cherries.Length; i++)
        {
            if (cherries[i].activeSelf == false)
            {
                cherries[i].SetActive(true);
                if (sprite.flipX)
                {
                    cherries[i].transform.position = transform.position + new Vector3(-2, 0, 0);
                }
                else
                {
                    cherries[i].transform.position = transform.position + new Vector3(2, 0, 0);
                }
                cherries_count--;
                cherries_text.text = "Object : " + cherries_count.ToString();
                break;
            }
        }
    }


}
