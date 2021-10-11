using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingModel
{
   public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TrainingHr { get; set; }
        public double Cost { get; set; }
        public Training(int id, string name, string trainingHr, double cost)
        {
            Id = id;
            Name = name;
            TrainingHr = trainingHr;
            Cost = cost;
        }

    }
}
