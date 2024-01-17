namespace Practice_HW18
{
    internal class GetCutomerInfo : Customer
    {
        //protected private int CustomerId { get; set; }
        //protected private string? CustomerName { get; set; }
        //protected private string? PhoneNumber { get; set; }
        //protected private string? Address { get; set; }
        //public string? City { get; set; }
        //public string? Region { get; set; }
        //public int PostalCode { get; set; }
        //public string? Country { get; set; }

        //public GetCutomerInfo(int customerId, string customerName, string phoneNumber, string? address, string city, string region, string postalCode, string country) 
        //    //: base(int customerId, string customerName, string phoneNumber, string address)
        //{
        //    CustomerId = customerId;
        //    CustomerName = customerName;
        //    PhoneNumber = phoneNumber;
        //    Address = address;
        //    City = city;
        //    Region = region;
        //    PostalCode = postalCode;
        //    Country = country;
        //}


        public void BaseCreateCustomer()
        {
            SetCustomer();
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine($"Customer Info: CustomerID -> {ID} | Custoner Name -> {CustomerName} | " +
               $"Phone number -> {PhoneNumber} | Adress -> {Address} | City -> {City} | Region -> {Region} | " +
               $"Postal code -> {PostalCode} |  Country -> {Country} | CreatedAt -> {CreatedAt} | UpdatedAt -> {UpdatedAt}");
        }
    }
}
