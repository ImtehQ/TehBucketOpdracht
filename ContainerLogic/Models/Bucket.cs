using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public class Bucket : Container
    {
        private int minLimit = 10;
        private int maxLimit = 12;

        public Bucket(int capacity)
        {
            base.Capacity = capacity.Limit(minLimit, maxLimit);
            base.Content = 0;
        }
        public Bucket(int capacity, int content)
        {
            base.Capacity = capacity.Limit(minLimit, maxLimit);
            base.Content = content.Limit(0, maxLimit);
        }
        public Bucket(int capacity, int content, bool ignoreOverflow)
        {
            base.Capacity = capacity.Limit(minLimit, maxLimit);
            base.Content = content.Limit(0, maxLimit);
            base.IgnoreOverflow = ignoreOverflow;
        }
    }
}
