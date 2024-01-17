using System.Diagnostics.Metrics;
using System.Net;

namespace Practice_HW18
{
    public class GetProductInfo : Product
    {
        public void BaseCreateProduct()
        {
            SetProduct();
        }

        public void ShowProductInfo()
        {
            Console.WriteLine($"Product Info: ProductID -> {ID} | Product Name -> {ProductName} | " +
               $"Description -> {Description} | Product Category ID -> {ProductCategoryID} | Price -> {Price} | CreatedAt -> {CreatedAt} | " +
               $"UpdatedAt -> {UpdatedAt}");
        }
    }
}
