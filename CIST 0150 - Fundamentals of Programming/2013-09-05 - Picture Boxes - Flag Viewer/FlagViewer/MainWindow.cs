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

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Flag_Viewer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void unitedStatesFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.US;
            this.countryLabel.Text = "United States of America";
        }

        private void japanFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.Japan;
            this.countryLabel.Text = "Japan";
        }

        private void mexicoFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.Mexico;
            this.countryLabel.Text = "Mexico";
        }

        private void russiaFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.Russia;
            this.countryLabel.Text = "Russia";
        }

        private void chinaFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.China;
            this.countryLabel.Text = "China";
        }

        private void canadaFlagRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.flagImage.Image = Flag_Viewer.Properties.Resources.Canada;
            this.countryLabel.Text = "Canada";
        }

        private void titleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.titlePanel.Visible = this.titleCheckbox.Checked;
        }

        private void countryNameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.countryNamePanel.Visible = this.countryNameCheckbox.Checked;
        }

        private void programmerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.creditsPanel.Visible = this.programmerCheckbox.Checked;
        }

        private void programmerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:jlettman@acm.org");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
