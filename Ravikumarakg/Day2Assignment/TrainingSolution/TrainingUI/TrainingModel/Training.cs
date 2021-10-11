using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingUI.TrainingModel
{
    class Training
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Hr { get; set; }
        public int Cost { get; set; }

        public Training(int id , String training_name , String training_hr , int training_cost)
        {
            Id = id;
            Name = training_name;
            Hr = training_hr;
            Cost = training_cost;
        }
    }
}
