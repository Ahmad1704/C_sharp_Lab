using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Duration
    {
        public int second { get; set; }
        public int minute { get; set; }
        public int hour { get; set; }

        public override string ToString()
        {
            return $"  hour: {hour},minute: {minute},second: {second}";
        }

        public Duration()
        {
            second = 0;
            minute = 0;
            hour = 0;
        }
        public Duration( int h , int min , int sec)
        {
            second = sec;
            minute = min;
            hour = h;
        }
        public Duration(int totalSeconds)
        {
            hour = totalSeconds / 3600;
            totalSeconds %= 3600;
            minute = totalSeconds / 60;
            second = totalSeconds % 60;
        }
        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration other = (Duration)obj;
            return second == other.second && minute == other.minute && hour ==other.hour;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(second, minute , hour);
        }

        public static bool operator == (Duration left, Duration right)
        {
            return left.second == right.second && left.minute == right.minute && right.hour==left.hour ;
        }

        public static bool operator !=(Duration left, Duration right)
        {
            return left.second != right.second || left.minute != right.minute;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.hour + d2.hour, d1.minute + d2.minute, d1.second + d2.second);
        }
        public static Duration operator +(Duration d, int AddtoSecond)
        {
            return new Duration(d.hour, d.minute, d.second + AddtoSecond);
        }
        public static Duration operator +(int AddtoSecond, Duration d)
        {
            return new Duration(d.hour, d.minute,AddtoSecond + d.second);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.hour, d.minute + 1, d.second);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.hour, d.minute - 1, d.second);
        }
        public static Duration operator -(Duration d)
        {
            return new Duration(-d.hour, -d.minute, -d.second);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.hour * 3600 + d1.minute * 60 + d1.second) >
                   (d2.hour * 3600 + d2.minute * 60 + d2.second);
        }
        public static bool operator < (Duration d1, Duration d2)
        {
            return (d1.hour * 3600 + d1.minute * 60 + d1.second) <
                  (d2.hour * 3600 + d2.minute * 60 + d2.second);
        }
        public static bool operator <= (Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static bool operator >= (Duration d1, Duration d2)
        {
            return !(d1 < d2);
        }

        public static bool operator true(Duration d)
        {
            return d.hour != 0 || d.minute != 0 || d.second != 0;
        }
        public static bool operator false(Duration d)
        {
            return d.hour == 0 && d.minute == 0 && d.second == 0;
        }


        public static explicit operator DateTime(Duration d)
        {
            
            DateTime referenceDate = DateTime.Today;
            return referenceDate
                .AddHours(d.hour)
                .AddMinutes(d.minute)
                .AddSeconds(d.second);
        }
    }
}
