using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Menus_Demo
{
    public partial class MainWindow : Form
    {
        float fontSize = 8;
        bool floatingLabelReturn = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.clockLabel.ForeColor;
            cd.ShowDialog();

            this.clockLabel.ForeColor = cd.Color;
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = this.clockLabel.Font;
            fd.ShowDialog();

            this.clockLabel.Font = fd.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is self-aware and knows what you do at night.", 
                "About me", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToLongTimeString();

            // Zooming
            this.fontSize = (fontSize + 3.5f) % 40;
            this.clockLabel.Font = new Font(this.clockLabel.Font.Name, this.fontSize + 1);

            if (this.floatingLabelReturn)
            {
                this.floatingLabel.Left -= 5;
            }
            else
            {
                this.floatingLabel.Left += 5;
            }

            if (this.floatingLabel.Left >= (this.Width - this.floatingLabel.Width - 5) || 
                this.floatingLabel.Left <= 0)
            {
                this.floatingLabelReturn = !this.floatingLabelReturn;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.floatingLabel.ForeColor;
            cd.ShowDialog();

            this.floatingLabel.ForeColor = cd.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = this.floatingLabel.Font;
            fd.ShowDialog();

            this.floatingLabel.Font = fd.Font;
        }


    }
}
