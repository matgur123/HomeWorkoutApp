using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkoutApp.Models
{
    class ExercisesType
    {
        public ExercisesType()
        {
            Exercises = new List<Exercise>();
        }

        public int ExercisesTypeId { get; set; }
        public string ExercisetypeDes { get; set; }

        public virtual List<Exercise> Exercises { get; set; }
    }
}
