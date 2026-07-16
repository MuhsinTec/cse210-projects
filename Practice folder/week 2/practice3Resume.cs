using System;
using System.Collections.Generic;
class Person
{
    //Responsibilities
    public string _personalFullName;
    public List<Job> _jobs = new List<Job>();

    //Behaviors
    public void DisplayPersonalFullName()
    {
        Console.WriteLine($"Name: {_personalFullName}");
        Console.WriteLine("Jobs: ");
    }

    public void DisplayJobList()
    {
        foreach (string Job in _Jobs)
        {
        Job.Display();
        }
    }
}