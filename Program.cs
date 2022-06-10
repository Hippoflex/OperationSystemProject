using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationSystemProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            Form1 view = new Form1();
            
            Controller controller = new Controller();
            controller.Attach(view);
            controller.Attach(model);

            Application.Run(view);
        }
    }
}
