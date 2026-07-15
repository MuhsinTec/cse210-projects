using System;

class Program
{
    static void Main(string[] args)
    {
        // Job 1
        Job job1 = new Job();
        job1._jobTitle = "Lead Technical Engineer & Owner";
        job1._company = "MTES - Muhsin Technical Engineering Services Limited";
        job1._startYear = 2020;
        job1._endYear = 2026;

        // Job 2
        Job job2 = new Job();
        job2._jobTitle = "Electronic Appliance Specialist";
        job2._company = "Self Employment";
        job2._startYear = 2018;
        job2._endYear = 2020;

        
        Resume myResume = new Resume();
        myResume._name = "Namboobi Nagimesi Muhsin";

        // Milestones
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Profile
        
        myResume.Display();
    }
}