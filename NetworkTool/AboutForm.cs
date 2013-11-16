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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = "About NetworkTool " + Properties.Resources.Version;
            this.linkToSourceCode.Text = Properties.Resources.Website;
            this.lastBuildDate.Text = Properties.Resources.LastBuildDate;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.Website);  
        }
    }
}
