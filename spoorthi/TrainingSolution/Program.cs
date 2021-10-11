using System;
using System.Collections.Generic;

namespace TrainingSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int INPUT = 0;
            Console.WriteLine("Enter 1 for Course List,Enter 2 for Training List: ");
            string input = Console.ReadLine();
            try
            {
                INPUT = Int16.Parse(input);
            }
            catch (Exception xxx)
            {
                Console.WriteLine(xxx.Message);
            }

            if (INPUT == 1)
            {
                Course c = new Course();
                List<CourseModel> _Course = c.CourseListGet();
                Console.WriteLine(nameof(CourseModel.CourseID) + " " + nameof(CourseModel.CourseName));
                 foreach (CourseModel i in _Course)
                {
                    Console.WriteLine(i.CourseID+"         "+i.CourseName);
                }
                Console.WriteLine();
            }
            else if(INPUT == 2)
            {
                Training t = new Training();
                List<TrainingModel> _Training = t.CourseListGet();
                Console.WriteLine(nameof(TrainingModel.TrainingID) + "    " + nameof(TrainingModel.TrainingName) + "         " + nameof(TrainingModel.TrainingHR) + "      " + nameof(TrainingModel.Cost));
                foreach (TrainingModel i in _Training)
                {
                    Console.WriteLine(i.TrainingID + "             " + i.TrainingName+"             "+i.TrainingHR+"          "+ i.Cost);
                }
            }
            else
                Console.WriteLine();

        }
    }

}
