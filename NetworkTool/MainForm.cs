using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace NetworkTool
{
    public partial class MainForm : Form
    {
        public Thread updateNetworkStatusIcon;

        /*
         * Initialize
         */ 
        public MainForm()
        {
            InitializeComponent();
            notifyTrayIcon.Text = "Network Tool " + Properties.Resources.Version;
            notifyTrayIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            InitializeIcons();
            updateNetworkStatusIcon = new Thread(delegate() { animateTrayIcon(notifyTrayIcon); });
            updateNetworkStatusIcon.IsBackground = true;
            updateNetworkStatusIcon.Start();

            // start network
            if (Global.Autostart) {
                WifiNetwork.CreateNetwork();
            }
        }

        /*
         * Show balloon toolstrip when left mouse clicked on tray icon
         */ 
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // show status and info about network
            if (MouseButtons.Left == e.Button) 
                notifyTrayIcon.ShowBalloonTip(4000, Global.balloonTitle, WifiNetwork.NetworkInfo(), ToolTipIcon.Info);
        }

        /*
         * Exits app
         */ 
        private void exitItem_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }
        
        /*
         * Show options windoow
         */
        private void optionsItem_Click(object sender, EventArgs e)
        {
            // show options
            OptionsForm f = new OptionsForm();
            f.ShowDialog(this);
        }

        /*
         * Creates wifi network
         */ 
        private void createNetworkItem_Click(object sender, EventArgs e)
        {
            WifiNetwork.CreateNetwork();
        } 

        /*
         * Closes created previously wifi network
         */ 
        private void closeNetworkItem_Click(object sender, EventArgs e)
        {
            WifiNetwork.StopNetwork();
        }  

        /*
         * Shows about window
         */ 
        public AboutForm a;
        private void aboutItem_Click(object sender, EventArgs e)
        {
            a = new AboutForm();
            a.ShowDialog();
        }

        /* 
         * create animated icons
         */ 
        public System.Drawing.Icon[] trayIcons = new System.Drawing.Icon[4];
        public void InitializeIcons()
        {
            trayIcons[0] = NetworkTool.Properties.Resources.stat_sys_signal_1;
            trayIcons[1] = NetworkTool.Properties.Resources.stat_sys_signal_2;
            trayIcons[2] = NetworkTool.Properties.Resources.stat_sys_signal_3;
            trayIcons[3] = NetworkTool.Properties.Resources.stat_sys_signal_4;
        }

        /* 
         * Animation for tray icon
         */ 
        private void animateTrayIcon(NotifyIcon n)
        {
            int i = 0;
            while (true)
            {
                try {
                    if (WifiNetwork.isNetworkRunning) {
                            // show animated icon
                            if (i >= trayIcons.Length) i = 0;
                            n.Icon = trayIcons[i];
                            Thread.Sleep(400);
                            i++;
                        }
                    else if (notifyTrayIcon.Icon != NetworkTool.Properties.Resources.stat_sys_signal_0) {
                        notifyTrayIcon.Icon = NetworkTool.Properties.Resources.stat_sys_signal_0;
                        i = 0;
                    }
                }
                catch (Exception) { /*notifyTrayIcon.Icon = NetworkTool.Properties.Resources.stat_sys_signal_0;*/ };
            }
        }

    }
}