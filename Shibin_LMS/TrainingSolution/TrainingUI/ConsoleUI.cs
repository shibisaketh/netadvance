using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingModel;

namespace TrainingUI
{
    class MyConsultancy
    {
        Dictionary<int, Course> courseList;
        Dictionary<int, Training> trainingList;
        int courseCount = 0;

        public MyConsultancy()
        {
            courseList = new Dictionary<int, Course>();
            trainingList = new Dictionary<int, Training>();
        }
        public  Course  AddCourse(string name)
        {
            Course item = new Course(name);
            courseList.Add(++courseCount,item);

            return item;
                
        }
        public void AddTraining(string name, string hr, long cost, Guid courseId)
        {
            trainingList.Add(trainingList.Count()+1, new Training(name, hr, cost, courseId));
        }        
        
        public void ShowCourses()
        {
            foreach( var course in courseList)
            {
                Console.WriteLine("\n***  " + course.Key + "\t:\t" + course.Value.Name + "\t\t:\t" + course.Value.Id);
            }
        }  
        public void ShowTraining()
        {
            foreach( var course in courseList)
            {
                Console.WriteLine("\n***  " + course.Key + "\t:\t" + course.Value.Name + "\t\t:\t" + course.Value.Id);
                foreach(var training in trainingList)
                {
                    if(course.Value.Id == training.Value.Id)
                        Console.WriteLine("\n***  " + training.Key + "\t:\t" + training.Value.Name + "\t\t:\t" + training.Value.TrainingHr + "\t\t:\t" +  training.Value.Cost + "\t\t:\t" + training.Value.Id);
                }
            }
        }      
    }
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            MyConsultancy myConsultancy = new MyConsultancy();
            Guid pythonID = myConsultancy.AddCourse("Python Couse").Id;
            myConsultancy.AddTraining("Basic Python Training", "Akbar ali", 1000, pythonID);
            myConsultancy.AddTraining("Advanced Python Training", "Ashuthosh", 4000, pythonID);

            myConsultancy.AddCourse("Full Stack");
            myConsultancy.AddCourse("Architecure Program");

            Console.WriteLine("*******Welcome********");
            myConsultancy.ShowTraining();
        }
    }
}
