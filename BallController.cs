using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    //variables
    private Rigidbody2D rb;
    public GameObject player1;
    public GameObject player2;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(pause());

        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
    }


    void Update()
    {
        if(Mathf.Abs (transform.position.x) >= 9f)
        {
            transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(pause());
        }
    }


    IEnumerator pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);
        if (directionX ==0)
        {
            directionX = 1;
        }



        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(7f * directionX, 5f * directionY);
    }


    void OnCollisionEnter2D (Collision2D hit)
    {
        if (hit.gameObject.name == "player1")
        {
            if(player1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(5f, 5f);
            }

            else if(player1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(5f, -5f);
            }

            else
            {
                rb.velocity = new Vector2(7f, 0f);
            }
        }

        if(hit.gameObject.name == "player2")
        {
            if (player2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-5f, 5f);
            }

            else if (player2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-5f, -5f);
            }

            else
            {
                rb.velocity = new Vector2(-7f, 0f);
            }
        }
    }
}
