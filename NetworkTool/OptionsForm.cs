using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTool
{
    public partial class OptionsForm : Form
    {
        public delegate void dSetSSIDKEY(String ssid, String key);
        public delegate String[] dGetSSIDKEY();
        dSetSSIDKEY d;
        String[] s;
        public OptionsForm(dSetSSIDKEY dSet, dGetSSIDKEY dGet)
        {
            this.d = dSet;
            s = dGet();
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            // close options form
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // accept changes and update ssid/key
            d(tbSSID.Text, tbKey.Text);
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            tbSSID.Text = s[0];
            tbKey.Text = s[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // restore defaults
            tbSSID.Text = "MSVWiFi";
            tbKey.Text = "netshkeyadmin";
        }
    }
}
