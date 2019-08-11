using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    public class Logger:ILogger
    {
        public void log(string msg)
        {
            Console.WriteLine($"write to console { msg}");

        }
    }
}
