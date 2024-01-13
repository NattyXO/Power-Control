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
            lblTitle.Text = "ሀይል መቆጣጠርያ";
            lblTitle.Location = new System.Drawing.Point(56, 28);
            lblTitle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            lblShutdown.Text = "ዝጋው";
            lblShutdown.Font = new Font("Microsoft Sans Serif", 8);
            lblShutdown.Location = new System.Drawing.Point(24, 38);
            lblSleep.Text = "ተኛ";
            lblSleep.Font = new Font("Microsoft Sans Serif", 8);
            lblSleep.Location = new System.Drawing.Point(28, 38);
            lblRestart.Text = "እንደገና ጀምር";
            lblRestart.Font = new Font("Microsoft Sans Serif", 8);
            lblRestart.Location = new System.Drawing.Point(6, 36);
            lblSwitchUser.Text = "ተጠቃሚ ቀይር";
            lblSwitchUser.Font = new Font("Microsoft Sans Serif", 8);
            lblSwitchUser.Location = new System.Drawing.Point(6, 37);
            lblSignOut.Text = "ዛግተ ውጣ";
            lblSignOut.Font = new Font("Microsoft Sans Serif", 8);
            lblSignOut.Location = new System.Drawing.Point(14, 37);
            lblDonate.Text = "ማስታወቂያዎችን በመመልከት ይለግሱ";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(4, 2);
            pnlDonate.Size = new System.Drawing.Size(173, 18);
            pnlDonate.Location = new System.Drawing.Point(118, 205);
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
            lblTitle.Location = new System.Drawing.Point(53, 27);
            lblTitle.Font = new Font("Microsoft Sans Serif", 18);
            lblShutdown.Text = "Shutdown";
            lblShutdown.Font = new Font("Microsoft Sans Serif", 8);
            lblShutdown.Location = new System.Drawing.Point(13, 37);
            lblSleep.Text = "Sleep";
            lblSleep.Font = new Font("Microsoft Sans Serif", 8);
            lblSleep.Location = new System.Drawing.Point(23, 37);
            lblRestart.Text = "Restart";
            lblRestart.Font = new Font("Microsoft Sans Serif", 8);
            lblRestart.Location = new System.Drawing.Point(18, 37);
            lblSwitchUser.Text = "Switch User";
            lblSwitchUser.Font = new Font("Microsoft Sans Serif", 8);
            lblSwitchUser.Location = new System.Drawing.Point(9, 39);
            lblSignOut.Text = "Sign Out";
            lblSignOut.Font = new Font("Microsoft Sans Serif", 8);
            lblSignOut.Location = new System.Drawing.Point(16, 39);
            lblDonate.Text = "Donate by watching ads.";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(2, 2);
            pnlDonate.Size = new System.Drawing.Size(127, 18);
            pnlDonate.Location = new System.Drawing.Point(161, 205);
        }

        private void amharicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ሀይል መቆጣጠርያ";
            lblTitle.Location = new System.Drawing.Point(56, 28);
            lblTitle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            lblShutdown.Text = "ዝጋው";
            lblShutdown.Font = new Font("Microsoft Sans Serif", 8);
            lblShutdown.Location = new System.Drawing.Point(24, 38);
            lblSleep.Text = "ተኛ";
            lblSleep.Font = new Font("Microsoft Sans Serif", 8);
            lblSleep.Location = new System.Drawing.Point(28, 38);
            lblRestart.Text = "እንደገና ጀምር";
            lblRestart.Font = new Font("Microsoft Sans Serif", 8);
            lblRestart.Location = new System.Drawing.Point(6, 36);
            lblSwitchUser.Text = "ተጠቃሚ ቀይር";
            lblSwitchUser.Font = new Font("Microsoft Sans Serif", 8);
            lblSwitchUser.Location = new System.Drawing.Point(6, 37);
            lblSignOut.Text = "ዛግተ ውጣ";
            lblSignOut.Font = new Font("Microsoft Sans Serif", 8);
            lblSignOut.Location = new System.Drawing.Point(14, 37);
            lblDonate.Text = "ማስታወቂያዎችን በመመልከት ይለግሱ";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(4, 2);
            pnlDonate.Size = new System.Drawing.Size(173, 18);
            pnlDonate.Location = new System.Drawing.Point(118, 205);
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
