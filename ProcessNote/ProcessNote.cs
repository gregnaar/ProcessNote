using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ProcessNoteHelper;

namespace ProcessNote
{
    public partial class ProcessNote : Form
    {
        List<Process> processes;

        public ProcessNote()
        {
            InitializeComponent();
        }
        
        private void ProcessNote_Load(object sender, EventArgs e)
        {
            getProcesses();
            getCpuUsage();
            getRamUsage();
        }
        
        void getProcesses()
        {
            processes = new List<Process>(Process.GetProcesses());
            if (Convert.ToInt32(ProcessValueLabel.Text) != processes.Count)
            {
                TasksListBox.Items.Clear();
                TasksListBox.Items.Add("ID: \t Memory: \t Name: ");
                processes = new List<Process>(Process.GetProcesses());

                foreach (Process process in processes)
                {
                    TasksListBox.Items.Add( new ProcessTask(process.ProcessName, process.Id, Convert.ToString(process.PrivateMemorySize64 / 1048576)));
                }
                
                ProcessValueLabel.Text = string.Format("{0}", processes.Count);
            }
        }

        void getCpuUsage()
        {
            
            CounterSample cs1 = performanceCounterCPU.NextSample();
            System.Threading.Thread.Sleep(100);
            CounterSample cs2 = performanceCounterCPU.NextSample();
            float cpuUsage = CounterSample.Calculate(cs1, cs2);
            cpuUsage = (cpuUsage < 1.00f) ?  1.00f : cpuUsage;
            CpuUsageValueLabel.Text = string.Format("{0:#,###.##} %", cpuUsage);
        }

        void getRamUsage()
        {

            var useless = performanceCounterRAM.NextValue();
            System.Threading.Thread.Sleep(100);
            AvailableMemoryValueLabel.Text = string.Format("{0:#,###.##} Mb", performanceCounterRAM.NextValue());

        }
        
        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            TasksListBox.Items.Clear();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getProcesses();
            getCpuUsage();
            getRamUsage();
            updateDetailedList();
        }

        private void killProcessButton_Click(object sender, EventArgs e)
        {
            processes[TasksListBox.SelectedIndex-1].Kill();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processes[TasksListBox.SelectedIndex-1].Kill();
        }

        private void onTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProcessNote.ActiveForm.TopMost = (ProcessNote.ActiveForm.TopMost == true) ? false : true;
            
        }

        private void detailedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDetailedList();
        }

        private void updateDetailedList()
        {
            try
            {
                Process focusedProcess = processes[TasksListBox.SelectedIndex - 1];
                detailedListBox.Items.Clear();
                detailedListBox.Items.Add("Process Name:\t" + Convert.ToString(focusedProcess.ProcessName));
                detailedListBox.Items.Add("Process ID:\t" + Convert.ToString(focusedProcess.Id));
                string processStart;
                string RunningTime;
                try
                {
                    processStart = Convert.ToString(focusedProcess.StartTime);
                    RunningTime = Convert.ToString(DateTime.Now - focusedProcess.StartTime);
                }
                catch (Exception)
                {
                    processStart = "Access Denied!";
                    RunningTime = "Access Denied";

                }
                detailedListBox.Items.Add("Start Time:\t" + processStart);
                detailedListBox.Items.Add("Runnig Time:\t" + RunningTime);
                detailedListBox.Items.Add("Allocated Memory:\t" + Convert.ToString(focusedProcess.PrivateMemorySize64 / 1048576) + " MB");
                //DetailedListBox.Items.Add("CPU usage:\t" + "1%");
                detailedListBox.Items.Add("Number of Threads:\t" + Convert.ToString(focusedProcess.Threads.Count));
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            int selected = TasksListBox.SelectedIndex;
            TasksListBox.Items[selected] += "\tComment: " + CommentFieldTextBox.Text;
            CommentFieldTextBox.Clear();
        }
    }
}
