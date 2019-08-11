using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princial_O
{

    /*
      SOLID O open for extended close for modification 

    */
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicatntModel> applicants = new List<IApplicatntModel>
            {
                new PersonModel {FirstName= "sachi", LastName="upadhyay" },
                new ManagerModel {FirstName= "koko", LastName="michle"},
                new ExcuityModel {FirstName= "aditi", LastName="dube"}
            };
            List<Employee> employee = new List<Employee>() ;
            foreach (var person in applicants)
            {
                employee.Add(person.AccountCreate.create(person));
            }
            foreach (var emp in employee)
            {
                Console.WriteLine($"{emp.FirstName}{emp.LastName}:{emp.EmailAddress}: ismanager{emp.isManager}: isExcuity {emp.isExcuty}");
            }
            Console.ReadLine();
        }
    }
}
