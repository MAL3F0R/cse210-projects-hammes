using System;

public class Job
{
    public string _jobName;
    public string _employerName;
    public int _beginEmployment;
    public int _endEmployment;

    public void DisplayInfo()
    {
        Console.WriteLine($"Job Title: {_jobName} ({_employerName}) {_beginEmployment}-{_endEmployment}");
    }
}