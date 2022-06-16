using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    public abstract class PhysicalMemory
    {
        public abstract int GetSize();

        public abstract void Attach(Frame frame);

        public abstract void Dettach(Frame frame);

        public abstract Frame GetFrame(int index);
    }
}
