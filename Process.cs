using System;
using System.Collections.Generic;
using System.Text;


namespace OperationSystemProject
{
    public class Process
    {
        private static int ID = 0;


        private int         id;
        private List<Frame> frameList;


        public Process()
        {
            id = NextID();
        }

        /**
         * Добавить фрейм
         **/
        public void Add(Frame frame)
        {
            frameList.Add(frame);
        }


        /**
         * Получить фрейм по индексу
         **/
        public Frame GetFrame(int index)
        {
            return frameList[index];
        }

        /**
         * получить количество фреймов
         **/
        public int Quantity()
        {
            return frameList.Count;
        }

        private static int NextID()
        {
            return ++ID;
        }
    }
}
