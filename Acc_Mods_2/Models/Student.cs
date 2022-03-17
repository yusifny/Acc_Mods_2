using System;
using System.Collections.Generic;
using System.Text;

namespace Acc_Mods_2.Models
{
    internal class Student : Person
    {
        private double Point;

        public double point
        {
            get
            {
                return Point;
            }
            set
            {
                if (value > 0 && value <= 100)
                    Point = value;
                else
                    Console.WriteLine("Select point average 1-100");
            }

        }



        public Student(double Point)
        {
            this.Point = Point;
        }



        public Student()
        {

        }
    }
}
