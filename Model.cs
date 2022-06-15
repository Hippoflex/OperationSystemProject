using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OperationSystemProject
{
    public class Model
    {
        private List<Frame>     listTable;
        private List<Process>   processList;
        private Ram             ram;
        private ExternalMemory  externalMemory;

        private Form1           view;



        public Model()
        {
            ram = new Ram(5);
            processList = new List<Process>();
        }


        /**
         * Связывает представление с моделью
         **/
        public void Attach(Form1 view_)
        {
            view = view_;
        }

        /**
         * Генерирует новый процесс
         **/
        public void GenerateProcess()
        {
            Process proccess = new Process();
            processList.Add(proccess);


            Random rnd = new Random();
            int frameQuantity =  rnd.Next(3, 6);
            
            for (int i = 0; i < frameQuantity; ++i)
                proccess.Add(new Frame());
            
            view.UpdateProcessModel(0, processList.Count);
        }


        /**
         * Основной цикл моделирования
         **/
        public void Update(object source, ElapsedEventArgs e)
        {
            /*
                TO DO
            */    
        }


        public Process GetProcess(int index)
        {
            return processList[index];
        }


        public int GetQuantity()
        {
            return processList.Count;
        }

        public Frame GetRamFrame(int index)
        {
            return ram.GetFrame(index);
        }

        public Frame GetEMFrame(int index)
        {
            return ram.GetFrame(index);
        }
    }

}
