using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Rental_Car
{
    public partial class MainWindow : Form
    {
        const double RATE_PER_DAY   = 15.00;
        const double RATE_PER_MILE  = 0.12; 

        public MainWindow()
        {
            InitializeComponent();
            this.rentalRateLabel.Text = "*Rental rate: " + RATE_PER_DAY.ToString("C") + "/day + " +
                RATE_PER_MILE.ToString("C") + "/mile.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int miles_driven, odo_start, odo_end, num_days;
            double total_charge = 0.0;

            /*
             * Interpretation
             */

            // odo_start
            try
            {
                odo_start = int.Parse(this.beginningOdoInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Beginning Odometer`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // odo_end
            try
            {
                odo_end = int.Parse(this.endingOdoInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Ending Odometer`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // num_days
            try
            {
                num_days = int.Parse(this.daysInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Number of Days`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /*
             * Error checking
             */

            // Check for negative odometer values
            if (odo_start < 0 || odo_end < 0)
            {
                MessageBox.Show("The odometer values cannot be negative!\n\n" + 
                    "Beginning odometer: " + odo_start.ToString() + "\n" +
                    "Ending odometer: " + odo_end.ToString(), 
                    "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for odometer decrementing
            if (odo_end < odo_start)
            {
                MessageBox.Show("The `Beginning Odometer` is larger than the `Ending Odometer`. " +
                    "This change in value does not make sense; please consider checking your values.\r\r" +
                    "Difference from start to end: " + (odo_end - odo_start).ToString(), 
                    "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for an impossible amount of days
            if (num_days < 1)
            {
                MessageBox.Show("The `Number of Days` is less than 1. " +
                    "This value does not make sense; please consider checking your values.\n\n" +
                    "Provided number of days: " + num_days.ToString(),
                    "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /*
             * Calculation
             */

            miles_driven = odo_end - odo_start;
            total_charge += miles_driven * RATE_PER_MILE;
            total_charge += num_days * RATE_PER_DAY;

            this.milesOutput.Text = miles_driven.ToString() + " miles";
            this.chargeOutput.Text = total_charge.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear boxes
            this.milesOutput.Text = this.chargeOutput.Text =
                this.beginningOdoInput.Text = this.endingOdoInput.Text =
                this.daysInput.Text = "";

            this.beginningOdoInput.Focus();
        }
    }
}
