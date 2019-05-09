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
            this.test_button = new System.Windows.Forms.Button();
            this.traffic_timer = new System.Windows.Forms.Timer(this.components);
            this.upload_label = new System.Windows.Forms.Label();
            this.download_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(142, 6);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(128, 55);
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
            this.upload_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_label.Location = new System.Drawing.Point(12, 9);
            this.upload_label.Name = "upload_label";
            this.upload_label.Size = new System.Drawing.Size(114, 25);
            this.upload_label.TabIndex = 1;
            this.upload_label.Text = "000.00 B/s";
            this.upload_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // download_label
            // 
            this.download_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_label.Location = new System.Drawing.Point(12, 39);
            this.download_label.Name = "download_label";
            this.download_label.Size = new System.Drawing.Size(114, 25);
            this.download_label.TabIndex = 2;
            this.download_label.Text = "000.00 B/s";
            this.download_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(282, 73);
            this.Controls.Add(this.download_label);
            this.Controls.Add(this.upload_label);
            this.Controls.Add(this.test_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 120);
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "NetworkMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Timer traffic_timer;
        private System.Windows.Forms.Label upload_label;
        private System.Windows.Forms.Label download_label;
    }
}

