// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2A
{
    public class StudentUI
    {
        private string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private Student student;

        public void MainMethod()
        {
            student = new Student(promptForString("Enter your name: "), promptForInteger("Enter the ID: "));
            FillHours();
            DisplayData();
            DisplayAverage();
        }

        public void FillHours()
        {
            for (int i = 0; i < days.Length; i++)
                student.EnterHours(i, promptForDouble("Enter the hours for: " + days[i] + " "));
        }

        public void DisplayData()
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Id: " + student.ID);
            for (int i = 0; i < days.Length; i++)
                Console.WriteLine("Hours studied on " + days[i] + ": " + student.GetHours(i));
        }

        public void DisplayAverage()
        {
            Console.WriteLine("Average hours: " + student.GetAverageHours());
        }

        private string promptForString(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private double promptForDouble(string prompt = "")
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            double d = 0;
            double.TryParse(input, out d);

            return d;
        }

        private int promptForInteger(string prompt = "")
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            int i = 0;
            int.TryParse(input, out i);

            return i;
        }
    }
}
