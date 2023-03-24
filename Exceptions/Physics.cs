using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class Physics
    {
        public static double Speed(double distance, double time)
        {
            if (time is 0) throw new ArgumentException("Speed must be calculated in a timeframe that is greater than zero.");
            return distance / time;
        }
    }
}
