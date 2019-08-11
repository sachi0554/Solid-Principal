using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLog(), CreateSendMessageSender());
        }
        public static ILogger CreateLog()
        {
            return new Logger();
        }
        public static IMessageSender CreateSendMessageSender()
        {
            return new SMSSender();
        }

    }
}
