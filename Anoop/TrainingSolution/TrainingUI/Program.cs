using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingModel;

namespace TrainingUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course(1, "Python Couse");
            Course course2 = new Course(2, "Full Stack");
            Course course3 = new Course(3, "Architecure Program");
            List<Course> courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);
            courses.ForEach(course => Console.WriteLine("Course Name:" + course.name + " ***" + " Course Id:" + course.id));
            Console.WriteLine("---------");
            Training training1 = new Training(1, "Basic Python Training", "John", 1000.00);
            Training training2 = new Training(2, "WebDevelopment", "Emma", 2000.00);
            Training training3 = new Training(3, "Design Principle", "Rahul", 3000.00);
            List<Training> trainings = new List<Training>();
            trainings.Add(training1);
            trainings.Add(training2);
            trainings.Add(training3);
            trainings.ForEach(training => Console.WriteLine("Training Name: " + training.Name
                + " ***" + " Hr:" + training.TrainingHr
                + " ***" + " Cost:" + training.Cost));
            Console.ReadLine();
        }
    }
}
