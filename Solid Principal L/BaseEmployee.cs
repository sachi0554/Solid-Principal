using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_L
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public virtual void CalculatePerHourRate(int rate)
        {
            decimal baseamount = 12.7M;
            Salary = baseamount + (rate * 2);

        }
    }
}
