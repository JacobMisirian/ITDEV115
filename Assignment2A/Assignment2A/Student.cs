// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2A
{
    public class Student
    {
        public int ID { get { return id; } }
        private int id;

        public string Name { get { return name; } }
        private string name;

        public double[] Hours { get { return hours; } }
        private double[] hours = new double[7];

        public Student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void EnterHours(int index, double value)
        {
            hours[index] = value;
        }

        public double GetHours(int index)
        {
            return hours[index];
        }

        public double GetNumberHours()
        {
            double res = 0;
            foreach (double hour in hours)
                res += hour;
            return res;
        }

        public double GetAverageHours()
        {
            return GetNumberHours() / hours.Length;
        }
    }
}