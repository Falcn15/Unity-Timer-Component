using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTestScript : MonoBehaviour
{
    TimerBehaviour timerBehaviour;
    bool hasSentWarning = false;

    private void Start()
    {
        timerBehaviour = GetComponent<TimerBehaviour>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("User Pressed Space!");
            timerBehaviour.StartTimer(10f);
        }

        if (timerBehaviour.GetTime() < 5f && !hasSentWarning && timerBehaviour.isActived)
        {
            hasSentWarning = true;
            Debug.Log("Timer has 5 seconds left: " + timerBehaviour.GetTime().ToString());
        }
    }

}
