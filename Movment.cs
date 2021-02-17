using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public float moveSpeed;
    public string midjump = "n";
    public float jumpHeight;
    public Rigidbody2D rb;
    private bool grounded = false;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public float szybkosc = 4.75f;
    public float mniejszszybkosc = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.gameObject.tag == "Grass")
        {
            grounded = true;
            Debug.Log("Dotknięto Grass");
        }
        else
        {
            grounded = false;
        }
    }*/



    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (rb.velocity.y == 0)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                    animator.SetFloat("Jump", Mathf.Abs(szybkosc));
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                animator.SetFloat("Jump", Mathf.Abs(mniejszszybkosc));
            }
           
            if (Input.GetKeyDown(KeyCode.D))
            {
                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
                spriteRenderer.flipX = false;
                animator.SetFloat("Speed", Mathf.Abs(szybkosc));
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetFloat("Speed", Mathf.Abs(mniejszszybkosc));
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
                spriteRenderer.flipX = true;
                animator.SetFloat("Speed", Mathf.Abs(szybkosc));
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetFloat("Speed", Mathf.Abs(mniejszszybkosc));
            }

    }

}