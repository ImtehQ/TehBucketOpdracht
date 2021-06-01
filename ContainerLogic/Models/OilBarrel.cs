using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public class OilBarrel : Container
    {
        public OilBarrel()
        {
            base.Capacity = 159;
        }
        public OilBarrel(int content)
        {
            base.Capacity = 159;
            base.Content = content;
        }
        public OilBarrel(int content, bool ignoreOverflow)
        {
            base.Capacity = 159;
            base.Content = content;
            base.ignoreOverflow = ignoreOverflow;
        }
    }
}
