using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isGoal1;
    public Ball ball;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if(isGoal1 == true)
        {
            ScoreKeeper.P1Score += 1;
            Debug.Log("Player 1 Scored!");
            ball.GetComponent<Ball>().Reset(isGoal1);
        }
        else 
        {
            ScoreKeeper.P2Score += 1;
            Debug.Log("Player 2 Scored!");
            ball.GetComponent<Ball>().Reset(isGoal1);
            
        }
    }
}
