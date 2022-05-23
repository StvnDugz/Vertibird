using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLenght;

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLenght = groundCollider.size.x;
    }


    void Update()
    {
        if (transform.position.x < -groundHorizontalLenght)
        {
            RepositionBackground();
        }
    }


    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
