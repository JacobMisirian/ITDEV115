// Written by Jacob Misirian

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Info
    {
        public string Name { get { return name; } set { name = value; } }
        private string name = "Jacob Misirian";
        public string Course { get { return course; } set { course = value; } }
        private string course = "ITDEV115";
        public string AssignmentName { get { return assignmentName; } set { assignmentName = value; } }
        private string assignmentName = "TicTacToe";
        public string Date { get { return DateTime.Now.ToString(); } }

        public override string ToString()
        {
            return string.Format("Info:\nName={0},\nCourse={1},\nAssignmentName={2},\nDate={3}", Name, Course, AssignmentName, Date);
        }
    }
}
