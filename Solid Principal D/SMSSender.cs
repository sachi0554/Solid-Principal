using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(IPerson person, string msg)
        {
            Console.WriteLine($"sms send to {person.PhoneNumber}");
        }
    }
}
