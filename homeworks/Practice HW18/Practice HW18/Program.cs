namespace Practice_HW18
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetCutomerInfo getCutomerInfo = new GetCutomerInfo();
            getCutomerInfo.BaseCreateCustomer();
            getCutomerInfo.ShowCustomerInfo();
            Console.WriteLine();
            GetProductInfo getProductInfo = new GetProductInfo();
            getProductInfo.BaseCreateProduct();
            getProductInfo.ShowProductInfo();



        }
    }
}
