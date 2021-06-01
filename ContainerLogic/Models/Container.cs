using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerBackend.Models
{
    public delegate void OnContainerOverflowDelegate(object sender, int overflowAmount);
    public delegate void OnContainerOverflowContainerDelegate(object sender, int overflowAmount, Container container);

    public enum ContentStatus
    {
        Empty, NotEmpty, Full
    }

    public abstract class Container
    {
        public event OnContainerOverflowDelegate OnContainerOverflow;
        public event OnContainerOverflowContainerDelegate OnContainerOverflowContainer;

        public int Id { get; set; }

        private int capacity;
        public int Capacity 
        {
            get { return capacity; }
            set 
            {
                capacity = value;
            }
        }

        private int content;
        public int Content
        {
            get { return content; }
            set
            {
                if (value > Capacity)
                {
                    content = Capacity;
                }
                else if(value < 0)
                {
                    content = 0;
                }
                else
                {
                    content = value;
                }
            }
        }

        internal bool ignoreOverflow;

        public void Empty()
        {
            if(Content == 0)
            {
                //Already empty!
            }

            Content = 0;
        }

        public int Empty(int amount)
        {
            if (Content <= amount)
            {
                Content -= amount;
            }
            else
            {
                //Underflow?!
                int remaining = amount - Content;
                Content = 0;
                return remaining;
            }
            return 0;
        }

        public bool Fill(int amount, bool overwriteOverflow = false)
        {
            int fillLimit = FillLimit();
            int overflowAmount = amount - fillLimit;

            if (amount > fillLimit)
            {
                //Overflow detected
                if (overwriteOverflow == false && ignoreOverflow == false)
                {
                    OnContainerOverflow?.Invoke(this, overflowAmount);
                    return false;
                }
                else
                {
                    Content += fillLimit;
                    return true;
                }
            }
            else
            {
                Content += amount;
                return true;
            }
        }

        public bool Fill(Container container, bool overwriteOverflow = false)
        {
            int fillLimit = FillLimit();
            int overflowAmount = container.Content - fillLimit;

            if (container.Content > fillLimit)
            {
                //Overflow detected
                if (overwriteOverflow == false && ignoreOverflow == false)
                {
                    OnContainerOverflowContainer?.Invoke(this, overflowAmount, container);
                    return false;
                }
                else
                {
                    Content += fillLimit;
                    container.Empty(fillLimit);
                    return true;
                }
            }
            else
            {
                Content += container.Content;
                container.Empty();
                return true;
            }
        }

        public bool Fill(Container container, int amount, bool overwriteOverflow = false)
        {
            int fillLimit = FillLimit();
            int overflowAmount = amount - fillLimit;

            if (amount > fillLimit)
            {
                //Overflow detected
                if (overwriteOverflow == false && ignoreOverflow == false)
                {
                    OnContainerOverflowContainer?.Invoke(this, overflowAmount, container);
                    return false;
                }
                else
                {
                    Content += fillLimit;
                    container.Empty(fillLimit);
                    return true;
                }
            }
            else
            {
                Content += amount;
                container.Empty();
                return true;
            }
        }

        private int FillLimit()
        {
            return Capacity - Content;
        }

        public ContentStatus Status()
        {
            if (Content == Capacity)
                return ContentStatus.Full;
            if (Content == 0)
                return ContentStatus.Empty;
            else
                return ContentStatus.NotEmpty;
        }
    }
}
