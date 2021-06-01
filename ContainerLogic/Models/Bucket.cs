using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public class Bucket : Container
    {
        private void Limits(int capacity)
        {
            if (capacity < 10)
            {
                base.Capacity = 10;
            }
            else if (capacity > 12)
            {
                base.Capacity = 12;
            }
        }

        public Bucket(int capacity)
        {
            Limits(capacity);
        }
        public Bucket(int capacity, int content)
        {
            Limits(capacity);
            base.Content = content;
        }
        public Bucket(int capacity, int content, bool ignoreOverflow)
        {
            Limits(capacity);
            base.Content = content;
            base.ignoreOverflow = ignoreOverflow;
        }
    }
}
