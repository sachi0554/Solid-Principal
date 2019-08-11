using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; } = null;
        public decimal salary { get; set; }
        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseamount = 12.50M;
            salary = baseamount + (rank * 2);
        }
    }
}
