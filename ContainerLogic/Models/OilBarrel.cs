using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public class OilBarrel : Container
    {
        private int minLimit = 0;
        private int maxLimit = 159;

        public OilBarrel()
        {
            base.Capacity = maxLimit;
            base.Content = 0;
            base.IgnoreOverflow = false;
        }
        public OilBarrel(int content)
        {
            base.Capacity = maxLimit;
            base.Content = content.Limit(0, maxLimit);
            base.IgnoreOverflow = false;
        }
    }
}
