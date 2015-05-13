using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Project2
{
    public class Date
    {
        public int day, month, year;



        public Date(int x, int y, int z)
        {
            this.day = x;
            this.month = y;
            this.year = z;
        }

        public string getMonthName(int x)
        {
            string name;

            switch (x)
            {
                case (1):
                    {
                        name = "January";
                        break;
                    }

                case (2):
                    {
                        name = "February";
                        break;
                    }

                case (3):
                    {
                        name = "March";
                        break;
                    }

                case (4):
                    {
                        name = "April";
                        break;
                    }

                case (5):
                    {
                        name = "May";
                        break;
                    }

                case (6):
                    {
                        name = "June";
                        break;
                    }

                case (7):
                    {
                        name = "July";
                        break;
                    }

                case (8):
                    {
                        name = "August";
                        break;
                    }

                case (9):
                    {
                        name = "September";
                        break;
                    }

                case (10):
                    {
                        name = "October";
                        break;
                    }

                case (11):
                    {
                        name = "November";
                        break;
                    }

                case (12):
                    {
                        name = "December";
                        break;
                    }

                default:
                    {
                        name = "Error";
                        break;
                    }
            }

            return name;

        }


        public bool isLeapYear(int x)
        {
            if (x % 400 == 0 || (x % 4 == 0 && x % 100 != 0))
                return true;
            else
                return false;
        }


        public int getNumberOfRemaingDaysInMonth(int day, int month, int year)
        {
            int RemainingDays;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                RemainingDays = 31 - day;

            else if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (month == 2 && isLeapYear(year) == true)
                    RemainingDays = 29 - day;

                else if (month == 2 && isLeapYear(year) == false)
                    RemainingDays = 28 - day;

                else
                    RemainingDays = 30 - day;

            }

            else
                RemainingDays = -3;

            return RemainingDays;
        }





    }
}
