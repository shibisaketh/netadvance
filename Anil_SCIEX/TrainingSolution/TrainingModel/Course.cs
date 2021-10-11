using System;
using System.Collections.Generic;

namespace TrainingModel
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Training> Trainings { get; set; }
		
	}

	
}
