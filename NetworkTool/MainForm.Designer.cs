namespace NetworkTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNetworkItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeNetworkItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyTrayIcon
            // 
            this.notifyTrayIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTrayIcon.Icon")));
            this.notifyTrayIcon.Visible = true;
            this.notifyTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.BackColor = System.Drawing.SystemColors.Control;
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNetworkItem,
            this.closeNetworkItem,
            this.toolStripSeparator2,
            this.optionsToolItem,
            this.toolStripSeparator1,
            this.aboutToolItem,
            this.exitItem});
            this.notifyMenu.Name = "contextMenuStrip1";
            this.notifyMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.notifyMenu.Size = new System.Drawing.Size(155, 148);
            // 
            // createNetworkItem
            // 
            this.createNetworkItem.Name = "createNetworkItem";
            this.createNetworkItem.Size = new System.Drawing.Size(154, 22);
            this.createNetworkItem.Text = "Create network";
            this.createNetworkItem.Click += new System.EventHandler(this.createNetworkItem_Click);
            // 
            // closeNetworkItem
            // 
            this.closeNetworkItem.Name = "closeNetworkItem";
            this.closeNetworkItem.Size = new System.Drawing.Size(154, 22);
            this.closeNetworkItem.Text = "Close network";
            this.closeNetworkItem.Click += new System.EventHandler(this.closeNetworkItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // optionsToolItem
            // 
            this.optionsToolItem.Name = "optionsToolItem";
            this.optionsToolItem.Size = new System.Drawing.Size(154, 22);
            this.optionsToolItem.Text = "Options";
            this.optionsToolItem.Click += new System.EventHandler(this.optionsItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // aboutToolItem
            // 
            this.aboutToolItem.Name = "aboutToolItem";
            this.aboutToolItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolItem.Text = "About";
            this.aboutToolItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(154, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(289, 194);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkTool";
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyTrayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem createNetworkItem;
        private System.Windows.Forms.ToolStripMenuItem closeNetworkItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolItem;
    }
}

