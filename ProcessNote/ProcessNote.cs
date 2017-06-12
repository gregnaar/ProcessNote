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
        System.Windows.Forms.Timer t;
        bool run = true;

        public ProcessNote()
        {
            InitializeComponent();
        }

        private void ProcessNote_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            refreshTasks();
            if ( run == false ) t.Stop();
        }

        void refreshTasks()
        {
            Process[] processes = Process.GetProcesses();
            var sorted = processes.OrderBy(item => item.ProcessName);
            listBox1.Items.Clear();
            

            foreach (Process process in sorted)
            {
                listBox1.Items.Add(string.Format("Process name: {0} Process Id: {1}", process.ProcessName, process.Id));
            }
            textBox1.Text = string.Format("Running processes: {0}", sorted.Count());
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
