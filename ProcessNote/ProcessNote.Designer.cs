namespace ProcessNote
{
    partial class ProcessNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessNote));
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.KillProcessMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.performanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.performanceCounterRAM = new System.Diagnostics.PerformanceCounter();
            this.DetailedListBox = new System.Windows.Forms.ListBox();
            this.CommentFieldLabel = new System.Windows.Forms.Label();
            this.CommentFieldTextBox = new System.Windows.Forms.TextBox();
            this.AddCommentButton = new System.Windows.Forms.Button();
            this.EndProcessButton = new System.Windows.Forms.Button();
            this.Processlabel = new System.Windows.Forms.Label();
            this.ExitApplicationButton = new System.Windows.Forms.Button();
            this.ProcessValueLabel = new System.Windows.Forms.Label();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.CpuUsageValueLabel = new System.Windows.Forms.Label();
            this.AvailableMemoryLabel = new System.Windows.Forms.Label();
            this.AvailableMemoryValueLabel = new System.Windows.Forms.Label();
            this.OnTopcheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Harrr = new System.Windows.Forms.Label();
            this.KillProcessMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TasksListBox
            // 
            this.TasksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.TasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TasksListBox.ContextMenuStrip = this.KillProcessMenuStrip;
            this.TasksListBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TasksListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.ItemHeight = 16;
            this.TasksListBox.Location = new System.Drawing.Point(3, 124);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(374, 306);
            this.TasksListBox.TabIndex = 0;
            this.TasksListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // KillProcessMenuStrip
            // 
            this.KillProcessMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killProcessToolStripMenuItem});
            this.KillProcessMenuStrip.Name = "contextMenuStrip1";
            this.KillProcessMenuStrip.Size = new System.Drawing.Size(134, 26);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // performanceCounterCPU
            // 
            this.performanceCounterCPU.CategoryName = "Processor";
            this.performanceCounterCPU.CounterName = "% Processor Time";
            this.performanceCounterCPU.InstanceName = "_Total";
            // 
            // performanceCounterRAM
            // 
            this.performanceCounterRAM.CategoryName = "Memory";
            this.performanceCounterRAM.CounterName = "Available MBytes";
            // 
            // DetailedListBox
            // 
            this.DetailedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.DetailedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailedListBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DetailedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailedListBox.FormattingEnabled = true;
            this.DetailedListBox.ItemHeight = 16;
            this.DetailedListBox.Location = new System.Drawing.Point(385, 267);
            this.DetailedListBox.Name = "DetailedListBox";
            this.DetailedListBox.Size = new System.Drawing.Size(256, 146);
            this.DetailedListBox.TabIndex = 13;
            // 
            // CommentFieldLabel
            // 
            this.CommentFieldLabel.AutoSize = true;
            this.CommentFieldLabel.BackColor = System.Drawing.Color.White;
            this.CommentFieldLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommentFieldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.CommentFieldLabel.Location = new System.Drawing.Point(380, 194);
            this.CommentFieldLabel.Name = "CommentFieldLabel";
            this.CommentFieldLabel.Size = new System.Drawing.Size(117, 20);
            this.CommentFieldLabel.TabIndex = 14;
            this.CommentFieldLabel.Text = "Comment Field:";
            // 
            // CommentFieldTextBox
            // 
            this.CommentFieldTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.CommentFieldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentFieldTextBox.ForeColor = System.Drawing.Color.Silver;
            this.CommentFieldTextBox.Location = new System.Drawing.Point(385, 217);
            this.CommentFieldTextBox.Name = "CommentFieldTextBox";
            this.CommentFieldTextBox.Size = new System.Drawing.Size(250, 20);
            this.CommentFieldTextBox.TabIndex = 15;
            this.CommentFieldTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AddCommentButton
            // 
            this.AddCommentButton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddCommentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.AddCommentButton.Location = new System.Drawing.Point(541, 243);
            this.AddCommentButton.Name = "AddCommentButton";
            this.AddCommentButton.Size = new System.Drawing.Size(94, 23);
            this.AddCommentButton.TabIndex = 16;
            this.AddCommentButton.Text = "Add Comment";
            this.AddCommentButton.UseVisualStyleBackColor = true;
            this.AddCommentButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EndProcessButton
            // 
            this.EndProcessButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndProcessButton.ForeColor = System.Drawing.Color.Maroon;
            this.EndProcessButton.Location = new System.Drawing.Point(297, 41);
            this.EndProcessButton.Name = "EndProcessButton";
            this.EndProcessButton.Size = new System.Drawing.Size(94, 30);
            this.EndProcessButton.TabIndex = 3;
            this.EndProcessButton.Text = "End Process";
            this.EndProcessButton.UseVisualStyleBackColor = true;
            this.EndProcessButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Processlabel
            // 
            this.Processlabel.AutoSize = true;
            this.Processlabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Processlabel.Location = new System.Drawing.Point(8, 45);
            this.Processlabel.Name = "Processlabel";
            this.Processlabel.Size = new System.Drawing.Size(79, 20);
            this.Processlabel.TabIndex = 5;
            this.Processlabel.Text = "Processes :";
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitApplicationButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitApplicationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.ExitApplicationButton.Location = new System.Drawing.Point(276, 90);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(136, 28);
            this.ExitApplicationButton.TabIndex = 1;
            this.ExitApplicationButton.Text = "Close Application";
            this.ExitApplicationButton.UseVisualStyleBackColor = false;
            this.ExitApplicationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcessValueLabel
            // 
            this.ProcessValueLabel.AutoSize = true;
            this.ProcessValueLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProcessValueLabel.Location = new System.Drawing.Point(114, 45);
            this.ProcessValueLabel.Name = "ProcessValueLabel";
            this.ProcessValueLabel.Size = new System.Drawing.Size(17, 20);
            this.ProcessValueLabel.TabIndex = 6;
            this.ProcessValueLabel.Text = "0";
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CpuUsageLabel.Location = new System.Drawing.Point(9, 65);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(75, 18);
            this.CpuUsageLabel.TabIndex = 7;
            this.CpuUsageLabel.Text = "CPU usage:";
            // 
            // CpuUsageValueLabel
            // 
            this.CpuUsageValueLabel.AutoSize = true;
            this.CpuUsageValueLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CpuUsageValueLabel.Location = new System.Drawing.Point(115, 65);
            this.CpuUsageValueLabel.Name = "CpuUsageValueLabel";
            this.CpuUsageValueLabel.Size = new System.Drawing.Size(15, 18);
            this.CpuUsageValueLabel.TabIndex = 8;
            this.CpuUsageValueLabel.Text = "0";
            // 
            // AvailableMemoryLabel
            // 
            this.AvailableMemoryLabel.AutoSize = true;
            this.AvailableMemoryLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvailableMemoryLabel.Location = new System.Drawing.Point(9, 86);
            this.AvailableMemoryLabel.Name = "AvailableMemoryLabel";
            this.AvailableMemoryLabel.Size = new System.Drawing.Size(122, 18);
            this.AvailableMemoryLabel.TabIndex = 9;
            this.AvailableMemoryLabel.Text = "Available memory:";
            // 
            // AvailableMemoryValueLabel
            // 
            this.AvailableMemoryValueLabel.AutoSize = true;
            this.AvailableMemoryValueLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvailableMemoryValueLabel.Location = new System.Drawing.Point(137, 86);
            this.AvailableMemoryValueLabel.Name = "AvailableMemoryValueLabel";
            this.AvailableMemoryValueLabel.Size = new System.Drawing.Size(15, 18);
            this.AvailableMemoryValueLabel.TabIndex = 10;
            this.AvailableMemoryValueLabel.Text = "0";
            // 
            // OnTopcheckBox
            // 
            this.OnTopcheckBox.AutoSize = true;
            this.OnTopcheckBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnTopcheckBox.Location = new System.Drawing.Point(12, 10);
            this.OnTopcheckBox.Name = "OnTopcheckBox";
            this.OnTopcheckBox.Size = new System.Drawing.Size(136, 26);
            this.OnTopcheckBox.TabIndex = 12;
            this.OnTopcheckBox.Text = "Always on top";
            this.OnTopcheckBox.UseVisualStyleBackColor = true;
            this.OnTopcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProcessNote.Properties.Resources.HAR;
            this.pictureBox1.Location = new System.Drawing.Point(439, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 159);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Harrr);
            this.panel1.Controls.Add(this.TasksListBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AddCommentButton);
            this.panel1.Controls.Add(this.OnTopcheckBox);
            this.panel1.Controls.Add(this.CommentFieldLabel);
            this.panel1.Controls.Add(this.CommentFieldTextBox);
            this.panel1.Controls.Add(this.AvailableMemoryValueLabel);
            this.panel1.Controls.Add(this.AvailableMemoryLabel);
            this.panel1.Controls.Add(this.CpuUsageValueLabel);
            this.panel1.Controls.Add(this.CpuUsageLabel);
            this.panel1.Controls.Add(this.ExitApplicationButton);
            this.panel1.Controls.Add(this.ProcessValueLabel);
            this.panel1.Controls.Add(this.Processlabel);
            this.panel1.Controls.Add(this.EndProcessButton);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 430);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(377, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Harrr!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(534, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Harrr!";
            // 
            // Harrr
            // 
            this.Harrr.AutoSize = true;
            this.Harrr.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Harrr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Harrr.Location = new System.Drawing.Point(555, 11);
            this.Harrr.Name = "Harrr";
            this.Harrr.Size = new System.Drawing.Size(86, 37);
            this.Harrr.TabIndex = 17;
            this.Harrr.Text = "Harrr!";
            // 
            // ProcessNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 425);
            this.Controls.Add(this.DetailedListBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessNote";
            this.Text = "ProcessNote";
            this.Load += new System.EventHandler(this.ProcessNote_Load);
            this.KillProcessMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.ContextMenuStrip KillProcessMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter performanceCounterCPU;
        private System.Diagnostics.PerformanceCounter performanceCounterRAM;
        private System.Windows.Forms.ListBox DetailedListBox;
        private System.Windows.Forms.Label CommentFieldLabel;
        private System.Windows.Forms.TextBox CommentFieldTextBox;
        private System.Windows.Forms.Button AddCommentButton;
        private System.Windows.Forms.Button EndProcessButton;
        private System.Windows.Forms.Label Processlabel;
        private System.Windows.Forms.Button ExitApplicationButton;
        private System.Windows.Forms.Label ProcessValueLabel;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.Label CpuUsageValueLabel;
        private System.Windows.Forms.Label AvailableMemoryLabel;
        private System.Windows.Forms.Label AvailableMemoryValueLabel;
        private System.Windows.Forms.CheckBox OnTopcheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Harrr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

