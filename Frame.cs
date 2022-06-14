using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    public class Frame
    {
        private static int  ID = 0;
        private int         id;
        private int         type
        {
            get { return type; }
            set { type = value; }
        }


        public Frame()
        {
            id = ID++;
        }
        

        
        public int GetID()
        {
            return id;
        }


    }
}
