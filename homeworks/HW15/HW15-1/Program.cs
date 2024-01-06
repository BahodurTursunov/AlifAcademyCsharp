namespace HW15_1
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageScore { get; set; }
        private static int TotalStudents { get; set; }

        public Student(string name, int age, double averageScore)
        {
            Name = name;
            Age = age;
            AverageScore = averageScore;
            TotalStudents++;
        }

        static Student()
        {
            TotalStudents = 0;
        }

        public static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Average Score: {student.AverageScore}\n");
        }
        public static void PrintTotalStudent()
        {
            Console.WriteLine($"Total Students: {TotalStudents}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("John", 21, 70.3);
            Student.PrintStudentInfo(student1);

            Student student2 = new("Max", 22, 60.4);
            Student.PrintStudentInfo(student2);

            Student student3 = new("CJ", 19, 70.6);
            Student.PrintStudentInfo(student3);
            
            Student.PrintTotalStudent();
        }
    }
}
