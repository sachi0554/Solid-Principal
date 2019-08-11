using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal_I.classLibrary
{
    public class DVD : IBorrowableDVD
    {
        public List<string> Actors { set; get; }
        public string Borrower { set; get; }

        public DateTime BorrrowDate { set; get; }
        public int CheckoutDurationinDays { set; get; }
        public int Library_ID { set; get; }

        public int RuntimeinMinutes { set; get; }

        public string Title { set; get; }
        public void CheckIn()
        {
            Borrower = "" ;
            //asdas
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
