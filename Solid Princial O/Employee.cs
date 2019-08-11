using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princial_O
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool isManager { get; set; } = false;
        public bool isExcuty { set; get; } = false;

    }
}
