using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{
    class PersonValidater
    {
        public static bool ValidatePerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Message.validateErrorMessage(person.FirstName);
                Message.EndMessage();
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Message.validateErrorMessage(person.LastName);
                Message.EndMessage();
                return false;
            }
            return true;
        }
    }
}
