using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW18
{
    public class Product : BaseEntity
    {
        public override int ID { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public int ProductCategoryID { get; set;}
        public double Price { get; set; }

        protected void SetProduct()
        {
            ID = 1;
            ProductName = "Lenovo";
            Description = "Lenovo is a manufacturer of personal computers, smartphones, televisions, and wearable devices. Some of the company's earliest products included the KT8920 mainframe computer and a circuit board that allowed IBM-compatible personal computers to process Chinese characters.";
            ProductCategoryID = 2;
            Price = 999.9;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            if(IsDeleted)
            {
                IsDeleted = true;
            }
        }
    }
}
