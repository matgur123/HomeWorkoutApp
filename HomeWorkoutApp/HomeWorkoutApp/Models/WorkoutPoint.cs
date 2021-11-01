using System;
using System.Collections.Generic;


namespace HomeWorkoutBL.Models
{
    public partial class WorkoutPoint
    {
        public int PointsUserId { get; set; }
        public int PointsId { get; set; }
        public int DateAndTime { get; set; }
        public int PointsGathered { get; set; }
    }
}
