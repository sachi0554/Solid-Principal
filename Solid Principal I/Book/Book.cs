using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    class Book : IBorrowableBook
    {
        public string Author { set; get; }
        public string Borrower { set; get; }

        public DateTime BorrrowDate { set; get; }

        public int CheckoutDurationinDays { set; get; }

        public int Library_ID { set; get; }
        public int Pages { set; get; }
        public string Title { set; get; }

        public void CheckIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrrowDate.AddDays(CheckoutDurationinDays);
        }
    }
}
