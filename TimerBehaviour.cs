using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    private Timer timer;
    public bool activated { get; private set; } = false;

    [SerializeField] float time;
    [SerializeField] bool ActiveOnStart = true;
    [SerializeField] UnityEvent OnTimerEnds;

    private void Start()
    {
        if (ActiveOnStart)
        {
            timer = new Timer(time);
            activated = true;
        }
    }

    private void Update()
    {
        if (timer != null)
        {
            if (timer.time == 0)
            {
                OnTimerEnds?.Invoke();
            }
            else
            {
                timer.StepTime(Time.deltaTime);
                //Debug.Log(timer.time);
            }
        }
    }

    public void SetTimer(float time)
    {
        if (!ActiveOnStart)
        {
            this.time = time;
            if (!activated)
            {
                timer = new Timer(this.time);
                activated = true;
            }
            else
            {
                timer.SetTime(time);
            }
        }
        else
        {
            Debug.Log("Cannot set timer if 'ActiveOnStart' is true");
        }
    }

    public float GetTime()
    {
        return timer.time;
    }
}
