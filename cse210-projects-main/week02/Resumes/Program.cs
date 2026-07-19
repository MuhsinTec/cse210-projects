using System;

class Program
{
    static void Main(string[] args)
    {
        // First Job
        Job job1 = new Job();
        job1._jobTitle = "Technician";
        job1._company = "Self Employment";
        job1._startYear = 2018;
        job1._endYear = 2020;

        // Second Job
        Job job2 = new Job();
        job2._jobTitle = "Founder and Lead Technician ";
        job2._company = "MTES - Muhsin Technical Engineering Services Limited";
        job2._startYear = 2020;
        job2._endYear = 2026;

        // Resume instance
        Resume myResume = new Resume();
        myResume._name = "Namboobi Nagimesi Muhsin";

        // Adding both jobs to resume's list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Run the Display method on the resume to print everything!
        myResume.Display();
    }
}