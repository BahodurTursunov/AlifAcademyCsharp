using System.Net.Http.Headers;

namespace HW14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Product1 = (ProductId: 1, ProductName: "Headphone", Price: 99, Count: 100);
            var Product2 = (ProductId: 2, ProductName: "Keyboard", Price: 199, Count: 60);
            var Product3 = (ProductId: 3, ProductName: "Macbook", Price: 99, Count: 10);

            void TotalCount()
            {
                int res = Product1.Price * Product1.Count;
                Console.WriteLine($"ProductId {Product1.ProductId}, ProductName {Product1.ProductName}, Price {Product1.Price}, Count {Product1.Count}" + res);
            }

            TotalCount();
            //void Print()
            //{
            //}
        }

    }
}
}
