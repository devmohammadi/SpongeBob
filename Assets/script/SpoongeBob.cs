using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoongeBob : MonoBehaviour
{

    public float speed = 4;
    public Rigidbody2D rb;
    public float move;
    private Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(rb.velocity.y, move * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
