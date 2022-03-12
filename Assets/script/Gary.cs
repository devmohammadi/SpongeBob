using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gary : MonoBehaviour
{
    public float speed = 4;
    public Rigidbody2D rb;
    private Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }
    public void Reset()
    {
        transform.position = startPosition;
        rb.velocity = Vector2.zero;
        Launch();
    }
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector3(speed * x, speed * y);
    }
}
