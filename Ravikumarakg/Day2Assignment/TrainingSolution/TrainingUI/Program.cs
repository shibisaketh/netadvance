using System;
using TrainingUI.TrainingModel;

namespace TrainingUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            var course_instance = new Course(1, "Python");
            var course_instance2 = new Course(2, "Full Stack");
            var course_instance3 = new Course(3, "Architecure Program");
            var training_instance = new Training(11, "Python Course", "Ravikumar", 10000);
            var training_instance2 = new Training(12, "WebDevelopment", "Ramesh", 20000);
            var training_instance3 = new Training(13, "Design Principle", "Tejas Gowda", 10000);

            Console.WriteLine($"**************************{course_instance.Name}[{course_instance.Id}]******************************");
            Console.WriteLine($"*****************************************************************");

            Console.WriteLine($"$$$$$ Name: {training_instance.Name} $$$$$ HR: {training_instance.Hr} $$$ Cost: {training_instance.Cost} $$$");
            Console.WriteLine($"$$$$$ Name: {training_instance2.Name} $$$$$ HR: {training_instance2.Hr} $$$ Cost: {training_instance2.Cost} $$$");
            Console.WriteLine($"$$$$$ Name: {training_instance3.Name} $$$$$ HR: {training_instance3.Hr} $$$ Cost: {training_instance3.Cost} $$$");


        }
    }
}
