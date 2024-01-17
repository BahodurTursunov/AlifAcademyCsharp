using System.Xml.Linq;

namespace HW20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new()
            {
                _Name = "Abdu",
                _Age = -1,
                _AverageScore = -1
            };
            student.ShowInfo();

            Console.WriteLine();

            Student student2 = new()
            {
                _Name = "Alijon",
                _Age = 22,
                _AverageScore = 100
            };
            student2.ShowInfo();
        }
    }
}
