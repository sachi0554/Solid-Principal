using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princial_O
{
    public class Accounts : IAccounts
    {
        public Employee create(IApplicatntModel person)
        {
            Employee output = new Employee();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@demo.com";
            return output;
        }
    }
}
