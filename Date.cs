using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesComp
{
    public class Date : IComparable<Date>
    {
        private int year, month, day;
        private int[] daysMonth = { 0, 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private bool leap;

        public Date(int month, int day, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }
        public int Year
        {
            get { return year; }
            set
            {
                //checks to see if user entered 2 digit value for year, makes necessary conversion 
                if (value < 100)
                {
                    year = value + 2000;


                }   //checks to see if value is within range - if not assigns 2001 to year                    
                else if (value >= 1800 && value <= 2200)
                {
                    year = value;
                }
                else
                {
                    //WriteLine($"Year {value} is invalid, using 2001");
                    year = 2001;
                }

                Leap = false; //calls setter, which calculates correct bool value 
            }
        }

        //overloaded + operator
        public static Date operator +(Date a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                a.AddDay();
            }
            return a;
        }


        //increments day, increments month/year if necessary
        public void AddDay()
        {

            if (Day == daysMonth[Month])
            {
                Day++;
                Month++;
                if (Month == 1)
                {
                    Year++;
                }

            }
            else { Day++; }




        }

        public int CompareTo(Date other)
        {
            if (this.Year > other.Year)
            {
                return 1;
            }
            else if (this.Year < other.Year)
            {
                return -1;
            }
            else if (this.Year == other.Year)
            {
                if (this.Month > other.Month)
                {
                    return 1;
                }
                else if (this.Month < other.Month)
                {
                    return -1;
                }
                else if (this.Month == other.Month)
                {
                    if (this.Day > other.Day)
                    {
                        return 1;
                    }
                    else if (this.Day < other.Day)
                    {
                        return -1;
                    }

                }
            }

            return 0;
        }

        //checks if it is a leap year
        public bool Leap
        {
            get { return leap; }
            set
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    leap = true;
                    daysMonth[2] = 29;
                }
                else
                {
                    leap = false;
                    daysMonth[2] = 28;
                }

            }
        }

        //property for month, set validates input
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    //WriteLine("Month is out of range, using 1 (January)");
                    month = 1;
                }
            }
        }

        //property for day, set validates input
        public int Day
        {
            get { return day; }
            set
            {


                if (value >= 1 && value <= daysMonth[Month])
                {
                    day = value;
                }
                else
                {
                    //WriteLine("Day is out of bounds, using 1");
                    day = 1;
                }
            }
        }
    }
}
