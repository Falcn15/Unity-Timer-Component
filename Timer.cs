public class Timer
{
    public float time { get; private set; }

    public Timer(float time)
    {
        SetTime(time);
    }

    public void SetTime(float time)
    {
        this.time = time;
    }

    public void StepTime(float DeltaTime)
    {
        time -= DeltaTime;

        if (time < 0f)
        {
            time = 0f;
        }
    }
}
