using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBL
{
    public class AudioBook : IBorrowable,ILibraryitem
    {

        public int LibraryitemID { get; set; }
        public string name { get; set; }

        public string BorrowerName { get; set; }
        public int BorrowerID { get; set; }

        public int checkoutindays { get; set; }

        public TimeSpan checkoutduration { get; set; }
        public string Author { get; set; }
        public int noofpages { get; set; }





        public AudioBook()
        {
            LibraryitemID = 1011;
            name = "Harry Poter Audio";
            BorrowerName = "Rebel";
            BorrowerID = 8500;
            checkoutindays = 25;
            Author = "jack";
            noofpages = 130;

        }
        public DateTime checkin()
        {
            DateTime indate = DateTime.Now;
            return indate;

        }
        public TimeSpan checkout()
        {
            DateTime present = checkin();
            TimeSpan duration = new TimeSpan(checkoutindays, 0, 0, 0);
            present = DateTime.Now.Add(duration);
            checkoutduration = present - checkin();
            return checkoutduration;
        }

        public DateTime getdue()
        {
            DateTime due = checkin();
            TimeSpan duration = new TimeSpan(checkoutindays, 0, 0, 0);
            due = DateTime.Now.Add(duration);
            return due;

        }
    }
}
