using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_L
{
    public class CEO :BaseEmployee ,Imanager
    {
        public override void CalculatePerHourRate(int rate)
        {
            decimal baseamount = 17.6M;
            Salary = baseamount + (rate * 4);

        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Performance review method");
        }
   
    }
}
