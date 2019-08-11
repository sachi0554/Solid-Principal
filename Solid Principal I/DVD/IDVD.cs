using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public interface IDVD :ILibraryItem
    {
        List<string> Actors { set; get; }
        int RuntimeinMinutes { set; get; }
    }
}
