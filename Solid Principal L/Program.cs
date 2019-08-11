using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Imanager account = new CEO();
            account.LastName = "EMMA";
            account.LastName = "shiva";
            account.CalculatePerHourRate(4);
            Imanaged emp = new Employee();
            emp.FirstName = "Dayna";
            emp.LastName = "Michel";
            emp.AssignManger(account);
            emp.CalculatePerHourRate(2);
            Console.WriteLine($"{emp.FirstName}salary  is ${emp.Salary}/hour");
            Console.ReadLine();

        }
    }
}
