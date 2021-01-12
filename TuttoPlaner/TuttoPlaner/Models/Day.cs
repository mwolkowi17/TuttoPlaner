﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuttoPlaner.Models
{
    public class Day
    {
        [PrimaryKey, AutoIncrement]
        public int DayId { get; set; }
        public int DayNumber { get; set; }
       
        public string DayPlans { get; set; }

    }
}
