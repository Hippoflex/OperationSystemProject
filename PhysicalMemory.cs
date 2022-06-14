using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    class PhysicalMemory
    {
        protected List<Frame>   frameList;
        protected int           currentSize;
        protected int           maxSize;


        public PhysicalMemory(int size)
        {
            maxSize = size;
        }

        public int GetSize()
        {
            return maxSize;
        }

        public void Attach(Frame item)
        {
            frameList.Add(item);
        }


        public void Dettach(Frame item)
        {
            frameList.Remove(item);
        }


    }
}
