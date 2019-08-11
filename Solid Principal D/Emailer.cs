using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string msg)
        {
            Console.WriteLine($" email message has been sent to {person.Email}"); 
        }
    }
}
