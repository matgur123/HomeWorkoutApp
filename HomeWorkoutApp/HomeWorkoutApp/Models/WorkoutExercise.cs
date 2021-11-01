using System;
using System.Collections.Generic;

namespace HomeWorkoutBL.Models
{
    public partial class WorkoutExercise
    {
        public int WorkoutId { get; set; }
        public int ExercisesId { get; set; }
        public int NumOfReps { get; set; }
        public int NumOfSets { get; set; }
    }
}
