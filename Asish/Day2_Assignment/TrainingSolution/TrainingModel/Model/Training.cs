//-> List of Trainings ->Training [Id, Name, TrainingHr, Cost] e.g.Basic Python Training, WebDevelopment, Design Principle
using System;
namespace Training.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Training
    {
        
        public int Id { get; }

        public string Name { get; }

        public long TrainingHr { get; }

        public long Cost { get; }

        /// <summary>
        /// Training parameterized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="trainingHr"></param>
        /// <param name="cost"></param>
        public Training(int id, string name, long trainingHr, long cost)
        {
            Id = id;
            Name = name;
            TrainingHr = trainingHr;
            Cost = cost;
        }

    }
}
