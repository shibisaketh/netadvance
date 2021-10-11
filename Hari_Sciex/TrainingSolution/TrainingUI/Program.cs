using System;
using TrainingModel;

namespace TrainingUI
{
	public class Program
	{
		private static Consultancy _consultancy;
		private static Course _pythonCourse;
		private static Course _fullStack;
		private static Course _architectureProgram;
		static void Main(string[] args)
		{
			_consultancy = new Consultancy();
			_pythonCourse = _consultancy.AddCourse("Python");
			_pythonCourse.AddTraining("Basic Python Training", 4.5, 80);

			_fullStack = _consultancy.AddCourse("Full Stack");
			_fullStack.AddTraining("Web Development", 2, 10.58);

			_architectureProgram = _consultancy.AddCourse("Architecture Program");
			_architectureProgram.AddTraining("Design Principle", 20, 200);

			ReadFromConsole();
			Display();
			
		}

		public static void Display()
		{
			for (int i = 0; i < _consultancy.ListOfCourses.Count; i++)
			{
				Console.WriteLine("*************" + _consultancy.ListOfCourses[i].Name + "[" + _consultancy.ListOfCourses[i].Id + "]*************");
				Console.WriteLine("*************************************************************");
				for (int j = 0;
					j < _consultancy.ListOfCourses[i].ListOfTrainings.Count;
					j++)
				{
					Console.WriteLine("$$$$$$$$$$$ Name:" + _consultancy.ListOfCourses[i].ListOfTrainings[j].Name + "  $$$ Hr:" + _consultancy.ListOfCourses[i].ListOfTrainings[j].TrainingHr + "   $$$ Cost:" + _consultancy.ListOfCourses[i].ListOfTrainings[j].Cost);

				}
				Console.WriteLine("\n\n");

			}
			Console.ReadLine();
		}

		public static void ReadFromConsole()
		{
			Console.WriteLine("Do you want to add new training? (Y/N)");
			var input = Console.ReadLine();
			if (input.Equals("Y"))
			{
				Console.WriteLine("Select the Course \n 1. Python Course \n 2. Full Stack \n 3. Architecture Program \n");
				var inputCourse = Console.ReadLine();
				Console.WriteLine("Enter Training Name, Training Hrs, Cost (Seperated by comma)");
				var inputTraining = Console.ReadLine();
				string[] trainingInfo = inputTraining.Split(',');

				if (inputCourse.Equals("1"))
				{
					_pythonCourse.AddTraining(trainingInfo[0], Double.Parse(trainingInfo[1].Trim()), Double.Parse(trainingInfo[2].Trim()));
				}
				else if (inputCourse.Equals("2"))
				{
					_fullStack.AddTraining(trainingInfo[0], Double.Parse(trainingInfo[1].Trim()), Double.Parse(trainingInfo[2].Trim()));
				}
				else if (inputCourse.Equals("3"))
				{
					_architectureProgram.AddTraining(trainingInfo[0], Double.Parse(trainingInfo[1].Trim()), Double.Parse(trainingInfo[2].Trim()));
				}
				else
				{
					Console.WriteLine("Invalid Input..");
				}

			}
		}


	}
}
