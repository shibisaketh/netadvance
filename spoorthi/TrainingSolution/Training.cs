using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSolution
{
    class Training
    {
       public List<TrainingModel> CourseListGet()
        {
            List<TrainingModel> _CourseModel = new List<TrainingModel>();

            List<TrainingModel> course = new List<TrainingModel>
            {
                new TrainingModel { TrainingID = 1,TrainingName= "basic python", TrainingHR = "15",Cost = 4000},
                new TrainingModel { TrainingID = 1,TrainingName= " web development", TrainingHR = "20",Cost = 5000},
                new TrainingModel { TrainingID = 1,TrainingName= "basics of Java", TrainingHR = "30",Cost = 6000},
                new TrainingModel { TrainingID = 1,TrainingName= "advanced java", TrainingHR = "40",Cost = 8000}
            };
            return course;
        }
    }
}
