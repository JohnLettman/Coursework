using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.If_statement
{
    public partial class Form1 : Form
    {
        Label[] rbs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crbButtons_Click(object sender, EventArgs e)
        {
            string message = "";

            if (this.appleRadioButton.Checked)
            {
                message = "You picked Apple.";
            }
            else if (this.bananaRadioButton.Checked)
            {
                message = "You picked Banana.";
            }
            else if (this.cranberryRadioButton.Checked)
            {
                message = "You picked Cranberry.";
            }
            else
            {
                message = "You picked nothing or all of logic no longer makes sense.";
            }

            if (this.checkBox.Checked)
            {
                this.rbs = new Label[0x1001];

                for (int c = 0x000000, i = 0; c < 0xFFFFFF; c += 0xFFF, i++)
                {
                    this.rbs[i] = new Label();
                    this.rbs[i].Text = message;
                    this.rbs[i].Location = new Point(12, 116);
                    this.rbs[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.rbs[i].ForeColor = Color.FromArgb(c);
                    this.rbs[i].Visible = true;
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void ccbButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (this.appleCheck.Checked)
            {
                message += "You picked Apple.\n";
            }

             if (this.bananaCheck.Checked)
            {
                message += "You picked Banana.\n";
            }
             if (this.cranberryCheck.Checked)
            {
                message += "You picked Cranberry.\n";
            }

             if (!this.appleCheck.Checked && !this.bananaCheck.Checked &&
                 !this.cranberryCheck.Checked)
             {
                 message = "Please pick a fruit.";
             }

             MessageBox.Show(message);
        }
    }
}
