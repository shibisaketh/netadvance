using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingUI.TrainingModel
{
    class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Course(int id , String courseName)
        {
            Id = id;
            Name = courseName;
        }
    }
    
}
