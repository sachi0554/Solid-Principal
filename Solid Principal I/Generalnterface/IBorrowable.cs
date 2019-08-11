using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public interface IBorrowable
    {
        DateTime BorrrowDate { set; get; }
        string Borrower { set; get; }
        int CheckoutDurationinDays { set; get; }
        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
         

    }
}
