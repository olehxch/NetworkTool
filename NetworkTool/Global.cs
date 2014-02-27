using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetworkTool.Properties;

namespace NetworkTool
{
    public sealed class Global
    {
        private Global() {}

        public static readonly String startHostedNetwork = "netsh wlan start hostednetwork";
        public static readonly String stopHostedNetwork  = "netsh wlan stop hostednetwork";
        public static readonly String showHostedNetwork  = "netsh wlan show hostednetwork";
        public static readonly String balloonTitle       = "Virtual wifi status";
        
        public static string WifiName {
            get { return Settings.Default.WiFiName;  }
            set { Settings.Default.WiFiName = value; Settings.Default.Save(); }
        }

        public static string WifiPassword {
            get { return Settings.Default.WiFiPassword;  }
            set { Settings.Default.WiFiPassword = value; Settings.Default.Save(); }
        }

        public static string Lang {
            get { return Settings.Default.Lang;  }
            set { Settings.Default.Lang = value; Settings.Default.Save(); }
        }

        public static bool Autostart {
            get { return Settings.Default.Autostart;  }
            set { Settings.Default.Autostart = value; Settings.Default.Save(); }
        }

        public static string CreateNetworkCommand()
        {
            return "netsh wlan set hostednetwork mode=allow ssid=\"" + Settings.Default.WiFiName + "\" key=\"" + Settings.Default.WiFiPassword + "\" keyUsage=persistent";
        }
    }
}
