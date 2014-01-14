using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.HelloWorldGUI
{
    public partial class MainWindow : Form
    {
        bool toggle = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            this.toggle = !this.toggle;
            this.thisToggleLabel.Text = "this.toggle = " + this.toggle.ToString();

            if (this.toggle)
            {
                this.welloWorldLabel.Text = "Wello World";
            }
            else
            {
                this.welloWorldLabel.Text = "";
            }
        }
    }
}
