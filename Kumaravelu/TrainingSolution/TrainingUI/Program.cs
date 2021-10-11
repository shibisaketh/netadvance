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
            Console.WriteLine("************** Course Name [Couse ID]************************");
            var CourseDetails= AddCourse();

            foreach(var a in CourseDetails)
              Console.WriteLine(string.Format("Course ID:{0},  Cours Name:{1}",a.ID,a.name));

            Console.WriteLine("************** List of Tranings************************");
            var TrainingDetails = AddTrainings();
            foreach (var a in TrainingDetails)
                Console.WriteLine(string.Format("Traing Name:{0} , Traning  Hours:{1},  Training Cost:{2}", a.Trainingname, a.Hours, a.cost));
           
            Console.ReadLine();
        }

        public static List<Course> AddCourse()
        {
            var coursename = new List<Course>()
            {
                new Course
                {

                    ID=1,
                    name= "Python Course",
                },
                new Course
                {
                    ID=2,
                    name= "Full Stack",
                },
                new Course
                {
                    ID=3,
                    name= "Architecure Program",
                }

            };

            return coursename;

        }
        public static List<Training> AddTrainings()
        {

            var training = new List<Training>() {
              new Training
                {
                    Trainingname ="Basic python",
                    Hours = "2",
                    cost=30.00
                },
              new Training
                {
                    Trainingname ="WebDevelopment",
                    Hours = "5",
                    cost=50.00
                },
               new Training
                {
                    Trainingname ="Design Principle",
                    Hours = "2",
                    cost=10.00
                }
            };

            return training;

        }
    }
}
