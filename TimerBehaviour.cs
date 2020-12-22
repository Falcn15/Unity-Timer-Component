using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    private Timer timer;

    public bool isActived { get; private set; } = false;

    [SerializeField] float time;
    [SerializeField] bool ActiveOnStart = true;
    [SerializeField] UnityEvent OnTimerEnds;

    private void Start()
    {
        if (ActiveOnStart)
        {
            StartTimer();
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

    public void SetTime(float time)
    {
        this.time = time;
    }

    public void StartTimer()
    {
        timer = new Timer(time);
        isActived = true;
    }

    public void StartTimer(float time)
    {
        SetTime(time);
        StartTimer();
    }

    public float GetTime()
    {
        return timer.time;
    }
}
