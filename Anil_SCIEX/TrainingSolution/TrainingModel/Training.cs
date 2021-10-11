
namespace TrainingModel
{
	public class Training
	{
		public Training(int id,string name, int trainingHours,int cost)
		{
			Id = id;
			Name = name;
			TrainingHours = trainingHours;
			Cost = cost;
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public  int TrainingHours { get; set; }
		public int Cost { get; set; }
	}
}
