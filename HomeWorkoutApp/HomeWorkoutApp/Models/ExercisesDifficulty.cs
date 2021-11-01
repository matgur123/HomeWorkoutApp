using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkoutApp.Models
{
    class ExercisesDifficulty
    {
        public ExercisesDifficulty()
        {
            Exercises = new List<Exercise>();
        }

        public int DifficultyId { get; set; }
        public string Difficulty { get; set; }

        public virtual List<Exercise> Exercises { get; set; }
    }
}
