using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class ProcessNote : Form
    {
        Process[] processes;

        public ProcessNote()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        
        private void ProcessNote_Load(object sender, EventArgs e)
        {
            getProcesses();
            getCpuUsage();
            getRamUsage();
        }
        
        void getProcesses()
        {
            processes = Process.GetProcesses();
            if (Convert.ToInt32(label2.Text) != processes.Length)
            {
                listBox1.Items.Clear();
                processes = Process.GetProcesses();

                foreach (Process process in processes)
                {
                    listBox1.Items.Add(string.Format("Process: {0}", process.ProcessName));
                }
                label2.Text = string.Format("{0}", processes.Length);
            }
        }

        void getCpuUsage()
        {
            
            var useless = string.Format("{0:#,###.##} %", performanceCounter1.NextValue());
            label4.Text = string.Format("{0:#,###.##} %", performanceCounter1.NextValue());

        }

        void getRamUsage()
        {

            var useless = string.Format("{0:#,###.##} Mb", performanceCounter2.NextValue());
            label6.Text = string.Format("{0:#,###.##} Mb", performanceCounter2.NextValue());

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getProcesses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processes[listBox1.SelectedIndex].Kill();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processes[listBox1.SelectedIndex].Kill();
        }
    }
}
