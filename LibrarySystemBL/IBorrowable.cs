using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBL
{
    public interface IBorrowable
    {
        public string BorrowerName { get; set; }
        public int BorrowerID { get; set; }

        public int checkoutindays {  get; set; }

        public DateTime checkin();
        public TimeSpan checkout();

        public DateTime getdue();
    }
}
