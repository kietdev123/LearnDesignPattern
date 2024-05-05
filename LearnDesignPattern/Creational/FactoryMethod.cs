using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPattern.Creational
{   

    abstract class Job
    {
        public abstract void work();
    }

    class Teacher : Job
    {
        public override void work()
        {
            Console.WriteLine("Teaching English");
        }
    }

    class Developer : Job
    {
        public override void work()
        {
            Console.WriteLine("Coding...");
        }
    }

    interface JobFactory
    {
        Job createJob();
    }

    class TeacherFactory : JobFactory
    {
        public Job createJob()
        {
            return new Teacher();
        }
    }

    class DeveloperFactory : JobFactory
    {
        public Job createJob()
        {
            return new Developer();
        }
    }
    class Task
    {
        public Job job;

        public Task(JobFactory jobFactory)
        {
            job = jobFactory.createJob();
        }
    }

    class FactoryMethod
    {
        public void doExample()
        {
            Console.WriteLine("Factory method example");
            
            TeacherFactory teacherFactory = new TeacherFactory();
            Task teacherTask = new Task(teacherFactory);
            teacherTask.job.work();

            DeveloperFactory developerFactory = new DeveloperFactory();
            Task task = new Task(developerFactory);
            task.job.work();

            Console.ReadLine();
        }
    }
}
