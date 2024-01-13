using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Shutdown_control
{
    public partial class Form1 : Form
    {
        //for Lock import Dlls
        [DllImport("user32")]
        public static extern void LockworkStation();
        //for Logoff
        [DllImport("user32")]
        public static extern bool ExitwindowsEx(GraphicsUnit uFlags, uint dwReason);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            LockworkStation();
        }

        private void btnsleep_Click(object sender, EventArgs e)
        {

        }

        private void btnlogoff_Click(object sender, EventArgs e)
        {
            ExitwindowsEx(0, 0);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You window license expire soon", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("expire soon", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
        }
    }
}
