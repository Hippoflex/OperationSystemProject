using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OperationSystemProject
{
    public class Model
    {
        private List<Frame>     listTable;
        private List<Proccess>  processList;
        private Ram             ram;
        private ExternalMemory  externalMemory;
        private Form1           view;


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
            Proccess proccess = new Proccess();
            processList.Add(proccess);
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
    }

}
