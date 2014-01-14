using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Catherines_Catering
{
    public partial class MainWindow : Form
    {
        const double PRICE_PRIME_RIB    = 25.95,
            PRICE_CHICKEN               = 18.95,
            PRICE_PASTA                 = 12.95,
            PRICE_OPEN_BAR              = 25.00,
            PRICE_WINE                  = 8.00;



        public MainWindow()
        {
            InitializeComponent();
            this.numberOfGuestsInput.Focus();

            this.Resize += new EventHandler(ee);
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        private void ee(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.FromArgb(
                   // 0xFF, 
                    (0xFF * (this.Width / 25)) & 0xFF, 
                    0xF0,
                    (0xFF * (this.Height / 25)) & 0xFF);
            }
            catch { }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double amount_due = 0.0;
            uint number_of_guests;

            // Obtain number of guests
            try
            {
                number_of_guests = uint.Parse(this.numberOfGuestsInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Number of Guests`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtain menu selection
            if (this.chickenRadio.Checked)
            {
                amount_due += PRICE_CHICKEN;
            }
            else if (this.pastaRadio.Checked)
            {
                amount_due += PRICE_PASTA;
            }
            else if (this.primeRibRadio.Checked)
            {
                amount_due += PRICE_PRIME_RIB;
            }

            // Obtain bar selection
            if (this.openBarCheck.Checked)
            {
                amount_due += PRICE_OPEN_BAR;
            }

            if (this.wineCheck.Checked)
            {
                amount_due += PRICE_WINE;
            }

            // BLACK MAGIC
            amount_due *= number_of_guests;

            this.amountDueOutput.Text = amount_due.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear inputs and outputs
            this.numberOfGuestsInput.Text = this.amountDueOutput.Text = "";
            
            // Uncheck all
            this.wineCheck.Checked = this.openBarCheck.Checked = this.chickenRadio.Checked = 
                this.pastaRadio.Checked = this.primeRibRadio.Checked = false;

            // Focus
            this.numberOfGuestsInput.Focus();
        }
    }
}
