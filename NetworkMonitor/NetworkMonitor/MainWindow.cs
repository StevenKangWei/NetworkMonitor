using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitor
{
    public partial class MainWindow : Form
    {
        public Controller controller = null;
        public MainWindow()
        {
            InitializeComponent();
            this.controller = new Controller();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
