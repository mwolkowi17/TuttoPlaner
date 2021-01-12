using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TuttoPlaner.Models
{
    public class Month
    {
        [PrimaryKey, AutoIncrement]
        public int MonthId { get; set; }
        public string MonthName { get; set; }
        //Dodać poszczególne dni
        public Day Day1 { get; set; }
        public Day Day2 { get; set; }
        public Day Day3 { get; set; }
        public Day Day4 { get; set; }
        public Day Day5 { get; set; }
        public Day Day6 { get; set; }
        public Day Day7 { get; set; }
        public Day Day8 { get; set; }
        public Day Day9 { get; set; }
        public Day Day10 { get; set; }
        public Day Day11 { get; set; }
        public Day Day12 { get; set; }
        public Day Day13 { get; set; }
        public Day Day14 { get; set; }
        public Day Day15 { get; set; }
        public Day Day16 { get; set; }
        public Day Day17 { get; set; }
        public Day Day18 { get; set; }
        public Day Day19 { get; set; }
        public Day Day20 { get; set; }
        public Day Day21 { get; set; }
        public Day Day22 { get; set; }
        public Day Day23 { get; set; }
        public Day Day24 { get; set; }
        public Day Day25 { get; set; }
        public Day Day26 { get; set; }
        public Day Day27 { get; set; }
        public Day Day28 { get; set; }
        public Day Day29 { get; set; }
        public Day Day30 { get; set; }
        public Day Day31 { get; set; }

    }
}
