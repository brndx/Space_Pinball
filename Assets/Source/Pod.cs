// © Copyright Brandon Gallo 2018. All Rights Reserved.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pod : MonoBehaviour
{
    public Vector2 velocity;
    
    public Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb2D.position = rb2D.position + velocity * Time.fixedDeltaTime;
        }
    }
}
