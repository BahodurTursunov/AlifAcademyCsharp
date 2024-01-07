using System.Collections.Generic;
namespace HW14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Order = new[]
            {
                new { OrderId = 1, CustomerName = "Saint John", ProductName = "Mac 14 pro", Price = 2999 },
                new { OrderId = 2, CustomerName = "Sam Jack", ProductName = "Mac 13 pro", Price = 1999 },
                new { OrderId = 3, CustomerName = "Antony Bonderos", ProductName = "Mac 12 pro", Price = 999 }
            };

            Console.WriteLine("Orders:");
            foreach (var order in Order)
            {
                Console.WriteLine($"OrderId: {order.OrderId}, CustomerName: {order.CustomerName}, ProductName: {order.ProductName}, Price: {order.Price}");
            }
        }
    }
}
