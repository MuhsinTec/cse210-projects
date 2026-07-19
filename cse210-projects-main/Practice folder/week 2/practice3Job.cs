using System;

class System;
public class Job
{
    //Responsibilities
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Behavior

    public void DisplayJobTitle()
    {
        Console.WriteLine($"{_jobTitle} {(_companyName)}");
    }
    public void DisplayPeriod()
    {
        Console.Write($"{_startYear}-{_endYear}");
    }
}