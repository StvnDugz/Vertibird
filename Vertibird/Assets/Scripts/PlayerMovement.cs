using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float upForce = 50f;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // if the player is alive
        if (isDead == false)
        {
            // if the space bar key is pressed
            if (Input.GetKey(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("fly");
            }
        }
    }


    void OnCollisionEnter2D()
    {
        isDead = true;
        anim.SetTrigger("die");
        GameControl.instance.PlayerDied();
        rb2d.velocity = Vector2.zero;
    }
}