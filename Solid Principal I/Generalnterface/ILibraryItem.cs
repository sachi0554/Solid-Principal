using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public interface ILibraryItem
    {
        int Library_ID  { get; set; }
        string Title { get; set; }
    }
}
