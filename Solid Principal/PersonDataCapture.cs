using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();
            Console.WriteLine("Enter your First Name");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last Name");
            user.LastName = Console.ReadLine();
            return user;

        }
    }
}
