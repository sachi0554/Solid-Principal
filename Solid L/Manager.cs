using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public class Manager :Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseamount = 19.75M;
            salary = baseamount + (rank * 4);
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm retriveing a direct reports' performance ");
        }
    }
}
