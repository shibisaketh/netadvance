using System;
using System.Collections.Generic;
using TrainingModel;

namespace TrainingUI
{
	class Program
	{
		static void Main()
		{
			// Aws Course
			Course awscourse = new() { Id = 1, Name = "AWS" };

			//Training available under AWS Course
			awscourse.Trainings = new()
			{
				new Training() { Id = 1, Name = "AWS Basics", Cost = 6000, TrainingHours = 300 },
				new Training() { Id = 2, Name = "AWS Developer Associate", Cost = 10000, TrainingHours = 200 },
				new Training() { Id = 3, Name = "AWS Technical Essentials", Cost = 15000, TrainingHours = 150 },
				new Training() { Id = 4, Name = "AWS SysOps Associate", Cost = 12000, TrainingHours = 100 }
			};

			// Python Course
			Course pythoncourse = new() { Id = 1, Name = "AWS" };

			//Training available under Python Course
			pythoncourse.Trainings = new()
			{
				new Training() { Id = 1, Name = "Python Basics", Cost = 5000, TrainingHours = 350 },
				new Training() { Id = 2, Name = "Python Developer Associate", Cost = 6000, TrainingHours = 250 },
				new Training() { Id = 3, Name = "Python Technical Essentials", Cost = 6500, TrainingHours = 100 },
				new Training() { Id = 4, Name = "Python Architecture", Cost = 10000, TrainingHours = 60 }
			};

			// Consultancy
			List<Course> courses = new() { awscourse, pythoncourse };

			foreach (var course in courses)
			{
				Console.WriteLine("*********************"+course.Name+" ["+course.Id+"] "+"***********************");
				Console.WriteLine("***********************************************************");
				foreach (var training in course.Trainings)
				{
					Console.WriteLine("$$$$$$$$$$$ Name : "+training.Name 
					+"$$$$$ Training Hours : "+training.TrainingHours
					+"$$$$$$$ Cost : "+training.Cost);
				}
			}
			Console.ReadKey();
		}
	}
}
