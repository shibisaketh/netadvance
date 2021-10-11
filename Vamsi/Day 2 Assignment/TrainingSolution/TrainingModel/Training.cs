using System;

namespace TrainingModel
{
    public class Training
    {
        public readonly Guid Id;

        public readonly string Name;

        public readonly int Hours;

        public readonly int Cost;

        public Training(string name, int hours, int cost)
        {
            Id = Guid.NewGuid();
            Name = name;
            Hours = hours;
            Cost = cost;
        }
    }
}
