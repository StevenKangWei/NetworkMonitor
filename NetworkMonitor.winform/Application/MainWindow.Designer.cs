namespace NetworkMonitor
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toggle_button = new System.Windows.Forms.Button();
            this.traffic_timer = new System.Windows.Forms.Timer(this.components);
            this.upload_label = new System.Windows.Forms.Label();
            this.download_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interfaceListbox = new System.Windows.Forms.CheckedListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deskbandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggle_button
            // 
            this.toggle_button.Location = new System.Drawing.Point(246, 9);
            this.toggle_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggle_button.Name = "toggle_button";
            this.toggle_button.Size = new System.Drawing.Size(159, 72);
            this.toggle_button.TabIndex = 0;
            this.toggle_button.Text = "Toggle Band";
            this.toggle_button.UseVisualStyleBackColor = true;
            this.toggle_button.Click += new System.EventHandler(this.toggle_button_Click);
            // 
            // traffic_timer
            // 
            this.traffic_timer.Tick += new System.EventHandler(this.traffic_timer_Tick);
            // 
            // upload_label
            // 
            this.upload_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_label.Location = new System.Drawing.Point(12, 9);
            this.upload_label.Name = "upload_label";
            this.upload_label.Size = new System.Drawing.Size(128, 36);
            this.upload_label.TabIndex = 1;
            this.upload_label.Text = "000.00 B/s";
            this.upload_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // download_label
            // 
            this.download_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_label.Location = new System.Drawing.Point(12, 45);
            this.download_label.Name = "download_label";
            this.download_label.Size = new System.Drawing.Size(128, 36);
            this.download_label.TabIndex = 2;
            this.download_label.Text = "000.00 B/s";
            this.download_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.interfaceListbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Interface";
            // 
            // interfaceListbox
            // 
            this.interfaceListbox.AllowDrop = true;
            this.interfaceListbox.CheckOnClick = true;
            this.interfaceListbox.FormattingEnabled = true;
            this.interfaceListbox.Location = new System.Drawing.Point(3, 26);
            this.interfaceListbox.Name = "interfaceListbox";
            this.interfaceListbox.Size = new System.Drawing.Size(384, 129);
            this.interfaceListbox.TabIndex = 0;
            this.interfaceListbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.interfaceListbox_ItemCheck);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deskbandToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(145, 76);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // deskbandToolStripMenuItem
            // 
            this.deskbandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.unregisterToolStripMenuItem1,
            this.toggleToolStripMenuItem});
            this.deskbandToolStripMenuItem.Name = "deskbandToolStripMenuItem";
            this.deskbandToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.deskbandToolStripMenuItem.Text = "Deskband";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // unregisterToolStripMenuItem1
            // 
            this.unregisterToolStripMenuItem1.Name = "unregisterToolStripMenuItem1";
            this.unregisterToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.unregisterToolStripMenuItem1.Text = "Unregister";
            this.unregisterToolStripMenuItem1.Click += new System.EventHandler(this.unregisterToolStripMenuItem1_Click);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.toggleToolStripMenuItem.Text = "Toggle";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(417, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.download_label);
            this.Controls.Add(this.upload_label);
            this.Controls.Add(this.toggle_button);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggle_button;
        private System.Windows.Forms.Timer traffic_timer;
        private System.Windows.Forms.Label upload_label;
        private System.Windows.Forms.Label download_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox interfaceListbox;
        private System.Windows.Forms.ToolStripMenuItem deskbandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unregisterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toggleToolStripMenuItem;
    }
}

