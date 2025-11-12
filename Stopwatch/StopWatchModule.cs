public class StopWatchModule
{
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }
    public int Miliseconds { get; private set; }

    private readonly int tickStep;
    public StopWatchModule(int tickStep = 15)
    {
        this.tickStep = tickStep;
    }
    public void Tick()
    {
        Miliseconds += tickStep;
        if (Miliseconds >= 1000)
        {
            Miliseconds = 0;
            Seconds++;
        }
        if (Seconds >= 60)
        {
            Seconds = 0;
            Minutes++;
        }
        if (Minutes >= 60)
        {
            Minutes = 0;
            Hours++;
        }
    }
    public void Reset()
    {
        Hours = Minutes = Seconds = Miliseconds = 0;
    }
    public string GetFormattedTime()
    {
        return $"{Hours: 00}:{Minutes:00}:{Seconds:00}:{Miliseconds:00}";
    }
}

