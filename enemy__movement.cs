using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy__movement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
