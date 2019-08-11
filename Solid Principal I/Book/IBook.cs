using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public interface IBook: ILibraryItem
    {
        string Author { set; get; }
        int Pages { set; get; }
    }
}
