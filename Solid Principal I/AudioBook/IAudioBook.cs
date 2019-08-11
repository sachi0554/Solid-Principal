using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public interface IAudioBook:ILibraryItem 
    {
        int RuntimeinMinutes { set; get; }
    }
}
