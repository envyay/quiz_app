using System.Diagnostics;

namespace QuizApp.Service;

public class TimerService
{
    private Stopwatch _stopwatch;
    private bool _isRunning = false;

    public TimerService()
    {
        _stopwatch = new Stopwatch();
    }

    public void Start()
    {
        if (_isRunning)
            return;
        _isRunning = true;
        _stopwatch.Start();
    }
    
    public TimeSpan Stop()
    {
        if (!_isRunning)
            return TimeSpan.Zero;
        _stopwatch.Stop();
        _isRunning = false;
        return _stopwatch.Elapsed;
    }
    
    public TimeSpan Elapsed()
    {
        return _stopwatch.Elapsed;
    }
    
    public void Reset()
    {
        _stopwatch.Reset();
        _isRunning = false;
    }
    
    public string FormatTimeSpan(TimeSpan timeSpan)
    {
        return $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
    }
}