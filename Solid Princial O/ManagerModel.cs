using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princial_O
{
    public class ManagerModel : IApplicatntModel
    {
        public IAccounts AccountCreate { set; get; } = new ManagerAccount();

        public string FirstName { set; get; }

        public string LastName { set; get; }
    }
}
