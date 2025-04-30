using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Zookeeper";
        job2._company = "Norfolk Zoo";
        job2._startYear = 2000;
        job2._endYear = 2025;

        //job1.Display();

        Resume myResume = new Resume();
        myResume._name = "Larbold";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.DisplayResume();

    }
}