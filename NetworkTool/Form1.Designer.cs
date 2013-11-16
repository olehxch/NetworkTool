namespace NetworkTool
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.Info = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showHostedNetworkInfo = new System.Windows.Forms.Button();
            this.showInterfaces = new System.Windows.Forms.Button();
            this.showTracing = new System.Windows.Forms.Button();
            this.showSettings = new System.Windows.Forms.Button();
            this.showProfiles = new System.Windows.Forms.Button();
            this.showNetworks = new System.Windows.Forms.Button();
            this.showFilters = new System.Windows.Forms.Button();
            this.showDrivers = new System.Windows.Forms.Button();
            this.notifyMenuStrip.SuspendLayout();
            this.Info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyTrayIcon
            // 
            this.notifyTrayIcon.ContextMenuStrip = this.notifyMenuStrip;
            this.notifyTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTrayIcon.Icon")));
            this.notifyTrayIcon.Visible = true;
            this.notifyTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWindowToolStripMenuItem,
            this.toolStripSeparator3,
            this.createNetworkToolStripMenuItem,
            this.closeNetworkToolStripMenuItem,
            this.showStatusToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyMenuStrip.Name = "contextMenuStrip1";
            this.notifyMenuStrip.Size = new System.Drawing.Size(179, 176);
            this.notifyMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.notifyMenuStrip_Opening);
            // 
            // openWindowToolStripMenuItem
            // 
            this.openWindowToolStripMenuItem.Name = "openWindowToolStripMenuItem";
            this.openWindowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openWindowToolStripMenuItem.Text = "Open main window";
            this.openWindowToolStripMenuItem.Click += new System.EventHandler(this.openWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // createNetworkToolStripMenuItem
            // 
            this.createNetworkToolStripMenuItem.Name = "createNetworkToolStripMenuItem";
            this.createNetworkToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.createNetworkToolStripMenuItem.Text = "Create network";
            this.createNetworkToolStripMenuItem.Click += new System.EventHandler(this.createNetworkToolStripMenuItem_Click);
            // 
            // closeNetworkToolStripMenuItem
            // 
            this.closeNetworkToolStripMenuItem.Name = "closeNetworkToolStripMenuItem";
            this.closeNetworkToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.closeNetworkToolStripMenuItem.Text = "Close network";
            this.closeNetworkToolStripMenuItem.Click += new System.EventHandler(this.closeNetworkToolStripMenuItem_Click);
            // 
            // showStatusToolStripMenuItem
            // 
            this.showStatusToolStripMenuItem.Name = "showStatusToolStripMenuItem";
            this.showStatusToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.showStatusToolStripMenuItem.Text = "Show status";
            this.showStatusToolStripMenuItem.Click += new System.EventHandler(this.showStatusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextBox.Location = new System.Drawing.Point(3, 16);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(429, 340);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "";
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Info.Controls.Add(this.infoTextBox);
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(435, 359);
            this.Info.TabIndex = 2;
            this.Info.TabStop = false;
            this.Info.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.showHostedNetworkInfo);
            this.groupBox1.Controls.Add(this.showInterfaces);
            this.groupBox1.Controls.Add(this.showTracing);
            this.groupBox1.Controls.Add(this.showSettings);
            this.groupBox1.Controls.Add(this.showProfiles);
            this.groupBox1.Controls.Add(this.showNetworks);
            this.groupBox1.Controls.Add(this.showFilters);
            this.groupBox1.Controls.Add(this.showDrivers);
            this.groupBox1.Location = new System.Drawing.Point(453, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(151, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // showHostedNetworkInfo
            // 
            this.showHostedNetworkInfo.Location = new System.Drawing.Point(6, 223);
            this.showHostedNetworkInfo.Name = "showHostedNetworkInfo";
            this.showHostedNetworkInfo.Size = new System.Drawing.Size(139, 23);
            this.showHostedNetworkInfo.TabIndex = 7;
            this.showHostedNetworkInfo.Text = "Show hosted network";
            this.showHostedNetworkInfo.UseVisualStyleBackColor = true;
            this.showHostedNetworkInfo.Click += new System.EventHandler(this.showHostedNetworkInfo_Click);
            // 
            // showInterfaces
            // 
            this.showInterfaces.Location = new System.Drawing.Point(6, 194);
            this.showInterfaces.Name = "showInterfaces";
            this.showInterfaces.Size = new System.Drawing.Size(139, 23);
            this.showInterfaces.TabIndex = 6;
            this.showInterfaces.Text = "Show interfaces";
            this.showInterfaces.UseVisualStyleBackColor = true;
            this.showInterfaces.Click += new System.EventHandler(this.showInterfaces_Click);
            // 
            // showTracing
            // 
            this.showTracing.Location = new System.Drawing.Point(6, 165);
            this.showTracing.Name = "showTracing";
            this.showTracing.Size = new System.Drawing.Size(139, 23);
            this.showTracing.TabIndex = 5;
            this.showTracing.Text = "Show tracing";
            this.showTracing.UseVisualStyleBackColor = true;
            this.showTracing.Click += new System.EventHandler(this.showTracing_Click);
            // 
            // showSettings
            // 
            this.showSettings.Location = new System.Drawing.Point(6, 136);
            this.showSettings.Name = "showSettings";
            this.showSettings.Size = new System.Drawing.Size(139, 23);
            this.showSettings.TabIndex = 4;
            this.showSettings.Text = "Show settings";
            this.showSettings.UseVisualStyleBackColor = true;
            this.showSettings.Click += new System.EventHandler(this.showSettings_Click);
            // 
            // showProfiles
            // 
            this.showProfiles.Location = new System.Drawing.Point(6, 107);
            this.showProfiles.Name = "showProfiles";
            this.showProfiles.Size = new System.Drawing.Size(139, 23);
            this.showProfiles.TabIndex = 3;
            this.showProfiles.Text = "Show profiles";
            this.showProfiles.UseVisualStyleBackColor = true;
            this.showProfiles.Click += new System.EventHandler(this.showProfiles_Click);
            // 
            // showNetworks
            // 
            this.showNetworks.Location = new System.Drawing.Point(6, 78);
            this.showNetworks.Name = "showNetworks";
            this.showNetworks.Size = new System.Drawing.Size(139, 23);
            this.showNetworks.TabIndex = 2;
            this.showNetworks.Text = "Show networks";
            this.showNetworks.UseVisualStyleBackColor = true;
            this.showNetworks.Click += new System.EventHandler(this.showNetworks_Click);
            // 
            // showFilters
            // 
            this.showFilters.Location = new System.Drawing.Point(6, 49);
            this.showFilters.Name = "showFilters";
            this.showFilters.Size = new System.Drawing.Size(139, 23);
            this.showFilters.TabIndex = 1;
            this.showFilters.Text = "Show filters";
            this.showFilters.UseVisualStyleBackColor = true;
            this.showFilters.Click += new System.EventHandler(this.showFilters_Click);
            // 
            // showDrivers
            // 
            this.showDrivers.Location = new System.Drawing.Point(6, 20);
            this.showDrivers.Name = "showDrivers";
            this.showDrivers.Size = new System.Drawing.Size(139, 23);
            this.showDrivers.TabIndex = 0;
            this.showDrivers.Text = "Show Drivers";
            this.showDrivers.UseVisualStyleBackColor = true;
            this.showDrivers.Click += new System.EventHandler(this.showDrivers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notifyMenuStrip.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyTrayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem createNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusToolStripMenuItem;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem openWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button showDrivers;
        private System.Windows.Forms.Button showFilters;
        private System.Windows.Forms.Button showNetworks;
        private System.Windows.Forms.Button showProfiles;
        private System.Windows.Forms.Button showSettings;
        private System.Windows.Forms.Button showTracing;
        private System.Windows.Forms.Button showInterfaces;
        private System.Windows.Forms.Button showHostedNetworkInfo;
    }
}

