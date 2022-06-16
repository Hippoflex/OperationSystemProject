using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    class ExternalMemory : PhysicalMemory
    {
        private List<Frame> frames;

        public ExternalMemory()
        {
            frames = new List<Frame>();
        }


        public override void Attach(Frame frame)
        {
            frames.Add(frame);
        }

        public override void Dettach(Frame frame)
        {
            frames.Remove(frame);
        }


        public override Frame GetFrame(int index)
        {
            return frames[index];
        }

        public override int GetSize()
        {
            return frames.Count;
        }
    }
}
