using LibrarySystemBL;
using System;
namespace LibraryitemTests
{
    [TestClass]
    public class UnitTest1
    {
        Book b = new Book();
        AudioBook ab= new AudioBook();  
        [TestMethod]
        public void TestMethod1()
        {
            Book b = new Book();
            DateTime expected= DateTime.Now;
            DateTime actual = b.checkin();
            Assert.IsTrue(Math.Abs((expected - actual).TotalMilliseconds) < 100, "Check-in time should be close to the current time.");

        }
        [TestMethod]
        public void TestMethod2()
        {  
            TimeSpan duration = new TimeSpan(b.checkoutindays, 0, 0, 0);
            DateTime present = b.checkin().Add(duration);
            TimeSpan checkoutduration = present - b.checkin();
            TimeSpan actual = b.checkout();
            Assert.IsTrue(Math.Abs((checkoutduration - actual).TotalSeconds) < 1, "Remaining checkout duration should be calculated correctly.");
        }

    
        [TestMethod]
        public void TestMethod3()
        {

            TimeSpan duration = new TimeSpan(b.checkoutindays, 0, 0, 0);
            DateTime due = b.checkin().Add(duration);
            DateTime actual = b.getdue();
            Assert.IsTrue(Math.Abs((due - actual).TotalSeconds) < 1, " checkout date should be calculated correctly.");


        }
        [TestMethod]
        public void TestMethod4()
        {
            
            DateTime expected = DateTime.Now;
            DateTime actual = ab.checkin();
            Assert.IsTrue(Math.Abs((expected - actual).TotalMilliseconds) < 100, "Check-in time should be close to the current time.");

        }
        [TestMethod]
        public void TestMethod5()
        {
            TimeSpan duration = new TimeSpan(ab.checkoutindays, 0, 0, 0);
            DateTime present = ab.checkin().Add(duration);
            TimeSpan checkoutduration = present - ab.checkin();
            TimeSpan actual = ab.checkout();

            //Assert.AreEqual(checkoutduration, actual);
            Assert.IsTrue(Math.Abs((checkoutduration - actual).TotalSeconds) < 1, "Remaining checkout duration should be calculated correctly.");
        }


        [TestMethod]
        public void TestMethod6()
        {

            TimeSpan duration = new TimeSpan(ab.checkoutindays, 0, 0, 0);
            DateTime due = ab.checkin().Add(duration);
            DateTime actual = ab.getdue();
            Assert.IsTrue(Math.Abs((due - actual).TotalSeconds) < 1, " checkout date should be calculated correctly.");


        }
    }
}