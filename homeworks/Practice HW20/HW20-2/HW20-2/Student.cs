namespace HW20_2
{
    internal class Student
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private double AverageScore { get; set; }


        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }


        public int _Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 1) Console.WriteLine("Возраст не может быть отрицательным");
                else Age = value;
            }
        }

        public double _AverageScore
        {
            get
            {
                return AverageScore;
            }
            set
            {
                if (value < 1 || value > 100) Console.WriteLine("Средний балл должен быть в диапазоне от 0 до 100");
                else AverageScore = value;
            }
        }


        //public Student(string name, int age, double averageScore)
        //{
        //    Name = name;
        //    Age = age;
        //    AverageScore = averageScore;
        //}

        public void ShowInfo() => Console.WriteLine($"Имя: {Name}, Возраст {Age}, Средний балл {AverageScore}");

    }
}
