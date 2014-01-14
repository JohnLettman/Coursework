using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Change_Pictures
{
    public partial class MainWindow : Form
    {
        private bool pictureViewerOpened = false;
        private PictureViewer pictureViewer;

        public MainWindow()
        {
            InitializeComponent();
            this.picture.DoubleClick += new System.EventHandler(this.openPictureViewer);
        }

        private void reinstatePicture(object sender, EventArgs e)
        {
            this.pictureViewerOpened = false;
            this.picture.Visible = true;
        }

        private void openPictureViewer(object sender, EventArgs e)
        {
            if (!this.pictureViewerOpened)
            {
                this.pictureViewer = new PictureViewer();
                this.pictureViewer.FormClosed += new FormClosedEventHandler(this.reinstatePicture);

                this.pictureViewerOpened = true;
                this.pictureViewer.picture.Image = this.picture.Image;
                this.picture.Visible = false;
                this.pictureViewer.Size = this.picture.Size;

                this.pictureViewer.Show();

            }
        }

        private void showPictureCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.picture.Visible = this.showPictureCheckbox.Checked;
        }

        private void showSelectionsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Disables the ability to switch pictures.
            // Originally, this was done via disabling each radio button, but was later
            // optimized by disabling the entire top table.

            /*
            this.koalaRadio.Enabled = this.lighthouseRadio.Enabled = 
                this.penguinsRadio.Enabled = this.tulipsRadio.Enabled = 
                this.showSelectionsCheckbox.Checked;
             */

            this.topTable.Enabled = this.showSelectionsCheckbox.Checked;
        }

        private void koalaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.koalaRadio.Checked)
            {
                if (this.pictureViewerOpened)
                {
                    this.pictureViewer.picture.Image = Change_Pictures.Properties.Resources.Koala;
                }
                
                this.picture.Image = Change_Pictures.Properties.Resources.Koala;
            }
        }

        private void lighthouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lighthouseRadio.Checked)
            {
                if (this.pictureViewerOpened)
                {
                    this.pictureViewer.picture.Image = Change_Pictures.Properties.Resources.Lighthouse;
                }
                
                this.picture.Image = Change_Pictures.Properties.Resources.Lighthouse;
            }
        }

        private void penguinsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.penguinsRadio.Checked)
            {
                if (this.pictureViewerOpened)
                {
                    this.pictureViewer.picture.Image = Change_Pictures.Properties.Resources.Penguins;
                }
                
                this.picture.Image = Change_Pictures.Properties.Resources.Penguins;
            }
        }

        private void tulipsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tulipsRadio.Checked)
            {
                if (this.pictureViewerOpened)
                {
                    this.pictureViewer.picture.Image = Change_Pictures.Properties.Resources.Tulips;
                }
                
                this.picture.Image = Change_Pictures.Properties.Resources.Tulips;
            }
        }

        private void blackTextRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void blueTextRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Blue;
        }
    }
}
