using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public enum RainBarrelSize
    {
        small = 80, medium = 100, large = 120
    }
    public class RainBarrel : Container
    {
        public RainBarrel(RainBarrelSize capacity)
        {
            base.Capacity = (int)capacity;
        }
        public RainBarrel(RainBarrelSize capacity, int content)
        {
            base.Capacity = (int)capacity;
            base.Content = content;
        }
        public RainBarrel(RainBarrelSize capacity, int content, bool ignoreOverflow)
        {
            base.Capacity = (int)capacity;
            base.Content = content;
            base.ignoreOverflow = ignoreOverflow;
        }
    }
}
