using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer;
    public float speed = 10f;

    void Update()
    {
        if(isPlayer)
        {
            transform.Translate(0f, Input.GetAxis("Player1") * speed * Time.deltaTime, 0f);
        } 
        else 
        {
            transform.Translate(0f, Input.GetAxis("Player2") * speed * Time.deltaTime, 0f);
        }
    }
}
