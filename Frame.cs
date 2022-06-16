using System;
using System.Collections.Generic;
using System.Text;

namespace OperationSystemProject
{
    public class Frame
    {
        private int         id;
        private int         type
        {
            get { return type; }
            set { type = value; }
        }


        public Frame()
        {
            Random rnd = new Random();
            int idRnd = rnd.Next(0, 10);
            id = idRnd;
        }
        

        
        public int GetID()
        {
            return id;
        }


    }
}
