using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Campus_Information
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            // Initialize the component using the Visual Studio's generate
            // winforms code.
            InitializeComponent();
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Use the process launcher to open the default mail client with
            // my email address.
            Process.Start("mailto:jlettman@acm.org");
        }

        private void studentLearningButton_Click(object sender, EventArgs e)
        {
            this.timesLabel.Text = "8:00 AM - 5:00 PM";
        }

        private void financialAidButton_Click(object sender, EventArgs e)
        {
            this.timesLabel.Text = "6:30 AM - 8:00 PM";
        }

        private void counselingButton_Click(object sender, EventArgs e)
        {
            this.timesLabel.Text = "8:00 AM - 7:00 PM";
        }

        private void bookstoreButton_Click(object sender, EventArgs e)
        {
            this.timesLabel.Text = "8:00 AM - 10:00 PM";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
            Application.Exit(); // Close the application
        }
    }
}
