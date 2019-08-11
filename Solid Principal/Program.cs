using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{

    /*
     
      this is demo for SRP single responsbilty in SOLID principal 

    */
    class Program
    {
        static void Main(string[] args)
        {
            Message.WelcomeMessage();
            Person user = PersonDataCapture.Capture();
            bool isvalid = PersonValidater.ValidatePerson(user);
            if(isvalid ==false)
            {
                Message.EndMessage();
                return;
            }
            AccountGenerator.AccountCreated(user);
            Message.EndMessage();

        }
    }
}
