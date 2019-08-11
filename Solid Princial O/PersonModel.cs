using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princial_O
{
    public class PersonModel : IApplicatntModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountCreate { get; set; } = new Accounts();
    }
}
