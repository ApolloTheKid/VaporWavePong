using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatOneController : MonoBehaviour
{
    //variables
    private Rigidbody2D rb;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        //Check input for bat movement
        if(Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 6f);
        }


        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -6f);
        }


        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

    }
}
