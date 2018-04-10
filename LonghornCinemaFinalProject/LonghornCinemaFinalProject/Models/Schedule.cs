﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LonghornCinemaFinalProject.Models
{
    public class Schedule
    {
        // ***** Katie says we may not need this class

        // Properties
        // ScheduleID
        public Int32 ScheduleID { get; set; }

        // Navigation Properties
        // Showings
        public virtual List<Showing> Showings { get; set; }

        public Schedule()
        {
            if (Showings == null)
            {
                Showings = new List<Showing>();
            }
        }
    }
}