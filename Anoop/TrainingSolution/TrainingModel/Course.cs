using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingModel
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public Course(int courseId, string courseName)
        {
            id = courseId;
            name = courseName;
        }
    }
}
