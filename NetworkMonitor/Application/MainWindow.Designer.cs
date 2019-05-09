﻿namespace NetworkMonitor
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
            this.test_button = new System.Windows.Forms.Button();
            this.traffic_timer = new System.Windows.Forms.Timer(this.components);
            this.upload_label = new System.Windows.Forms.Label();
            this.download_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDeskbandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceListbox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(246, 9);
            this.test_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(159, 72);
            this.test_button.TabIndex = 0;
            this.test_button.Text = "Toggle Band";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
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
            this.configureToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.closeDeskbandToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(195, 100);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.configureToolStripMenuItem.Text = "Configuration";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeDeskbandToolStripMenuItem
            // 
            this.closeDeskbandToolStripMenuItem.Name = "closeDeskbandToolStripMenuItem";
            this.closeDeskbandToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.closeDeskbandToolStripMenuItem.Text = "Toggle Deskband";
            this.closeDeskbandToolStripMenuItem.Click += new System.EventHandler(this.toggleDeskbandToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(417, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.download_label);
            this.Controls.Add(this.upload_label);
            this.Controls.Add(this.test_button);
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

        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Timer traffic_timer;
        private System.Windows.Forms.Label upload_label;
        private System.Windows.Forms.Label download_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDeskbandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox interfaceListbox;
    }
}
