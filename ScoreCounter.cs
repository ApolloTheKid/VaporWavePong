using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreCounter : MonoBehaviour
{

    //variables
    private int player1Score = 0;
    private int player2Score = 0;

    public Text scoreBoard;
    public GameObject ball;

   

    void Start()
    {
        ball = GameObject.Find("ball");
    }


    void Update()
    {
        if (ball.transform.position.x >= 9f)
        {
          player1Score++;
        }

        if (ball.transform.position.x <= -9f)
        {
          player2Score++;
        }

        if(player1Score >= 7)
        {
            SceneManager.LoadScene(2);
        }
        if (player2Score >= 7)
        {
            SceneManager.LoadScene(3);
        }


        scoreBoard.text = player1Score.ToString() + " - " + player2Score.ToString();
    }
}
