using System;
using System.Collections.Generic;

namespace TrainingModel
{
	public class Consultancy
	{
		public List<Course> ListOfCourses;

		public Consultancy()
		{
			ListOfCourses = new List<Course>();
		}

		public Course AddCourse(string name)
		{
			Course course = new Course(name);
			ListOfCourses.Add(course);
			return course;
		}

		public void RemoveCourse(Guid id)
		{
			for (int i = 0; i < ListOfCourses.Count; i++)
			{
				if (ListOfCourses[i].Id == id)
				{
					ListOfCourses.Remove(ListOfCourses[i]);
				}
			}
		}
	}
}
