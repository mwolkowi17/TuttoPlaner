using System;
using System.Collections.Generic;
using System.Text;

namespace TuttoPlaner.Models
{
    class Day
    {
        public int DayId { get; set; }
        public int DayNumber { get; set; }
        public Month DayMonth { get; set; }
        public string DayPlans { get; set; }

    }
}
