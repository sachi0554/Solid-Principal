using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_L
{
    public interface Imanaged:IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManger(Imanager manager);
    }
}
