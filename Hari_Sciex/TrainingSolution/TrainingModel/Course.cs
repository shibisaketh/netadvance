using System;
using System.Collections.Generic;

namespace TrainingModel
{
	public class Course
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public List<Training> ListOfTrainings;

		public Course(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
			ListOfTrainings = new List<Training>();
		}

		public void AddTraining(string name, double trainingHr, double cost)
		{
			ListOfTrainings.Add(new Training(name, trainingHr, cost));
		}

		public void RemoveTraining(Guid id)
		{
			for (int i = 0; i < ListOfTrainings.Count; i++)
			{
				if (ListOfTrainings[i].Id == id)
				{
					ListOfTrainings.Remove(ListOfTrainings[i]);
				}
			}
		}
	}
}
