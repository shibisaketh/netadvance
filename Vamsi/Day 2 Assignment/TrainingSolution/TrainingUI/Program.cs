using System;
using System.Collections.Generic;
using TrainingModel;

namespace TrainingUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add the initial set of trainings
            List<Training> pythonTrainings = new List<Training>()
            {
                new Training("Basic Python Training", 6, 900),
                new Training("Intermediate Python Training", 9, 1200),
                new Training("Advanced Python Training", 12, 1500)
            };
            List<Training> webDevelopmentTrainings = new List<Training>()
            {
                new Training("HTML, CSS & Javascript", 6, 800),
                new Training("React, Angualar & Vue", 12, 1500),
                new Training("Backbone & WebAssembly", 15, 1800)
            };
            List<Training> designPatternTrainings = new List<Training>()
            {
                new Training("Behavioral Patterns", 8, 1000),
                new Training("Creational Patterns", 12, 1200),
                new Training("Structural Patterns", 12, 1200)
            };

            // Create courses with the trainings
            Course pythonCourse = new Course("Python (Basic to advanced)");
            foreach (Training training in pythonTrainings)
            {
                pythonCourse.AddTraining(training);
            }

            Course webDevelopmentCourse = new Course("Web Development");
            foreach (Training training in webDevelopmentTrainings)
            {
                webDevelopmentCourse.AddTraining(training);
            }

            Course architectureCourse = new Course("Software Architecture");
            foreach (Training training in designPatternTrainings)
            {
                architectureCourse.AddTraining(training);
            }

            // Create consultancy with the courses
            Consultancy consultancy = new Consultancy("Coursera");
            consultancy.AddCourse(pythonCourse);
            consultancy.AddCourse(webDevelopmentCourse);
            consultancy.AddCourse(architectureCourse);

            // Display the initial courses and trainings to the user
            DisplayCurriculum(consultancy);

            // Ask the user if they want to add any new trainings
            bool trainingAdded = false;
            while (true)
            {
                Console.WriteLine("Do you want to add a new training? (Y/N)");
                char choice = Console.ReadKey().KeyChar;
                if (choice != 'y' && choice != 'Y')
                    break;
                Console.WriteLine("\n");

                Console.WriteLine("Select the course");
                for (int i = 0; i < consultancy.courses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {consultancy.courses[i].Name}");
                }
                int courseIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("");

                Console.Write("Enter training name: \n");
                string trainingName = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Enter training hours: ");
                int trainingHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Enter training cost: ");
                int trainingCost = Convert.ToInt32(Console.ReadLine());
                consultancy.courses[courseIndex].AddTraining(new Training(trainingName, trainingHours, trainingCost));
                Console.WriteLine("\n");
                trainingAdded = true;
            }
            Console.WriteLine();

            // Display the list of trainings and courses again if something was added
            if (trainingAdded)
            {
                Console.WriteLine("\nConsultancy curriculum after adding the trainings:");
                DisplayCurriculum(consultancy);
            }
        }

        public static void DisplayCurriculum(Consultancy consultancy)
        {
            Console.WriteLine();
            foreach (Course course in consultancy.courses)
            {
                string courseHeader = $"******************************** {course.Name} ({course.Id}) ********************************";
                string courseSeparator = new string('*', courseHeader.Length);
                Console.WriteLine(courseHeader);
                Console.WriteLine(courseSeparator);

                foreach (Training training in course.trainings)
                {
                    Console.WriteLine($"$$$$$$$$$ Name: {training.Name} $$$ Hr: {training.Hours} $$$ Cost: {training.Cost} $$$$$$$$$");
                }
                Console.WriteLine();
            }
        }
    }
}
