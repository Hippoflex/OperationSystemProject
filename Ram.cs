using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    class Ram : PhysicalMemory
    {
        private Queue<Frame> frames;
        private int maxSize;
        public ExternalMemory em;

        public Ram(int size)
        {
            frames = new Queue<Frame>();
            maxSize = size;
        }

        public override void Attach(Frame item)
        {
            bool containFrame = false;
            foreach (var frame in frames)
            {
                if (frame.GetID() == item.GetID())
                {
                    containFrame = true;
                }
            }

            if (!containFrame && frames.Count < maxSize)
            {
                frames.Enqueue(item);
            } else if (!containFrame)
            {
                em.Attach(frames.Dequeue());
                frames.Enqueue(item);
            }
        }


        public override void Dettach(Frame item)
        {
            throw new NotImplementedException();
        }

        public override int GetSize()
        {
            return frames.Count;
        }

        public override Frame GetFrame(int index)
        {
            return frames.ToArray()[index];
        }

    }
}
