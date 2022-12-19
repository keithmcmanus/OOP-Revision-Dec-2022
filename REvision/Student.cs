using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REvision
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Subject> Subjects { get; set; }

        private string GetGradeList()
        {
            string s = "";

            foreach (var item in Subjects)
            {
                s += item.Result;
            }

            return s;
        }

        private string GetTopThreeGrades()
        {
            string s = GetGradeList();
            char[] grades = s.ToCharArray();
            Array.Sort(grades);
            string returnString = "";
            foreach (char character in grades)
            {
                returnString += character;
            }
            returnString = returnString.Substring(0, 3);
            return returnString;
        }

        public override string ToString()
        {
            return $"{Name} ({Age}) - {GetGradeList()} - {GetTopThreeGrades()}";
        }

        public int CompareTo(Student other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
