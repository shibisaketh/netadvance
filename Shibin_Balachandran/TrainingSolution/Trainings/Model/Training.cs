using System;

namespace TrainingModel
{
    public class Training
    {
        public Training(string name, string hr, long cost, Guid courseId)
        {
            Id = new Guid(Guid.NewGuid().ToString());
            courseId = new Guid();
            Name = name;
            TrainingHr = hr;
            Cost = cost;
            courseId = CourseId;
        }
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string TrainingHr { get; set; }
        public long Cost { get; set; }
        Guid CourseId {get; }
    }
}
