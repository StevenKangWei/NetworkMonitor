namespace NetworkMonitor
{
    partial class UserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.upload_label = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.download_label = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // upload_label
            // 
            this.upload_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.upload_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_label.ForeColor = System.Drawing.Color.White;
            this.upload_label.Location = new System.Drawing.Point(0, 0);
            this.upload_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upload_label.Name = "upload_label";
            this.upload_label.Size = new System.Drawing.Size(90, 25);
            this.upload_label.TabIndex = 0;
            this.upload_label.Text = "---.-- B/s";
            this.upload_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unregisterToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(147, 52);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // unregisterToolStripMenuItem
            // 
            this.unregisterToolStripMenuItem.Name = "unregisterToolStripMenuItem";
            this.unregisterToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.unregisterToolStripMenuItem.Text = "Unregister";
            this.unregisterToolStripMenuItem.Click += new System.EventHandler(this.unregisterToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // download_label
            // 
            this.download_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.download_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_label.ForeColor = System.Drawing.Color.White;
            this.download_label.Location = new System.Drawing.Point(0, 25);
            this.download_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.download_label.Name = "download_label";
            this.download_label.Size = new System.Drawing.Size(90, 25);
            this.download_label.TabIndex = 2;
            this.download_label.Text = "---.-- B/s";
            this.download_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.download_label);
            this.Controls.Add(this.upload_label);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(90, 50);
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label upload_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem unregisterToolStripMenuItem;
        private System.Windows.Forms.Label download_label;
    }
}
