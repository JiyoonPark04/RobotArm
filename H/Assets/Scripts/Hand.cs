using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    float timer;
    int waitingTime;
    public float HandsSpeed = 4.0f;

    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;

    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer>waitingTime)
        {
           transform.Rotate(new Vector3(0, 0, -10) * HandsSpeed * Time.deltaTime, Space.World);
        }

    }
}
