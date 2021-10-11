using System;
using System.Collections.Generic;

namespace TrainingModel
{
    public class Consultancy
    {
        private readonly Guid Id;
        private readonly string Name;
        public List<Course> courses;

        public Consultancy(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void RemoveCourse(Guid courseId)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Id == courseId)
                {
                    courses.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
