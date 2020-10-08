using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Runner
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("введите количество студентов");
            int colStudent = int.Parse(Console.ReadLine());
            Student[] students = new Student[colStudent];
            SetStudendsData(marks, students);
            Console.Clear();
            while (true)
            {
                Menu(students);
                Console.WriteLine("-----------------------------------");
            }
            
        }

        private static void Menu(Student[] students)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1-вывод всех студентов и их инфу");
            Console.WriteLine("2-вывести инфу студента по фамилии");
            Console.WriteLine("3-вывод всех студентов из одной группы");
            Console.WriteLine("4-вывести студентов у которых средний бал за сессию больше чем критерий");
            Console.WriteLine("5-вывести студентов у кого три или более несданных дисциплин");
            Console.WriteLine("6-закрыть программу"); 
            ChoicePointMenu(students);
        }

        private static void ChoicePointMenu(Student[] students)
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: PrintAllStudents(students);break;
                case 2: FindStudent(students);break;
                case 3: PrintStudentForGroup(students);break;
                case 4: InfoSession(students);break;
                case 5: CandidateForDeduction(students);break;
                case 6: Environment.Exit(0);break;
                default: Console.WriteLine("Такого выбора нет, попробуйте еще");break;
            }
        }

        private static void SetStudendsData(int[] marks, Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"данные студента{i + 1}");
                students[i] = new Student();
                Console.WriteLine("Введите имя студета");
                students[i].FirstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию студета");
                students[i].SureName = Console.ReadLine();
                Console.WriteLine("Введите группу студета");
                students[i].Group = Console.ReadLine();
                Console.WriteLine("Введите оценки за сессию");
                students[i].Marks = marks;
                Console.WriteLine("----------------------------------");

            }
        }

        static void InfoSession(Student[] students) 
        {
            Console.WriteLine("Введите китерий среднего балла за сессию");
            double ball = double.Parse(Console.ReadLine());
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].InfoSession(ball));
            }
        }

        static void PrintAllStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void FindStudent(Student[] students)
        {
            Console.WriteLine("введите фамилию студента");
            string surName = Console.ReadLine();
            bool flag = false;
            foreach (var student in students)
            {
               if(student.FindStudent(surName))
                {
                    flag = true;
                    Console.WriteLine(student);
                    break;
                }
            }
            if(!flag)
                Console.WriteLine($"Студента с фамилией {surName} нет");
        }
        static void PrintStudentForGroup(Student[] students)
        {
            Console.WriteLine("введите желаемую группу");
            string group = Console.ReadLine();
            bool flag = false;
            foreach (var student in students)
            {
               if(student.StudentsForGroup(group))
                {
                    flag = true;
                    Console.WriteLine(student);
                }
            }
            if(!flag)
                Console.WriteLine($"В вашем УО нет группы {group}");
        }

        static void CandidateForDeduction(Student[] students)
        {
            foreach (var student in students)
            {
                if (student.Condidate())
                    Console.WriteLine(student);
            }
        }
    }
}
