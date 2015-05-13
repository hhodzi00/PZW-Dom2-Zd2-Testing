using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Date_Project2;

namespace Testing_Date_Project2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Date date1 = new Date(1,1,1999);
            Assert.AreEqual(date1.day, 1, "Wrong day in date!");
            Assert.AreEqual(date1.month, 1, "Wrong month in date!");
            Assert.AreEqual(date1.year, 1999, "Wrong year in date!");

        }

        [TestMethod]
        public void TestLeapYear()
        {
            Date date1 = new Date(1,2,2000);
            Assert.AreEqual(date1.isLeapYear(2000), true, "Leap year check wrong!");
            
        }

        [TestMethod]
        public void TestLeapYearFebruary()
        {
            Date date1 = new Date(2, 2, 2004);
            Assert.AreEqual(date1.getNumberOfRemaingDaysInMonth(2, 2, 2004), 27, "February length is wrong!");

        }

        [TestMethod]
        public void MonthNameCheck ()
        { 
            Date date2 = new Date(1,3,2012);
            string month = "March";
            Assert.AreEqual(date2.getMonthName(3), month, "wrong MonthName check!");     
   
        }

        [TestMethod]
        public void WrongMonthNameTest()
        {
            Date date2 = new Date(1, 23, 2012);
            string month = "Error";
            Assert.AreEqual(date2.getMonthName(23), month, "wrong MonthName check!");
        }

        [TestMethod]
        public void NumberOfRemaingDaysInMonth()
        {
            Date date3 = new Date(10, 3, 1993);
            Assert.AreEqual(date3.getNumberOfRemaingDaysInMonth(10, 3, 1993), 21, "Error in Remaining day Calculation");
                
        }




    }
}
