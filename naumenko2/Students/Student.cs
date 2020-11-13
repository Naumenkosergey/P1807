using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        string firstName;
        string sureName;
        string group;
        int[] marks = new int[5];

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
            }
        }
        public string SureName
        {
            get => sureName;
            set
            {
                sureName = value;
            }
        }
        public string Group
        {
            get => group;
            set
            {
                group = value;
            }
        }
        public int[] Marks
        {
            get
            {
                //foreach (var item in marks)
                //{
                //    Console.Write(item + "  ");
                //}
                return marks;
            }
            //set => marks = value;
            set
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("оценка по предмету № " + (i + 1));
                    marks[i] = int.Parse(Console.ReadLine());
                }

            }
        }

        public Student() { }

        public Student(string firstName, string surName, string group, int[] marks)
        {
            FirstName = firstName;
            SureName = surName;
            Group = group;
            Marks = marks;
        }

        private string PrintMarks()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in marks)
            {
                stringBuilder.Append(item).Append(" ");
            }
            return stringBuilder.ToString();
        }

        public double AverageSession()
        {
            int sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }
            return (double)sum / marks.Length;
        }

        public Student InfoSession(double kriteriy)
        {
            if (AverageSession() >= kriteriy)
                return this;
            else
                return null;
        }
        public bool FindStudent(string surname)
        {
            if (surname.ToLower().Equals(SureName.ToLower()))
            {
                return true;
            }
            else
                return false;

        }
        public bool StudentsForGroup(string group)
        {
            if (group.Equals(Group))
            {
                return true;
            }
            else
                return false;
        }

        public bool Condidate()
        {
            int count = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] <= 3)
                {
                    count++;
                }
            }
            if (count >= 3)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{SureName} | {firstName} | {Group} | {PrintMarks()}";
        }

    }
}
