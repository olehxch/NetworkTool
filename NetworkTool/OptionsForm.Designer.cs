namespace NetworkTool
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.tbSSID = new System.Windows.Forms.TextBox();
            this.lSSID = new System.Windows.Forms.Label();
            this.lKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSSID
            // 
            this.tbSSID.Location = new System.Drawing.Point(12, 28);
            this.tbSSID.Name = "tbSSID";
            this.tbSSID.Size = new System.Drawing.Size(237, 20);
            this.tbSSID.TabIndex = 0;
            this.tbSSID.Text = "MSVWiFi";
            // 
            // lSSID
            // 
            this.lSSID.AutoSize = true;
            this.lSSID.Location = new System.Drawing.Point(10, 12);
            this.lSSID.Name = "lSSID";
            this.lSSID.Size = new System.Drawing.Size(32, 13);
            this.lSSID.TabIndex = 1;
            this.lSSID.Text = "SSID";
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Location = new System.Drawing.Point(10, 54);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(25, 13);
            this.lKey.TabIndex = 2;
            this.lKey.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 70);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(237, 20);
            this.tbKey.TabIndex = 3;
            this.tbKey.Text = "netshkeyadmin";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 96);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(93, 96);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.lSSID);
            this.Controls.Add(this.tbSSID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkTool - Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSSID;
        private System.Windows.Forms.Label lSSID;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button1;
    }
}