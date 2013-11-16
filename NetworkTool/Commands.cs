using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkTool
{
    public sealed class Commands
    {
        private Commands() { }

        public static readonly String key = "netshkeyadmin";
        public static readonly String ssid = "MSVWiFi";
        public static readonly String startHostedNetwork = "netsh wlan start hostednetwork";
        public static readonly String stopHostedNetwork = "netsh wlan stop hostednetwork";
        public static readonly String showHostedNetwork = "netsh wlan show hostednetwork";
        public static readonly String balloonTitle = "Virtual WiFi network status";

        public static readonly String Drivers = "netsh wlan show drivers";
        public static readonly String Interfaces = "netsh wlan show interfaces";
        public static readonly String Filters = "netsh wlan show filters";
        public static readonly String Networks = "netsh wlan show networks";
        public static readonly String Settings = "netsh wlan show settings";
        public static readonly String Profiles = "netsh wlan show profiles";
        public static readonly String Tracing = "netsh wlan show tracing";
        public static readonly String HostedNetworks = "netsh wlan show hostednetwork";
        public static readonly String ExplicitCredentials = "netsh wlan show allowexplicitcreds";
        public static readonly String BlockedNetworks = "netsh wlan show blockednetworks";
    }
}
