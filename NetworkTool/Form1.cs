using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace NetworkTool
{
    public partial class Form1 : Form
    {
        public String key = "netshkeyadmin";
        public String ssid = "MSVWiFi";
        public Thread updateNetworkStatusIcon;
        
        private void Form1_Load(object sender, EventArgs e)
        {     }

        public Form1()
        {
            InitializeComponent();
            this.Text = "Network Tool " + Properties.Resources.Version;
            notifyTrayIcon.Text = "Network Tool " + Properties.Resources.Version;
            notifyTrayIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            this.SizeChanged += (object sender, EventArgs e) => {
                if (WindowState == FormWindowState.Minimized) this.ShowInTaskbar = false;
            };

            InitializeIcons();
            updateNetworkStatusIcon = new Thread(delegate() { animateTrayIcon(notifyTrayIcon); });
            updateNetworkStatusIcon.IsBackground = true;
            updateNetworkStatusIcon.Start();

            // start network
            createNetwork();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // show status and info about network
            if (MouseButtons.Left == e.Button) showNetworkStatus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }
        
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show options
            OptionsForm f = new OptionsForm(setSSIDKEY, getSSIDKEY);
            f.ShowDialog(this);
        }

        private void createNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNetwork();
        }

        private void createNetwork()
        {
            // create network
            String c = "netsh wlan set hostednetwork mode=allow ssid=\"" + ssid + "\" key=\"" + key + "\" keyUsage=persistent";
            try
            {
                ExecuteCommand(c);
                ExecuteCommand(Commands.startHostedNetwork);
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex.ToString()); };
        }

        private void closeNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close created network
            try { ExecuteCommand(Commands.stopHostedNetwork); }
            catch (Exception ex) { MessageBox.Show("Error " + ex.ToString()); };
        }

        // executes a command from command line
        public StreamReader ExecuteCommand(string Command)
        {
            StreamReader r = null;
            try
            {
                ProcessStartInfo ProcessInfo;
                Process Process;

                // create a new process and execute 'Command'
                ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + Command);
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = false;
                ProcessInfo.RedirectStandardOutput = true;
                Process = Process.Start(ProcessInfo);

                // try to read from output from console
                r = Process.StandardOutput;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return r;
        }

        public void setSSIDKEY(String ssid, String key)
        {
            this.ssid = ssid;
            this.key = key;
        }

        public String[] getSSIDKEY()
        {
            String[] s = new String[2];
            s[0] = ssid;
            s[1] = key;
            return s;
        }

        // create/show about form
        public AboutForm a;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                a = new AboutForm();
                a.ShowDialog();
        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach ( Form OpenForm in Application.OpenForms )
            {
                if ( OpenForm.GetType() == FormType )
                    return OpenForm;
            }
            return null;
        }

        public void showNetworkStatus()
        {
            try
            {
                String result = "";
                StreamReader r = ExecuteCommand(Commands.showHostedNetwork);
                String s = r.ReadToEnd();

                // format string and trim
                String trimmedResult = Regex.Replace(s, @"[\r\n]", "");
                trimmedResult = Regex.Replace(trimmedResult, @"\s+", " ");
                trimmedResult = Regex.Replace(trimmedResult, @"-+", "");

                // get network status
                GroupCollection status = new Regex(@"Status : (Started|Not started)").Match(trimmedResult).Groups;

                // get network BSSID
                GroupCollection bssid = new Regex(@"BSSID : ([\w:]+)").Match(trimmedResult).Groups;

                // get network status
                GroupCollection numOfClients = new Regex(@"Number of clients : ([\w]+)").Match(trimmedResult).Groups;

                // get all authenticated devices
                if (status[1].Value == "Not started")
                    result = status[0].Value;
                else
                {
                    String mod = trimmedResult.Remove(0, trimmedResult.IndexOf("Number of clients"));
                    mod = Regex.Replace(mod, @"Number of clients[\s]+:[\t\s]+([\w]+)", "").Trim();

                    MatchCollection mc = new Regex(@"[\w\n:]+\s[\w]+").Matches(mod);
                    result = status[0].Value + "\n" + bssid[0].Value + "\n" + numOfClients[0].Value;
                    foreach (Match i in mc)
                    {
                        result += "\n\t" + i.Value;
                    }
                }

                notifyTrayIcon.ShowBalloonTip(4000, Commands.balloonTitle, result, ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // show network status, bssid and number of clients
        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNetworkStatus();
        }

        // show network status, bssid and number of clients
        private bool getNetworkStatus()
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.showHostedNetwork);
                String s = r.ReadToEnd();

                String status = new Regex(@"Status[\s]+:[\t\s]+(Started|Not started)").Match(s).Groups[1].Value.Trim();

                // if network started then return true(network is running) else return false(network is not running)
                if (status == "Started") return true;
                    else return false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        private void notifyMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        // create animated icons
        public System.Drawing.Icon[] trayIcons = new System.Drawing.Icon[4];
        public void InitializeIcons()
        {
            trayIcons[0] = NetworkTool.Properties.Resources.stat_sys_signal_1;
            trayIcons[1] = NetworkTool.Properties.Resources.stat_sys_signal_2;
            trayIcons[2] = NetworkTool.Properties.Resources.stat_sys_signal_3;
            trayIcons[3] = NetworkTool.Properties.Resources.stat_sys_signal_4;
        }

        // creates an animation for tray icon
        private void animateTrayIcon(NotifyIcon n)
        {
            int i = 0;
            while (true)
            {
                try {
                    if (getNetworkStatus()) {
                            // show animated icon
                            if (i >= trayIcons.Length) i = 0;
                            n.Icon = trayIcons[i];
                            Thread.Sleep(400);
                            i++;
                        }
                    else notifyTrayIcon.Icon = NetworkTool.Properties.Resources.stat_sys_signal_0; 
                }
                catch (Exception e) { };
            }
        }

        // Open main window
        private void openWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }


        private void showFilters_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Filters);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Drivers);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showNetworks_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Networks);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showProfiles_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Profiles);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showSettings_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Settings);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showTracing_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Tracing);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showInterfaces_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.Interfaces);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showHostedNetworkInfo_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.HostedNetworks);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showExpCredentials_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.ExplicitCredentials);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void showBlockedNetworks_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = ExecuteCommand(Commands.BlockedNetworks);
                infoTextBox.Clear();
                infoTextBox.Text = r.ReadToEnd().Trim();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a = new AboutForm();
            a.ShowDialog();
        }

        private void configureIPAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureIP4 c = new ConfigureIP4();
            c.Show();
        }
    }
}