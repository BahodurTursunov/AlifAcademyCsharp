using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_25__solid_continue_part2_
{
    public sealed class DataTransfer
    {
        public void Send(string content)
        {
            Console.WriteLine($"Content `{content}` send!");
        }
    }
}
