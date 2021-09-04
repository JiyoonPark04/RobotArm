using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoulder: MonoBehaviour
{
    float timer;
    int waitingTime;
    public float ShoulderSpeed = 4.0f;

    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;

    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            transform.Rotate(new Vector3(0, 0, -10) * ShoulderSpeed * Time.deltaTime, Space.World);
        }

    }
}