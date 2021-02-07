using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5f;
    public Ball ball;
    public Vector3 startingSpot;

    // Start is called before the first frame update
    void Start()
    {
        startingSpot = ball.transform.position;
        float nz = Random.Range (0,2) == 0 ? -1 : 1;
        float ny = Random.Range (0,2) == 0 ? -1 : 1;

        GetComponent<Rigidbody> ().velocity = new Vector3 (0f, speed * ny, speed * nz);
    }

    public void Reset(bool isGoal1)
    {
        if(isGoal1 == true)
        {
            float nz = Random.Range (0,2) == 0 ? -1 : 1;
            float ny = Random.Range (0,2) == 0 ? -1 : 1;
            ball.transform.position = startingSpot;
            GetComponent<Rigidbody> ().velocity = new Vector3 (0f, speed * ny, speed * nz);
        }
        else 
        {
            float nz = Random.Range (0,-2) == 0 ? -1 : 1;
            float ny = Random.Range (0,-2) == 0 ? -1 : 1;
            ball.transform.position = startingSpot;
            GetComponent<Rigidbody> ().velocity = new Vector3 (0f, speed * ny, speed * nz);
        }
    }

    public void StopBall(){
        GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
    }
    
}
