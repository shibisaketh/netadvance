/////////////////////////////////////////////////////////////////////////////////////////////////////////
//Create Solution name TrainingSolution
//create Console application of .net framework name as TrainingUI
//create class Library name as TrainingModel
//create classes ->
//				Course [Id, name] e.g.Python Course, Full Stack, Architecure Program
//				   -> List of Trainings
//				Training [Id, Name, TrainingHr, Cost] e.g.Basic Python Training, WebDevelopment, Design Principle
//
//Run from TrainingUI
//		Display all couses with Trainings
//
//		************** Course Name [Course ID]************************
//		************************************************************
//		Display List of Trainings
//		$$$$$$$$$$Name : Training Name$$$ Hr : $$$$ Cost:$$$$$$$$$$$
//
//Bonus:
//
//Q.Do you want to Add new Training select the couse
//		  1. Python Course,
//		  2. Full Stack,
//		  3. Architecure Program
//
//		Ans 1.
//
//		Get the Python Course and add new Training.
//		Q.Enter traning Name, Hr Cost,
//
//	   Add new traning in the select couse. 
/////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Training.Model;
namespace TrainingUI
{

    class Program
    {
        static Random _rdm1 = new Random();
        static Random _rdm2 = new Random();
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int input = 0;
            List<Course> course = new List<Course>();
            course.Add(new Course(RandomCourseID(), $"Python Course"));
            course[course.Count-1].AddTraining(RandomTraingID(course[course.Count - 1].CourseId)  , $"Advance Python Training", 1, 2500);
            course[course.Count - 1].AddTraining(RandomTraingID(course[course.Count - 1].CourseId), $"Master  Python Training", 1, 2000);
            course[course.Count - 1].AddTraining(RandomTraingID(course[course.Count - 1].CourseId), $"Basic   Python Training", 1, 1500);
            course.Add(new Course(RandomCourseID(), $"Full Stack"));
            course[course.Count - 1].AddTraining(RandomTraingID(course[course.Count - 1].CourseId), $"WebDevelopment", 1, 3000);
            course.Add(new Course(RandomCourseID(), $"Architecure Program"));
            course[course.Count - 1].AddTraining(RandomTraingID(course[course.Count - 1].CourseId), $"Design Principle", 1, 3500);

            var choice = 0;

            while (choice != 6)
            {
                // **************Course Name[Course ID] ************************
                // ************************************************************
                DisplayMenu(ref course);
                int.TryParse(Console.ReadLine().Trim(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("************ 1  -  Display List of Trainings under a course************");
                        Console.WriteLine("Please enter Couse ID to check list of Trainings");
                        input = 0;
                        if (!IsValidInput(Console.ReadLine().Trim(), ref course, ref input))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        Console.WriteLine($"************{course[input].CourseName} [{course[input].CourseId}]***********");
                        DisplayTrainingList(input, ref course);
                        break;
                    case 2:
                        Console.WriteLine("************ 2  -  Add New Cousre************");
                        Console.WriteLine("Please enter the New Course Name");
                        string CourseName = Console.ReadLine();
                        if (string.IsNullOrEmpty(CourseName))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        course.Add(new Course(RandomCourseID(), CourseName));
                        break;

                    case 3:
                        Console.WriteLine("************ 3  -  Remove a Cousre ************");
                        Console.WriteLine("Please enter the Course ID to delete the Course");
                        input = 0;
                        if (!IsValidInput(Console.ReadLine().Trim(), ref course, ref input))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        RemoveCourse(ref course, input);
                        break;

                    case 4:
                        Console.WriteLine("************ 4  -  Add New Training ************");
                        Console.WriteLine("Please enter the Course ID to Add a new Training to the couse");
                        input = 0;
                        if (!IsValidInput(Console.ReadLine().Trim(), ref course, ref input))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        Console.WriteLine($"************************{course[input].CourseName} current list******************");
                        DisplayTrainingList(input, ref course);
                        Console.WriteLine("******************************************");
                        Console.WriteLine($"Enter Training Name:");
                        string TrainingName = Console.ReadLine().Trim();
                        Console.WriteLine($"Enter Hours(0-24):");

                        int Hour = 0;
                        if (!int.TryParse(Console.ReadLine().Trim(), out Hour))
                        {
                            Console.WriteLine("Sorry, invalid Cost Value");
                            break;
                        }
                        if (Hour > 24)
                        {
                            Console.WriteLine("Sorry, invalid Hours Value");
                            break;
                        }
                        Console.WriteLine($"Enter Cost: INR");
                        int Cost = 0;
                        if (!int.TryParse(Console.ReadLine().Trim(), out Cost))
                        {
                            Console.WriteLine("Sorry, invalid Cost Value");
                            break;
                        }
                        course[input].AddTraining(RandomTraingID(course[input].CourseId), TrainingName, Hour, Cost);
                        Console.WriteLine($"************************{course[input].CourseName} Updated List************************");
                        DisplayTrainingList(input, ref course);

                        break;

                    case 5:
                        Console.WriteLine("************ 5  -  Remove a Training ************");
                        Console.WriteLine("Please enter the Course ID ");
                        input = 0;
                        if (!IsValidInput(Console.ReadLine().Trim(), ref course, ref input))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        Console.WriteLine($"************************{course[input].CourseName} current list******************");
                        DisplayTrainingList(input, ref course);
                        Console.WriteLine("******************************************");
                        Console.WriteLine("Please enter the Trainig ID to remove from course");
                        int Trainingid = 0;
                        if (!int.TryParse(Console.ReadLine().Trim(), out Trainingid))
                        {
                            Console.WriteLine("Sorry, invalid input");
                            break;
                        }
                        course[input].RemoveTraining(Trainingid);
                        Console.WriteLine($"************************{course[input].CourseName} updated list******************");
                        DisplayTrainingList(input, ref course);
                        break;


                    case 6:
                        Console.WriteLine("************ 6  -  Exit ************");
                        break;

                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputline"></param>
        /// <param name="listObj"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool IsValidInput(string inputline, ref List<Course> listObj, ref int ID)
        {

            if (!int.TryParse(inputline, out ID))
            {
                return false;
            }

          // map--id-DateTimeOffset index
            for (int i = 0; i < listObj.Count; i++)
            {
                if (listObj[i].CourseId == ID)
                {
                    ID = i;
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// DisplayTrainingList
        /// </summary>
        /// <param name="ItemIndex"></param>
        /// <param name="listObj"></param>
        public static void DisplayTrainingList(int ItemIndex, ref List<Course> listObj)
        {
            for (var j = 0; j < listObj[ItemIndex].Training.Count; ++j)
            {
                Console.WriteLine($"Training ID {listObj[ItemIndex].Training[j].Id}  Name:{listObj[ItemIndex].Training[j].Name}      Hours(H): {listObj[ItemIndex].Training[j].TrainingHr}   Cost: {listObj[ItemIndex].Training[j].Cost}INR");
            }

        }
        /// <summary>
        /// DisplayCourseList
        /// </summary>
        /// <param name="listObj"></param>
        public static void DisplayCourseList(ref List<Course> listObj)
        {
            Console.WriteLine($"Course ID    Course Name");
            for (var index = 0; index < listObj.Count; index++)
            {
                Console.WriteLine($" {listObj[index].CourseId}          {listObj[index].CourseName}");
            }
        }

        /// <summary>
        /// DisplayMenu
        /// </summary>
        /// <param name="listObj"></param>
        public static void DisplayMenu(ref List<Course> listObj)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"**************Course List************************");
            Console.WriteLine($"*************************************************");
            DisplayCourseList(ref listObj);
            Console.WriteLine(" ");
            Console.WriteLine("****************MENU***************************");
            Console.WriteLine("Command  Action");
            Console.WriteLine("   1  -  Display List of Trainings under a course ");
            Console.WriteLine("   2  -  Add New Cousre");
            Console.WriteLine("   3  -  Remove a Cousre ");
            Console.WriteLine("   4  -  Add New Training ");
            Console.WriteLine("   5  -  Remove a Training");
            Console.WriteLine("   6  -  Exit");
            Console.WriteLine(" ");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Please Enter the Command:");
        }



        public static int RandomTraingID(int CourseID)
        {
            int _min = 100;
            int _max = 999;
            
            return (CourseID * 1000) + _rdm1.Next(_min, _max);

        }

        public static int RandomCourseID()
        {
            int _min = 10;
            int _max = 99;
            
            return _rdm2.Next(_min, _max);
        }

        /// <summary>
        /// RemoveCourse
        /// </summary>
        /// <param name="name"></param>
        public static void RemoveCourse(ref List<Course> listObj,int id)
        {
            listObj.Remove(listObj[id]);
        }

    }
}
