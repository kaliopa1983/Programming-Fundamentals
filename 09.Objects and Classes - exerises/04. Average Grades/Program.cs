using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Average_Grades
{

    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {

                Student student = new Student();
                string[] inputArguments = Console.ReadLine().Split(' ');

                student.Name = inputArguments[0];

                student.Grades = inputArguments.Skip(1).Select(double.Parse).ToList();

                students.Add(student);

            }
            students
               .Where(s => s.Average >= 5.00)
               .OrderBy(s => s.Name)
               .ThenByDescending(s => s.Average)
               .ToList()
               .ForEach(student => Console.WriteLine($"{student.Name} -> {student.Average:F2}"));






        }
    }
    class Student
    {

        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average => Grades.Average();
    }
}