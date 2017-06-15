﻿using System;
using System.Collections.Generic;
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
        //Fills the form with starting information
        private void ProcessNote_Load(object sender, EventArgs e)
        {
            getProcesses();
            getCpuUsage();
            getRamUsage();
        }
        //stores running processes in a List, adds processes as a custom class object to tasksListBox
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
                    TasksListBox.Items.Add(new ProcessTask(process.ProcessName, process.Id, Convert.ToString(process.PrivateMemorySize64 / 1048576)));
                }
                ProcessValueLabel.Text = string.Format("{0}", processes.Count);
            }
        }
        //calculates the global cpu usage with the performanceCounterCPU
        void getCpuUsage()
        {
            CounterSample cs1 = performanceCounterCPU.NextSample();
            System.Threading.Thread.Sleep(100);
            CounterSample cs2 = performanceCounterCPU.NextSample();
            float cpuUsage = CounterSample.Calculate(cs1, cs2);
            cpuUsage = (cpuUsage < 1.00f) ? 1.00f : cpuUsage;
            CpuUsageValueLabel.Text = string.Format("{0:#,###.##} %", cpuUsage);
        }
        //calculates the global ram usag with the performanceCounterRAM
        void getRamUsage()
        {
            var useless = performanceCounterRAM.NextValue();
            System.Threading.Thread.Sleep(100);
            AvailableMemoryValueLabel.Text = string.Format("{0:#,###.##} Mb", performanceCounterRAM.NextValue());

        }
        //exits the application
        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //every tick starts methods to refresh content on the form 
        private void timer_Tick(object sender, EventArgs e)
        {
            getProcesses();
            getCpuUsage();
            getRamUsage();
            updateDetailedList();
        }
        //closes selected task on clicking "End Process" button
        private void killProcessButton_Click(object sender, EventArgs e)
        {
            processes[TasksListBox.SelectedIndex - 1].Kill();
        }
        //closes selected task via toolstripmenu
        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processes[TasksListBox.SelectedIndex - 1].Kill();
        }
        //if "Always on top" is ticked, the form is always on top
        private void onTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProcessNote.ActiveForm.TopMost = (ProcessNote.ActiveForm.TopMost == true) ? false : true;

        }
        //if anoter item is selected in the task list, detailed list is updated
        private void detailedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDetailedList();
        }
        //gets details of the currently seleced process, or returns a string
        private void updateDetailedList()
        {
            if (TasksListBox.SelectedIndex != -1)
            {
                detailedListBox.Items.Clear();
                fillDetails();
            }
            else
            {
                detailedListBox.Items.Clear();
                detailedListBox.Items.Add("Select an item first");
            }
        }
        //formats information abut the selected process, and adds it to the detailedListBox
        private void fillDetails()
        {
            string processStart;
            string RunningTime;
            Process focusedProcess = processes[TasksListBox.SelectedIndex - 1];
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

            detailedListBox.Items.Add("Process Name:\t" + Convert.ToString(focusedProcess.ProcessName));
            detailedListBox.Items.Add("Process ID:\t" + Convert.ToString(focusedProcess.Id));
            detailedListBox.Items.Add("Start Time:\t" + processStart);
            detailedListBox.Items.Add("Runnig Time:\t" + RunningTime);
            detailedListBox.Items.Add("Allocated Memory:\t" + Convert.ToString(focusedProcess.PrivateMemorySize64 / 1048576) + " MB");
            detailedListBox.Items.Add("Number of Threads:\t" + Convert.ToString(focusedProcess.Threads.Count));
        }
        //adds comment
        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedIndex != -1 && CommentFieldTextBox.Text.Length > 1)
            {
                TasksListBox.Items[TasksListBox.SelectedIndex] += "\tComment: " + CommentFieldTextBox.Text;
                CommentFieldTextBox.Clear();
            }

        }
    }
}
