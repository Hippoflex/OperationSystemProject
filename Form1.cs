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

            dataGridView1.Columns.Add("Process", "Process ID");
            dataGridView2.Columns.Add("Frame", "Frame ID");
            dataGridView3.Columns.Add("Frame", "Frame ID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Generate(((int)numericUpDown1.Value));
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


        public void UpdateProcess()
        {
            int quantity = model.GetQuantity();

            for (int i = 0; i < quantity; ++i)
            {
                var process = model.GetProcess(i);
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i].Cells[0].Value = process.GetID().ToString();
            }
        }
    }
}
