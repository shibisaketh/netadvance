// Course[Id, name] e.g.Python Course, Full Stack, Architecure Program
using System;
using System.Collections.Generic;
namespace Training.Model
{
    public class Course
    {

        public int CourseId { get; }
        private string _courseName;
        public List<Training> Training { get; set; }
        /// <summary>
        /// Course parameterized constructor
        /// </summary>
        /// <param name="courseName"></param>
        public Course(int courseid, string courseName)
        {
            CourseId = courseid;
            CourseName = courseName;
            Training = new List<Training>();
        }

        /// <summary>
        /// CourseName
        /// </summary>
        public string CourseName 
        { 
            get
            {
                return _courseName;
            }
             private set
            {
                if (!string.IsNullOrEmpty(value) &&(_courseName != value))
                {
                    _courseName = value;
                }
            }
        }

        /// <summary>
        /// AddCourse
        /// </summary>
        /// <param name="name"></param>
        public void AddTraining(int courseid, string name, long trainingHr, long cost)
        {
            Training.Add(new Training(courseid, name, trainingHr, cost));
        }


        /// <summary>
        /// RemoveCourse
        /// </summary>
        /// <param name="name"></param>
        public void RemoveTraining(int id)
        {

            for (int i = 0; i < Training.Count; i++)
            {
                if (Training[i].Id == id)
                {
                    Training.Remove(Training[i]);
                    break;
                }
            }

        }

    }
}
