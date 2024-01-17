namespace Practice_HW18
{
    public class Customer : BaseEntity
    {
        public string? City { get; set; }
        public string? Region { get; set; }
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public override int ID { get; set; } 
        //protected private int CustomerID { get; set; }
        protected private string? CustomerName { get; set; }
        protected private string? PhoneNumber { get; set; }
        protected private string? Address { get; set; }


        protected void SetCustomer()
        {
            ID = 1;
            CustomerName = "Bakha";
            PhoneNumber = "992928650046";
            Address = " Z.P. Khojaev 4";
            City = "Khujand";
            Region = "Sogd";
            PostalCode = 735700;
            Country = "Tajikistan";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            if(IsDeleted == true)
            {
                Delete();
            }
        }

        //public Customer(int customerId, string customerName, string phoneNumber, string? address)
        //{
        //    CustomerId = customerId;
        //    CustomerName = customerName;
        //    PhoneNumber = phoneNumber;
        //    Address = address;
        //}

        //public void GetInfo()
        //{
        //    Console.WriteLine($"Customer Info: CustomerID -> {CustomerId} | Custoner Name -> {CustomerName} | " +
        //       $"Phone number -> {PhoneNumber} | Adress -> {Address} | City -> {City} | Region -> {Region} | " +
        //       $"Postal code -> {PostalCode} |  Country -> {Country}");
        //}
        //public Customer(string city, string region, int postalCode, string country) : base(int customerId, string customerName, string phoneNumber, string ? address )
        //{

        //    City = city;
        //    Region = region;
        //    PostalCode = postalCode;
        //    Country = country;
        //}

        //public void GetInfo()
        //{
        //    Console.WriteLine($"Customer Info: CustomerID -> {CustomerId} Custoner Name -> {CustomerName}" +
        //        $"Phone number -> {PhoneNumber} Adress -> {Address} City -> {City} Region -> {Region}" +
        //        $"Postal code -> {PostalCode} Country -> {Country}");
        //}


    }
}
