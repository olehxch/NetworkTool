using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace NetworkTool
{
    public partial class Form1 : Form
    {
        //public String netshNetwork = "netsh wlan set hostednetwork mode=allow ssid=\"MSVWiFi\" key=\"netshkeyadmin\" keyUsage=persistent";
            public String key = "netshkeyadmin";
            public String ssid = "MSVWiFi";
        public String startHostedNetwork = "netsh wlan start hostednetwork";
        public String stopHostedNetwork = "netsh wlan stop hostednetwork";
        public String showHostedNetwork = "netsh wlan show hostednetwork";

        public String balloonTitle = "Virtual WiFi network status";

        public Form1()
        {
            InitializeComponent();
            notifyTrayIcon.Visible = true;
            this.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
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
            // create network
            String c = "netsh wlan set hostednetwork mode=allow ssid=\"" + ssid + "\" key=\"" + key + "\" keyUsage=persistent";
            try
            {
                ExecuteCommand(c);
                ExecuteCommand(startHostedNetwork);

                // check network creation status
                if( getNetworkStatus() )
                    notifyTrayIcon.ShowBalloonTip(3000, balloonTitle, "WiFi network successfully created", ToolTipIcon.Info);
                else notifyTrayIcon.ShowBalloonTip(3000, balloonTitle, "Failed to create network", ToolTipIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex.ToString() ); };
        }

        private void closeNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close created network
            try
            {
                ExecuteCommand(stopHostedNetwork);

                // check network creation status
                if (getNetworkStatus())
                    notifyTrayIcon.ShowBalloonTip(3000, balloonTitle, "WiFi network successfully closed", ToolTipIcon.Info);
                else notifyTrayIcon.ShowBalloonTip(3000, balloonTitle, "Failed to close network", ToolTipIcon.Warning);
            }
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

        // show network status, bssid and number of clients
        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String result = "";
                StreamReader r = ExecuteCommand(showHostedNetwork);
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
                String mod = trimmedResult.Remove(0, trimmedResult.IndexOf("Number of clients"));
                mod = Regex.Replace(mod, @"Number of clients[\s]+:[\t\s]+([\w]+)", "").Trim();

                MatchCollection mc = new Regex(@"[\w\n:]+\s[\w]+").Matches(mod);
                if (status[1].Value == "Not started")
                    result = status[0].Value;
                else
                {
                    result = status[0].Value + "\n" + bssid[0].Value + "\n" + numOfClients[0].Value;
                    foreach (Match i in mc)
                    {
                        result += "\n\t" + i.Value;
                    }
                }

                notifyTrayIcon.ShowBalloonTip(5000, balloonTitle, result, ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        // show network status, bssid and number of clients
        private bool getNetworkStatus()
        {
            try
            {
                StreamReader r = ExecuteCommand(showHostedNetwork);
                String s = r.ReadToEnd();

                String status = new Regex(@"Status[\s]+:[\t\s]+(Started|Not started)").Match(s).Groups[1].Value.Trim();

                // if network started then return true(network is running) else return false(network is not running)
                if (status == "Started") return true;
                    else return false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

    }
}