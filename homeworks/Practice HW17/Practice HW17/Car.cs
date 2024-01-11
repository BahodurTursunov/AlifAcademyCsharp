using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_HW17
{
    internal class Car : IVehicle
    {
        public double Speed { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Двигатель автомобиля запущен");
        }
    }
}
