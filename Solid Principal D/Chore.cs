using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _Sender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool isCOmpleted { get; private set; }

        public Chore(ILogger logger , IMessageSender Sender)
        {
            _logger = logger;
            _Sender = Sender;
        }

        public void  PerformeWork(double hours)
        {
            HoursWorked += hours;
            _logger.log($"performace work on {ChoreName}");
        }

        public  void ComplteChore()
        {
            isCOmpleted = true;
            _logger.log($"Completed {ChoreName}");
            _Sender.SendMessage(Owner, $"the chore {ChoreName} is Completed");

        }



    }
}
