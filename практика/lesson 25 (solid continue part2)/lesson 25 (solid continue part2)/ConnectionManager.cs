using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_25__solid_continue_part2_
{
    public sealed class ConnectionManager
    {
        public void Connect(string url)
        {
            Console.WriteLine($"Connected to {url}"); // знак $ - интерполяция строк
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnected!");
        }

    }
}
