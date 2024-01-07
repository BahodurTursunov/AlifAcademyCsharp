using System.Security.Cryptography.X509Certificates;

namespace HW14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Inventory = new[] (int ProductId, string ProductName, double Price, int Ostatok)
            {
                (1, "Laptop", 999.9, 10),
                (2, "Headphones", 99.9, 100),
                (3, "Keyboards", 199.9, 35),
            };

            Console.WriteLine("Inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine();
            }
        }

        public double CalcTotalCost(double price, int ostatok)
        {
            double TotalCost = price * ostatok;
            return TotalCost;
        }
        //TODO закончить с разбором кортежей
    } 
}
