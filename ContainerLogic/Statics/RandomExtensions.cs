using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Statics
{
    public static class RandomExtensions
    {
        public static bool NextBool(this Random random)
        {
            if (random.Next(0, 2) == 1)
                return false;
            return true;
        }
    }
}
