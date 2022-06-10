using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OperationSystemProject
{
    public class Controller
    {
        private Form1 view;
        private Model model;
        private Timer timer = new Timer();


        /**
         * Связать представление с контроллером
         **/
        public void Attach(Form1 view_) 
        {
            view = view_;
            view.Attach(this);
            view.Attach(model);
        }


        /**
         * Связать модель с контроллером
         **/
        public void Attach(Model model_)
        {
            model = model_;
        }

        /**
         * Запустить моделирование
         **/
        public void StartTimer()
        {
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(model.Update);
            timer.Interval = 500;
        }
    }
}
