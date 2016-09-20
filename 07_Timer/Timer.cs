using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
    class Timer
    {
        public int Seconds = 0;

        public override String ToString()
        {
            return SecondsToTime(Seconds);
        }

        public String Padded(int value)
        {
            return value.ToString( "00" );
        }

        private String SecondsToTime(int value)
        {
            return ParseTimer( ParseHours(value), ParseMinutes(value), ParseSeconds(value) );
        }

        private int ParseHours(int value)
        {
            return (value / 60) / 60;
        }

        private int ParseMinutes(int value)
        {
            return (value / 60) - (hour * 60);
        }

        private int ParseSeconds(int value)
        {
            return value - (hour * 60 * 60) - (minute * 60);
        }

        private String ParseTimer(int hour, int minute, int second)
        {
            return  Padded(hour) + ":" + Padded(minute) + ":" + Padded(second);
        }
    }
}
