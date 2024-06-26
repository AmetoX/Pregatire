using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    internal class Date
    {
        private int year, month, day;
        public Date() 
        {
            day = 1;
            month = 1;
            year = 1970;
        }

        public Date (int year, int month, int day)
        {
            if (isValid(year, month, day))
            {
                this.year = year;
                this.month = month;
                this.day = day;
            }
            else
            {
                throw new ArgumentException("Invalid date");
            }
        }

        public bool isValid(int year, int month, int day)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Date d1, Date d2)
        {
            return (d1.day == d2.day) && (d1.month == d2.month) && (d1.year == d2.year);
        }

        public static bool operator !=(Date d1, Date d2)
        {
            return !(d1 == d2);
        }
            
        public static bool operator >(Date d1, Date d2)
        {
            if(d1.year > d2.year)
            {
                return true;
            }
            if(d1.year == d2.year && d1.month > d2.month)
            {
                return true;
            }
            if(d1.month == d2.month && d1.day > d2.day)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Date d1, Date d2)
        {
            return !(d1 > d2);
        }

        public static bool operator >=(Date d1, Date d2)
        {
            return d1 > d2 || d1 == d2;
        }

        public static bool operator <=(Date d1, Date d2)
        {
            return d1<= d2 || d1 == d2;
        }

        public static Date operator -(Date d1, Date d2)
        {
            Date newDate = new Date();
            newDate.year = d1.year - d2.year;
            newDate.month = d1.month - d2.month;
            newDate.day = d1.day - d2.day;

            if (newDate.day > DateTime.DaysInMonth(newDate.year, newDate.month))
            {
                newDate.day = 1;
                newDate.month++;
            }
            if (newDate.month > 12)
            {
                newDate.month = 1;
                newDate.year++;
            }
            return newDate;
        }

        public override string ToString()
        {
            return $"{year}:{month}:{day}";
        }
    }
}
