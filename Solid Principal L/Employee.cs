using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_L
{
    public class Employee : BaseEmployee, Imanaged
    {
        public IEmployee Manager { set; get; } = null;
        public void AssignManger(Imanager manager)
        {
            Manager = manager;
        }
    }
}
