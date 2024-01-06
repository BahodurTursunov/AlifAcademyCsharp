using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_OOP__class_continue_
{
    public class Acount
    {
        //public decimal Amount { get; set; }

        //public static Acount operator ++(Acount acount)
        //{
        //    acount.Amount++;
        //    return new() { Amount = acount.Amount++ };
        //}

        public decimal[] Amount { get; set; }

        public static Acount operator --(Acount acc)
        {
            acc.Amount = { 1,2,3,4,5};
        }
    }
}
