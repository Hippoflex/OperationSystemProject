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
            for (int i = 1; i <= 5; ++i)
            {
                dataGridView1.Columns.Add("Frame", "Frame " + i.ToString());
            }


            dataGridView2.Columns.Add("Frame", "Frame ID");
            dataGridView3.Columns.Add("Frame", "Frame ID");

            dataGridView1.Rows.Add(1);
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


        public void UpdateProcessModel(int start, int end)
        {
            for (int i = start; i < end; ++i)
            {
                var process = model.GetProcess(i);

                if (i >= dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.Rows.Add(1);
                }
                    
                dataGridView1.Rows[i].Cells[0].Value = process.GetID().ToString();
                

                // вывод фреймов
                int quantity = process.Quantity();
                for (int j = 0; j < quantity; ++j)
                {
                    var frame = process.GetFrame(j);

                    dataGridView1.Rows[i].Cells[j + 1].Value = frame.GetID();
                }
            }
        }

        public void SelectedProccess(int index)
        {
            dataGridView1.Update();
            dataGridView1.Rows[index].Cells[0].Style.BackColor = Color.Orange;
            dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Orange;
            dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Orange;
            dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Orange;
            dataGridView1.Rows[index].Cells[4].Style.BackColor = Color.Orange;
            dataGridView1.Rows[index].Cells[5].Style.BackColor = Color.Orange;
        }

        public void SelecetedFrame(int index)
        {
            dataGridView2.Update();
            dataGridView2.Rows[index].Cells[0].Style.BackColor = Color.Aqua;           
        }

        public void SelectedEXMemory(int index)
        {
            dataGridView3.Update();
            dataGridView3.Rows[index].Cells[0].Style.BackColor = Color.Aquamarine;
        }

        public void UpdateRAMModel(int start, int end)
        {
            for (int i = start; start < end; ++i)
            {
                var frame = model.GetRamFrame(i);

                if (i >= dataGridView2.Rows.Count - 1)
                {
                    dataGridView2.Rows.Add(1);
                }

                dataGridView2.Rows[i].Cells[0].Value = frame.GetID();
            }
        }


        public void UpdateExternalMemoryModel(int start, int end)
        {
            for (int i = start; start < end; ++i)
            {
                var frame = model.GetEMFrame(i);

                if (i >= dataGridView3.Rows.Count - 1)
                {
                    dataGridView3.Rows.Add(1);
                }

                dataGridView3.Rows[i].Cells[0].Value = frame.GetID();
            }
        }
    }
}
