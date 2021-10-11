using System;

namespace TrainingModel
{
	public class Training
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public double TrainingHr { get; set; }
		public double Cost { get; set; }

		public Training(string name, double trainingHr, double cost)
		{
			Id = Guid.NewGuid();
			Name = name;
			TrainingHr = trainingHr;
			Cost = cost;
		}
	}
}
