using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NetworkTool
{
    class WifiNetwork
    {
        public static bool isNetworkRunning = false;

        /*
         * Creates a wifi network as access point
         */ 
        public static void CreateNetwork()
        {
            Execute(Global.CreateNetworkCommand());
            Execute(Global.startHostedNetwork);
            WifiNetwork.isNetworkRunning = true;
        }

        /*
         * Stops current wifi network
         */ 
        public static void StopNetwork()
        {
            Execute(Global.stopHostedNetwork);
            isNetworkRunning = false;
        }

        /*
         * show network status, bssid and number of clients 
         */
        /*public static bool isNetworkRunning()
        {
            string s = Execute(Global.showHostedNetwork);
            String status = new Regex(@"Status[\s]+:[\t\s]+(Started|Not started)").Match(s).Groups[1].Value.Trim();

            // if network started then return true(network is running) else return false(network is not running)
            if (status == "Started") return true;
            else return false;
        }*/

        /*
         * Returns a formatted string with all info about current network
         */ 
        public static string NetworkInfo()
        {
            String result = "";
            String s = Execute(Global.showHostedNetwork);

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
            if (status[1].Value == "")
            {
                result = "Not started";
            }
            else if (status[1].Value == "Not started")
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

            // TODO fix it later
            //if (isNetworkRunning) result = "Network is running";
            //else result = "Network is not running";

            return result;
        }

        /* 
         * executes a command from command line
         */
        private static string Execute(string command)
        {
            string res = "";
            try
            {
                ProcessStartInfo ProcessInfo;
                Process Process;

                // create a new process and execute 'Command'
                ProcessInfo = new ProcessStartInfo("cmd.exe", " /c chcp 65001 && " + command);
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = false;
                ProcessInfo.RedirectStandardOutput = true;
                //ProcessInfo.StandardOutputEncoding = Encoding.GetEncoding(65001);
                Process = Process.Start(ProcessInfo);
                
                res = Process.StandardOutput.ReadToEnd();
            }
            catch (Exception e) { /*MessageBox.Show(e.Message);*/ return res; }
            return res;
        }
    }
}
