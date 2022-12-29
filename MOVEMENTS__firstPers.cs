using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENTS__firstPers : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator animal;
    public int X = 0;
    // Start is called before the first frame update

    void Update()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
            animal.SetBool("isRunning", true);
        }
        if (Input.GetKey("q") || Input.GetKey("left"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
            animal.SetBool("isRunning", true);
        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("q") || Input.GetKeyUp("right") || Input.GetKeyUp("left"))
        {
            rb.velocity = Vector2.zero;
            animal.SetBool("isRunning", true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy") 
        {
            X++; 
        }
        if (X == 10) 
        {
            Destroy(gameObject);
        }
    }



}

