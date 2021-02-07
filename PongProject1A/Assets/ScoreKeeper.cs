using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public static int P1Score = 0;
    public static int P2Score = 0;
    public Ball ball;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = P1Score + "   :   " + P2Score;
        Debug.Log($"{P1Score}:{P2Score}");
        if(P1Score == 11)
        {
            Debug.Log("Game Over! Player 1 Wins!!!");
            score.fontSize = 100;
            score.text = "Game Over! Player 1 Wins!!!";
            ball.GetComponent<Ball>().StopBall();
        }
        else if(P2Score == 11)
        {
            Debug.Log("Game Over! Player 2 Wins!!!");
            score.fontSize = 100;
            score.text = "Game Over! Player 2 Wins!!!";
            ball.GetComponent<Ball>().StopBall();
        }
        
    }

}
