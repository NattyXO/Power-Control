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

        [DllImport("wtsapi32.dll", SetLastError = true)]
        public static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);

        [DllImport("Kernel32.dll")]
        public static extern IntPtr WTSGetActiveConsoleSessionId();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
            lblDonate.Text = "ቡና ይግዙልኝ";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(4, 2);
            pnlDonate.Size = new System.Drawing.Size(66, 18);
            pnlDonate.Location = new System.Drawing.Point(224, 204);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Power Controller 2024\n"+
                "Version 1.0\n"+
                "© 2024 Ahadu Tech\n"; 

            MessageBox.Show(aboutMessage, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Power Controller";
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
            lblDonate.Text = "Buy me a Coffe";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(7, 2);
            pnlDonate.Size = new System.Drawing.Size(90, 18);
            pnlDonate.Location = new System.Drawing.Point(200, 204);
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
            lblDonate.Text = "ቡና ይግዙልኝ";
            lblDonate.Font = new Font("Microsoft Sans Serif", 8);
            lblDonate.Location = new System.Drawing.Point(4, 2);
            pnlDonate.Size = new System.Drawing.Size(66, 18);
            pnlDonate.Location = new System.Drawing.Point(224, 204);
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
            SwitchUser();
        }

        private void SwitchUser()
        {
            IntPtr sessionId = WTSGetActiveConsoleSessionId();
            if (sessionId.ToInt32() != -1)
            {
                // Disconnect the current session (switch user)
                WTSDisconnectSession(IntPtr.Zero, sessionId.ToInt32(), false);
            }
        }
        private void pnlSignOut_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0x00000000 | 0x00000004, 0); // Log off
        }

        private void pnlDonate_Click(object sender, EventArgs e)
        {
            string buyacoffe = "https://www.buymeacoffee.com/nattyxo";
            Process.Start(buyacoffe);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinimized_MouseHover(object sender, EventArgs e)
        {
            picMinimized.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void picMinimized_MouseLeave(object sender, EventArgs e)
        {
            picMinimized.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
