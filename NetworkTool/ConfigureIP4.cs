using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;

namespace NetworkTool
{
    public partial class ConfigureIP4 : Form
    {
        public ConfigureIP4()
        {
            InitializeComponent();
            IPVariant.SelectedIndex = 0;
        }

        // set settings
        private void button1_Click(object sender, EventArgs e)
        {
            string conname = tbConName.Text;
            if (IPVariant.SelectedIndex > 0)
            {
                try
                {
                    ExecuteCommand(Commands.getDynamicIPv4(conname));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                string ip = tbIp4Address.Text;
                string subnet = tbSubnetMask.Text;
                string dns1 = tbDNSServer1.Text;
                string dns2 = tbDNSServer2.Text;
                string gateway = tbGateway.Text;

                try
                {
                    StreamReader r = ExecuteCommand(Commands.getStaticIPv4(conname, ip, subnet));
                    string res = r.ReadToEnd().Trim();
                    if (res != "")
                    {
                        statusLabel.Text = "Error";
                        MessageBox.Show(res);
                    }
                    else statusLabel.Text = "OK";

                    r = ExecuteCommand(Commands.getDNS1(conname, dns1));
                    res = r.ReadToEnd().Trim();
                    if (res != "")
                    {
                        statusLabel.Text = "Error";
                        MessageBox.Show(res);
                    }
                    else statusLabel.Text = "OK";

                    r = ExecuteCommand(Commands.getDNS2(conname, dns2));
                    res = r.ReadToEnd().Trim();
                    if (res != "")
                    {
                        statusLabel.Text = "Error";
                        MessageBox.Show(res);
                    }
                    else statusLabel.Text = "OK";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            } 
        }

        // get
        private void IPVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IPVariant.SelectedIndex > 0)
                groupStatic.Enabled = false;
            else groupStatic.Enabled = true;
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
