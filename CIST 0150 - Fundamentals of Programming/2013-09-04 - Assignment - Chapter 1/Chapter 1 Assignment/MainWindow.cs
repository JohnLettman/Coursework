using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Chapter_1_Assignment
{
    public partial class MainWindow : Form
    {
        bool fullNameToggle = false, 
            majorToggle = false, 
            telephoneToggle = false,
            mePictureToggle = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this window
        }

        private void consider_image()
        {
            this.havePictureLink.Visible = this.mePictureToggle || 
                (this.fullNameToggle && this.majorToggle && this.telephoneToggle);
        }

        private void fullNameButton_Click(object sender, EventArgs e)
        {
            this.fullNameToggle = !this.fullNameToggle;

            if (this.fullNameToggle)
            {
                this.fullNameLabel.Text = "John P. Lettman";
            }
            else
            {
                this.fullNameLabel.Text = "";
            }

            this.consider_image();
        }

        private void majorButton_Click(object sender, EventArgs e)
        {
            this.majorToggle = !this.majorToggle;

            if (this.majorToggle)
            {
                this.majorLabel.Text = "CIST";
            }
            else
            {
                this.majorLabel.Text = "";
            }

            this.consider_image();
        }

        private void telephoneButton_Click(object sender, EventArgs e)
        {
            this.telephoneToggle = !this.telephoneToggle;

            if (this.telephoneToggle)
            {
                this.telephoneLabel.Text = "(484) 365-3759";
            }
            else
            {
                this.telephoneLabel.Text = "";
            }

            this.consider_image();
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:jlettman@acm.org");
        }

        private void havePictureLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mePictureToggle = !this.mePictureToggle;

            // Apply the toggle value to the visiblity directly,
            this.mePicture.Visible = this.mePictureToggle;
            this.consider_image();
        }
    }
}
