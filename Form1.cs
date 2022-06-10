using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationSystemProject
{
    public partial class Form1 : Form
    {
        private Controller  controller;
        private Model       model;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.StartTimer();
        }


        public void Attach(Controller controller_)
        {
            controller = controller_;
        }

        public void Attach(Model model_)
        {
            model = model_;
        }
    }
}
