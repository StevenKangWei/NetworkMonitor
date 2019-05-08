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
        public UserControl usercontrol = null;
        public MainWindow()
        {
            InitializeComponent();
            this.controller = new Controller();
       
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            controller.registerBand();
            MessageBox.Show("Register success!");
        }

        private void unregister_button_Click(object sender, EventArgs e)
        {
            controller.unregisterBand();
            MessageBox.Show("Unregister success!");
        }
    }
}
