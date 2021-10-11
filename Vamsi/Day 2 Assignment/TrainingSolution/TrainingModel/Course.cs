using System;
using System.Collections.Generic;

namespace TrainingModel
{
    public class Course
    {
        public readonly Guid Id;
        public readonly string Name;
        public List<Training> trainings;

        public Course(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            trainings = new List<Training>();
        }

        public void AddTraining(Training training)
        {
            trainings.Add(training);
        }

        public void RemoveTraining(Guid trainingID)
        {
            for (int i = 0; i < trainings.Count; i++)
            {
                if (trainings[i].Id == trainingID)
                {
                    trainings.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
