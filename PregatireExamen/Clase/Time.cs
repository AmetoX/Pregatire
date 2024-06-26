using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Clase
{
    internal class Time : IComparable<Time>
    {
        private int hour, minute, second;
        public Time() 
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            if (isValidTime(hour, minute, second))
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            else
            {
                throw new ArgumentException($"Ora invalida");
            }
        }

        private bool isValidTime(int hour, int minute , int second)
        {
            return (hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59) && (second >= 0 && second <= 59);
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.hour == t2.hour && t1.minute == t2.minute && t1.second == t2.second;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.hour < t2.hour)
            {
                return true;
            }
            if (t1.hour == t2.hour && t1.minute < t2.minute)
            {
                return true;
            }
            if (t1.hour == t2.hour && t1.minute == t2.minute && t1.second < t2.second)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t2 < t1;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1 > t2 || t1 == t2;
        }

        public static bool operator <= (Time t1, Time t2)
        {
            return t1 < t2 || t1 == t2;
        }

        public override string ToString()
        {
            return $"{hour}:{minute}:{second}";
        }

        public static Time operator +(Time t1, Time t2)
        {
            int newHour = t1.hour + t2.hour;
            int newMinute = t1.minute + t2.minute;
            int newSecond = t1.second + t2.second;

            if (newSecond >= 60)
            {
                newSecond -= 60;
                newMinute++;
            }

            if (newMinute >= 60)
            {
                newMinute -= 60;
                newHour++;
            }

            if (newHour >= 24)
            {
                newHour -= 24;
            }

            return new Time(newHour, newMinute, newSecond);
        }

        public int CompareTo(Time other)
        {
            if(this < other)
            {
                return -1;
            }
            if(this > other) 
            {
                return 1;
            }
            return 0;
        }
    }
}
