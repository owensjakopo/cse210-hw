using System;

class Program
{
    static void Main(string[] args)
    { 
        Job job1 = new Job();
        job1._jobTitle = "Assistant Web Designer";
        job1._company = "Dat Net Communications";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Administrator";
        job2._company = "Life-Long College";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Owen S. Jakopo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

        Console.WriteLine();

    }
}