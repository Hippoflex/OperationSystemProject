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
            listTable = new List<Frame>();
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
            /**
             * TO DO
             */
            Process proccess = new Process();
            processList.Add(proccess);

            view.UpdateProcess();
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
    }

}
