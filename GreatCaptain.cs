/*
 * Author: PECman
 * Date: 2018/3/24
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace GreatCaptain
{
    public partial class GreatCaptain : Form
    {
        public GreatCaptain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Process.GetProcessesByName(textBox1.Text).Length > 0)
                {
                    foreach (Process pro in Process.GetProcessesByName(textBox1.Text))
                    {
                        pro.Kill();
                    }
                }
                else
                {
                    MessageBox.Show("该进程不存在！");
                }
            }
            else
            {
                MessageBox.Show("进程名有误！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Process pro in Process.GetProcesses())
            {
                processes.Items.Add(pro.ProcessName);
                pids.Items.Add(pro.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processes.Items.Clear();
            pids.Items.Clear();
            foreach (Process pro in Process.GetProcesses())
            {
                processes.Items.Add(pro.ProcessName);
                pids.Items.Add(pro.Id);
            }
        }

        private void processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pids.SelectedIndex = processes.SelectedIndex;
        }

        private void pids_SelectedIndexChanged(object sender, EventArgs e)
        {
            processes.SelectedIndex = pids.SelectedIndex;
        }
    }
}
