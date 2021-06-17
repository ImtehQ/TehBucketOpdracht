using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend
{
    public static class Limits
    {
        public static int Limit(this int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
    }
}
