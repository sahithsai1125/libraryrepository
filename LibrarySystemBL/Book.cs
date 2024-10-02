using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBL
{
    public class Book : IBorrowable,ILibraryitem
    {
        
        public int LibraryitemID { get; set; }
        public string name { get; set; }

        public string BorrowerName { get; set; }
        public int BorrowerID { get; set; }

        public int checkoutindays { get; set; }

        public TimeSpan checkoutduration { get; set; }
        public string Author {  get; set; }
        public int noofpages {  get; set; }
        




        public Book()
        {
            LibraryitemID = 1011;
            name = "harry poter";
            BorrowerName = "sai";
            BorrowerID = 1125;
            checkoutindays = 15;
            Author = "james";
            noofpages = 900;

        }
        public DateTime checkin()
        {
            
            return DateTime.Now;

        }
        public TimeSpan checkout()
        {
            TimeSpan duration = new TimeSpan(checkoutindays, 0, 0, 0);
            DateTime present = checkin().Add(duration);
            TimeSpan checkoutduration = present - checkin();
            return checkoutduration;
        }

        public DateTime getdue()
        {
            TimeSpan duration = new TimeSpan(checkoutindays, 0, 0, 0);
            DateTime due = checkin().Add(duration);
            return due;

        }

    }
}
