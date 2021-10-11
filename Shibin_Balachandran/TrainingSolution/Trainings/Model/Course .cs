using System;

namespace TrainingModel
{
    public class Course
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public void SetId(Guid id)
        {
            Id = id;
        }
        public Course( string courseName)
        {
            Name = courseName;
            Id = new Guid();
            Id = Guid.NewGuid();
        }

    }
}
