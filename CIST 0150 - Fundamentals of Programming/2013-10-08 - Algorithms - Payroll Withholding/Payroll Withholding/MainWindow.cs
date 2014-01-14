using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Payroll_Withholding
{
    public partial class MainWindow : Form
    {
        private const double
            FILING_STATUS_SINGLE = 0.18,
            FILING_STATUS_FAMILY = 0.15;

        private const double
            STATE_TAX_PA = 0.0307,
            STATE_TAX_NY = 0.05;

        private const double FICA = 0.0765;


        public MainWindow()
        {
            InitializeComponent();

            // First timer tick
            this.clockTimer_Tick(null, null);

            // Have text match algorithm
            this.singleRateRadio.Text = "&Single Rate (" + FILING_STATUS_SINGLE.ToString("P") + ")";
            this.familyRateRadio.Text = "Fa&mily Rate (" + FILING_STATUS_FAMILY.ToString("P") + ")";

            this.pennsylvaniaRadio.Text = "&Pennsylvania (" + STATE_TAX_PA.ToString("P") + ")";
            this.newYorkRadio.Text = "New &York (" + STATE_TAX_NY.ToString("P") + ")";

            this.ficaLabel.Text = "FICA (" + FICA.ToString("P") + "):";
        }

        private void itemChanged(object sender, EventArgs e)
        {
            double hours_worked, pay_per_hour;
            double gross_pay, fica_amount, pay_after_fica;
            double fed_income_tax, state_income_tax = 0.0, net_pay;

            // Reset outputs
            this.grossPayOutput.Text = this.ficaOutput.Text = this.payAfterFicaOutput.Text =
                this.fedIncomeTaxOutput.Text = this.stateIncomeTaxOutput.Text =
                this.netPayOutput.Text = "";

            /*
             * Convert text inputs
             */

            try
            {
                hours_worked = double.Parse(this.hoursWorkedInput.Text);
            }
            catch (Exception ex)
            {
                // Don't calculate,
                return;
            }

            try
            {
                pay_per_hour = double.Parse(this.payPerHourInput.Text);
            }
            catch (Exception ex)
            {
                // Don't calculate,
                return;
            }


            /*
             * Algorithm
             */

            // Top section calculations
            gross_pay = hours_worked * pay_per_hour;
            fica_amount = gross_pay * FICA;
            pay_after_fica = gross_pay - fica_amount;

            

            // Bottom section calculations
            // (fed)
            if (this.singleRateRadio.Checked)
            {
                fed_income_tax = gross_pay * FILING_STATUS_SINGLE;
            }
            else if (this.familyRateRadio.Checked)
            {
                fed_income_tax = gross_pay * FILING_STATUS_FAMILY;
            }
            else
            {
                // Not enough information was provided to continue our 
                // calculations, returning from the function to exit
                return;
            }

            // (state)
            if (this.pennsylvaniaRadio.Checked)
            {
                state_income_tax = gross_pay * STATE_TAX_PA;
            }
            else if (this.newYorkRadio.Checked)
            {
                state_income_tax = gross_pay * STATE_TAX_NY;
            }
            // we assume other if not NY or PA

            net_pay = pay_after_fica - (state_income_tax + fed_income_tax);


            /*
             * Draw answers
             */

            this.grossPayOutput.Text = gross_pay.ToString("C");
            this.ficaOutput.Text = fica_amount.ToString("C");
            this.payAfterFicaOutput.Text = pay_after_fica.ToString("C");

            this.fedIncomeTaxOutput.Text = fed_income_tax.ToString("C");
            this.stateIncomeTaxOutput.Text = state_income_tax.ToString("C");
            this.netPayOutput.Text = net_pay.ToString("C");
        }

        private void itemKeyUp(object sender, KeyEventArgs e)
        {
            // Handles changes in the textboxes
            this.itemChanged(sender, null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by John Lettman\n\nPlease don't do taxes with this- well, I guess the government is shutdown and you don't have to worry, but the concern is still there. How's the weather in Bradford? Bad? I know. It is.");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear textual inputs and outputs
            this.payPerHourInput.Text = this.hoursWorkedInput.Text = this.grossPayOutput.Text =
                this.ficaOutput.Text = this.payAfterFicaOutput.Text =
                this.fedIncomeTaxOutput.Text = this.stateIncomeTaxOutput.Text =
                this.netPayOutput.Text = "";

            // Reset the radio states
            this.familyRateRadio.Checked = this.newYorkRadio.Checked = this.otherStatesRadio.Checked =
                this.pennsylvaniaRadio.Checked = this.singleRateRadio.Checked = false;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToLongDateString() + " " +
                DateTime.Now.ToLongTimeString();
        }
    }
}
