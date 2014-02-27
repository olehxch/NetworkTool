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
        public OptionsForm()
        {
            InitializeComponent();
        }

        /*
         * Close options window
         */ 
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Save changed settings
         */ 
        private void btOK_Click(object sender, EventArgs e)
        {
            Global.WifiName = tbWifiName.Text;
            Global.WifiPassword = tbPassword.Text;

            if (rbYes.Checked) Global.Autostart = true;
            else Global.Autostart = false;
             
            this.Close();
        }

        /*
         * Load saved settings
         */
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            tbWifiName.Text = Global.WifiName;
            tbPassword.Text = Global.WifiPassword;

            if (Global.Autostart) rbYes.Checked = true;
            else rbNo.Checked = true;
        }

        /*
         * Validate wifi name
         */
        private void tbWifiName_TextChanged(object sender, EventArgs e)
        {
            if (tbWifiName.Text == "")
            {
                tbWifiName.BackColor = Color.OrangeRed;
                btOK.Enabled = false;
            } else {
                tbWifiName.BackColor = Color.White;
                if (tbWifiName.Text != "" && tbPassword.Text != "")
                    btOK.Enabled = true;
            }
        }

        /*
         * Validate wifi password
         */
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length < 8) {
                tbPassword.BackColor = Color.OrangeRed;
                btOK.Enabled = false;
            } else {
                tbPassword.BackColor = Color.White;
                if (tbWifiName.Text != "" && tbPassword.Text.Length >= 8)
                    btOK.Enabled = true;
            }
        }
    }
}
