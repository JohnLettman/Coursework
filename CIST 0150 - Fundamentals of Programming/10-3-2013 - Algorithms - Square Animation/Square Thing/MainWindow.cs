using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Square_Thing
{
    public partial class MainWindow : Form
    {
        private bool animationEnabled = false;
        
        private bool turnClockwise = true;
        private UInt16 direction = 0, speed = 10;

        public MainWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    this.speedButton_Click(this.speedUpButton, null);
                    break;

                case Keys.Subtract:
                case Keys.OemMinus:
                    this.speedButton_Click(this.speedDownButton, null);
                    break;

                case Keys.X:
                    this.animationEnabled = !this.animationEnabled;
                    break;
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationEnabled)
            {
                switch (direction)
                {
                    case 0:
                        this.animationBox.Left += this.speed;

                        if (this.animationBox.Left >= 
                            this.animationBox.Parent.Width - this.animationBox.Width - 10)
                        {
                            // Bind to the correct X in case of error.
                            this.animationBox.Left = 
                                this.animationBox.Parent.Width - this.animationBox.Width - 10;

                            // Increment to next direction
                            this.direction++;
                        }
                        break;

                    case 1:
                        this.animationBox.Top += this.speed;

                        if (this.animationBox.Top >= 
                            this.animationBox.Parent.Height - this.animationBox.Height - 10)
                        {
                            // Bind to the correct Y in case of error.
                            this.animationBox.Top = 
                                this.animationBox.Parent.Height - this.animationBox.Height - 10;

                            // Increment to next direction
                            this.direction++;
                        }
                        break;

                    case 2:
                        this.animationBox.Left -= this.speed;

                        if (this.animationBox.Left <= 10)
                        {
                            // Bind to the correct X in case of error.
                            this.animationBox.Left = 10;

                            // Increment to next direction
                            this.direction++;
                        }
                        break;

                    case 3:
                        this.animationBox.Top -= this.speed;

                        if (this.animationBox.Location.Y <= 10)
                        {
                            // Bind to the correct Y in case of error.
                            this.animationBox.Top = 10;

                            // Reset to our first direction, 0
                            this.direction = 0;
                        }
                        break;

                }

                this.positionLabel.Text = "Position:\n(" + 
                    this.animationBox.Left.ToString() + ", " + this.animationBox.Top.ToString() + ")";



            }
        }

        private void setColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.animationEnabled = true;
            this.Text = "Chapter 5 Lab: Animation Running";
        }

        private void pauseAnimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.animationEnabled = false;
            this.Text = "Chapter 5 Lab";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toggleDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.turnClockwise = !this.turnClockwise;
        }

        private void setTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = this.ForeColor;
                cd.AllowFullOpen = cd.AnyColor = true;
                cd.ShowDialog();

                // Set whole form color to the color obtained via dialog
                // this will, in turn, render all child objects with this color
                this.ForeColor = cd.Color;
            }
        }

        private void setBoxColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = this.animationBox.BackColor;
                cd.AllowFullOpen = cd.AnyColor = true;
                cd.ShowDialog();

                // Sets the background color of the label or "box" to the
                // color that the user specified in the dialog
                this.animationBox.BackColor = cd.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chapter 5 Lab\nWritten by: John Lettman\n\n-- TOS --\ndont build nuclear submarines with this software");
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            if (sender == this.speedUpButton)
            {
               /* if (this.speed < 20)
                {
                    this.speed++;
                }
                else
                {
                    MessageBox.Show("You can not go any faster than 200 pixels per second.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

                this.speed++;
            }
            else
            {
                if (this.speed > 1)
                {
                    this.speed--;
                }
                else
                {
                    MessageBox.Show("You can not go any slower than 10 pixels per second.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Display new speed
            this.speedLabel.Text = "Speed: " + this.speed.ToString();
        }

        private void keyShortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcuts:\n\n" +
                "x\tToggles the animation.\n" +
                "+\tIncrements the speed.\n" +
                "-\tDecrements the speed.");
        }
    }
}
