namespace NetworkTool
{
    partial class ConfigureIP4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSave = new System.Windows.Forms.Button();
            this.groupStatic = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDNSServer2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNSServer1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubnetMask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIp4Address = new System.Windows.Forms.TextBox();
            this.IPVariant = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConName = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupStatic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(118, 228);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupStatic
            // 
            this.groupStatic.Controls.Add(this.label5);
            this.groupStatic.Controls.Add(this.tbDNSServer2);
            this.groupStatic.Controls.Add(this.label4);
            this.groupStatic.Controls.Add(this.tbDNSServer1);
            this.groupStatic.Controls.Add(this.label3);
            this.groupStatic.Controls.Add(this.tbGateway);
            this.groupStatic.Controls.Add(this.label2);
            this.groupStatic.Controls.Add(this.tbSubnetMask);
            this.groupStatic.Controls.Add(this.label1);
            this.groupStatic.Controls.Add(this.tbIp4Address);
            this.groupStatic.Location = new System.Drawing.Point(13, 66);
            this.groupStatic.Name = "groupStatic";
            this.groupStatic.Size = new System.Drawing.Size(261, 156);
            this.groupStatic.TabIndex = 1;
            this.groupStatic.TabStop = false;
            this.groupStatic.Text = "Static";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNS Server 2";
            // 
            // tbDNSServer2
            // 
            this.tbDNSServer2.Location = new System.Drawing.Point(92, 121);
            this.tbDNSServer2.Name = "tbDNSServer2";
            this.tbDNSServer2.Size = new System.Drawing.Size(100, 20);
            this.tbDNSServer2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNS Server 1";
            // 
            // tbDNSServer1
            // 
            this.tbDNSServer1.Location = new System.Drawing.Point(92, 95);
            this.tbDNSServer1.Name = "tbDNSServer1";
            this.tbDNSServer1.Size = new System.Drawing.Size(100, 20);
            this.tbDNSServer1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gateway";
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(92, 69);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(100, 20);
            this.tbGateway.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            // 
            // tbSubnetMask
            // 
            this.tbSubnetMask.Location = new System.Drawing.Point(92, 43);
            this.tbSubnetMask.Name = "tbSubnetMask";
            this.tbSubnetMask.Size = new System.Drawing.Size(100, 20);
            this.tbSubnetMask.TabIndex = 2;
            this.tbSubnetMask.Text = "255.255.255.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IPv4 address";
            // 
            // tbIp4Address
            // 
            this.tbIp4Address.Location = new System.Drawing.Point(92, 17);
            this.tbIp4Address.Name = "tbIp4Address";
            this.tbIp4Address.Size = new System.Drawing.Size(100, 20);
            this.tbIp4Address.TabIndex = 0;
            this.tbIp4Address.Text = "192.168.137.1";
            // 
            // IPVariant
            // 
            this.IPVariant.FormattingEnabled = true;
            this.IPVariant.Items.AddRange(new object[] {
            "Static",
            "Dynamic"});
            this.IPVariant.Location = new System.Drawing.Point(13, 13);
            this.IPVariant.Name = "IPVariant";
            this.IPVariant.Size = new System.Drawing.Size(260, 21);
            this.IPVariant.TabIndex = 2;
            this.IPVariant.SelectedIndexChanged += new System.EventHandler(this.IPVariant_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(199, 228);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Connection name";
            // 
            // tbConName
            // 
            this.tbConName.Location = new System.Drawing.Point(112, 40);
            this.tbConName.Name = "tbConName";
            this.tbConName.Size = new System.Drawing.Size(161, 20);
            this.tbConName.TabIndex = 10;
            this.tbConName.Text = "Підключення через локальну мережу* 14";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 229);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status";
            // 
            // ConfigureIP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(285, 263);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbConName);
            this.Controls.Add(this.IPVariant);
            this.Controls.Add(this.groupStatic);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigureIP4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure IPv4";
            this.groupStatic.ResumeLayout(false);
            this.groupStatic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupStatic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubnetMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIp4Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDNSServer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNSServer1;
        private System.Windows.Forms.ComboBox IPVariant;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbConName;
        private System.Windows.Forms.Label statusLabel;
    }
}