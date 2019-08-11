using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{
    class AccountGenerator
    {
        public static void AccountCreated(Person user)
        {
            Console.WriteLine($"your first name is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
