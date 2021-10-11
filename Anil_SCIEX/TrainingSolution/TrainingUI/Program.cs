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
			Course awscourse = new(new List<Training>()) { Id = 1, Name = "AWS" };

			//Training available under AWS Course
			awscourse.Trainings.Add(new(1,"AWS Basics",300,6000));
			awscourse.Trainings.Add(new(2,"AWS Developer Associate",200, 10000));
			awscourse.Trainings.Add(new(3,"AWS Technical Essentials",150, 15000));
			awscourse.Trainings.Add(new(4,"AWS SysOps Associate",100, 12000));


			// Python Course
			Course pythoncourse = new(new List<Training>()) { Id = 1, Name = "Python"};

			//Training available under Python Course
			pythoncourse.Trainings.Add(new(1, "Python Basics",350, 5000));
			pythoncourse.Trainings.Add(new(2,"Python Developer Associate",250, 6000));
			pythoncourse.Trainings.Add(new(3,"Python Developer Associate",250, 6000));
			pythoncourse.Trainings.Add(new(4,"Python Architecture",60 ,10000));


		// Courses available under Consultancy 
		List<Course> consultancycourses = new() { awscourse, pythoncourse };

			foreach (var course in consultancycourses)
			{
				Console.WriteLine("*********************"+course.Name+" ["+course.Id+"] "+"***********************");
				Console.WriteLine("********************************************************");
				
				foreach (var training in course.Trainings)
				{
					
					Console.WriteLine("Course Name : "+
					                  training.Name +" -----> Training Hours : "
					                  +training.TrainingHours +" Hours "+"-----> Cost : "+training.Cost+ " Rupees ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
