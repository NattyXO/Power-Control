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
        // Import Dlls
        [DllImport("user32")]
        public static extern void LockWorkStation();

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("powrprof.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        [DllImport("Wtsapi32.dll", SetLastError = true)]
        public static extern bool WTSLogoffSession(IntPtr hServer, int SessionId, bool bWait);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            lblTitle.Text = "Power controller";
            lblTitle.Location = new System.Drawing.Point(48, 27);
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, 18);
        }

        private void amharicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ሀይል መቆጣጠርያ";
            lblTitle.Location = new System.Drawing.Point(56, 28);
            lblTitle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void pnlShutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void pnlSleep_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true); // Sleep
        }

        private void pnlRestart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        private void pnlHibernate_Click(object sender, EventArgs e)
        {
            SetSuspendState(true, true, true); // Hibernate
        }

        private void pnlSwitchUser_Click(object sender, EventArgs e)
        {
            // Provide the correct SessionId and handle for your situation
            int sessionId = 1; // Example SessionId, adjust as needed
            IntPtr serverHandle = IntPtr.Zero; // Use zero for the local server

            WTSLogoffSession(serverHandle, sessionId, true);
        }

        private void pnlSignOut_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0x00000000 | 0x00000004, 0); // Log off
        }
    }
}
