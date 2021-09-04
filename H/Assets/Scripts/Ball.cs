using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float timer;
    float waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        timer = 0.0f;
        waitingTime = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>waitingTime)
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
