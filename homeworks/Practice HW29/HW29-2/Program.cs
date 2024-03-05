using System.Collections;

namespace HW29_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = [new Student("Tom", 20), new Student("Bob", 30), new Student("Alex", 22)];

            ((Student)students[0]).AddGrade(90);
            ((Student)students[0]).AddGrade(85);
            ((Student)students[1]).AddGrade(75);
            ((Student)students[1]).AddGrade(80);
            ((Student)students[2]).AddGrade(95);
            ((Student)students[2]).AddGrade(88);

            foreach (Student student in students)
            {
                Console.WriteLine("Имя: " + student.Name);
                Console.WriteLine("Возраст: " + student.Age);
                Console.WriteLine("Средняя оценка: " + student.AverageGrade());
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ArrayList Grades { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Grades = new ArrayList();
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double AverageGrade()
        {
            double sum = 0;
            foreach(int grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }
    }
}
