using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job();

        resume._name = "Dallin Whetten";

        job1._company = "The Yard Guys";
        job1._jobTitle = "Professional Landscaper";
        job1._startYear = 2020;
        job1._endYear = 2021;

        job2._company = "Safeway";
        job2._jobTitle = "In store shopper";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job3._company = "Pacific Building Systems";
        job3._jobTitle = "Systems Developer";
        job3._startYear = 2025;
        job3._endYear = 2026;


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.Display();
    }
}