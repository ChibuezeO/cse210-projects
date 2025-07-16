using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2024;

        /*job1.Display();
        job2.Display();*/

        Resume myResume = new Resume();
        myResume._name = "Hyacinth Okoro";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        /*Console.WriteLine("Hello World! This is the Resumes Project.");*/
    }
}