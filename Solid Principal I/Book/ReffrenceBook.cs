using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public class ReffrenceBook : IBook
    {
        public string Author { set; get; }

        public int Library_ID { set; get; }

        public int Pages { set; get; }

        public string Title { set; get; }
    }
}
