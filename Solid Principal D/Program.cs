using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_D
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

                owner.FirstName = "Sachidannad";
                owner.LastName = "Upadhyay";
                owner.Email = "sachi@gmail.com";
                owner.PhoneNumber = "234242343";

            IChore chore = Factory.CreateChore();

                chore.ChoreName = "Shyami";
                chore.Owner = owner;

                chore.PerformeWork(3);
                chore.PerformeWork(1);
                chore.ComplteChore();

            Console.ReadLine();


        }
    }
}
