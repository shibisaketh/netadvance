using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSolution
{
    class Course
    {
       public List<CourseModel> CourseListGet()
        {
            List<CourseModel> _CourseModel = new List<CourseModel>();

            List<CourseModel> course = new List<CourseModel>
            {
                new CourseModel { CourseID = 1,CourseName= "python"},
                new CourseModel { CourseID = 2,CourseName= " Java full stack"},
                new CourseModel { CourseID = 3,CourseName= " architecture  program "},
                new CourseModel { CourseID = 4,CourseName= "machine learning"}
            };
            return course;
        }
    }
}
