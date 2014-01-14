// CIST 0150 EXAM 1

// YOUR NAME: JOHN LETTMAN

// DATE: October 10, 2013

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //to DllImport

namespace PizzaShop
{
    public partial class MainWindow : Form
    {
        // The price constants have been declared for you.

        const decimal PEPPERONI_decimal = 12.99m;
        const decimal MEATLOVER_decimal = 13.99m;
        const decimal PINEAPPLE_decimal = 10.99m;
        const decimal VEGGIE_decimal = 9.99m;
        const decimal COKE_decimal = 1.99m;
        const decimal BOTTLEWATER_decimal = 0.99m;
        const decimal FISHFRIES_decimal = 2.99m;

        bool showClock = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            decimal unit_cost = 0.0m;

            /*
             * Pizza selection
             */

            if (this.radPepperoni.Checked)
            {
                unit_cost += PEPPERONI_decimal;
                this.pizzaPictureBox.Image = PizzaShop.Properties.Resources.pepperoni;
            }
            else if (this.radPineapple.Checked)
            {
                unit_cost += PINEAPPLE_decimal;
                this.pizzaPictureBox.Image = PizzaShop.Properties.Resources.pineapple;
            }
            else if (this.radVeggie.Checked)
            {
                unit_cost += VEGGIE_decimal;
                this.pizzaPictureBox.Image = PizzaShop.Properties.Resources.veggie;
            }
            else if (this.radMeatlover.Checked)
            {
                unit_cost += MEATLOVER_decimal;
                this.pizzaPictureBox.Image = PizzaShop.Properties.Resources.meatlover;
            }

            /*
             * Sides selection
             */

            if (this.chkCoke.Checked)
            {
                unit_cost += COKE_decimal;
            }

            if (this.chkFries.Checked)
            {
                unit_cost += FISHFRIES_decimal;
            }

            if (this.chkWater.Checked)
            {
                unit_cost += BOTTLEWATER_decimal;
            }

            /*
             * First section output
             */

            this.txtPizzaDrinks.Text = unit_cost.ToString("C");

            /*
             * Attempt to parse second section
             */

            uint quantity;

            try
            {
                // Attempt to parse as an unsigned quantity
                quantity = uint.Parse(this.txtQuantity.Text);
            }
            catch (Exception ex)
            {
                this.txtTotal.Text = "";

                if (sender == this.btnTotal)
                {
                    // If the user pressed the button the obtain the total, display an interactive
                    // message to alert about the error.

                    // We check for this so that error messages are not spammed on the 'auto-update'
                    // feature that I've added to this project.
                    MessageBox.Show("Can not interpret `Quantity`. " + ex.Message, "Interpretation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Exit from the rest of the function as we can not continue.
                return;
            }

            if (sender == this.btnTotal && quantity == 0)
            {
                this.txtTotal.Text = "";

                // bind past 0
                MessageBox.Show("Please enter a quantity larger than 0.", "Interpretation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
             * Calculate and display the total
             */

            decimal total = unit_cost * quantity;
            this.txtTotal.Text = total.ToString("C");
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle visiblity of clock via class flag
            this.showClock = this.chkShowHide.Checked;

            if (!this.showClock)
            {
                // Clear the time label if we have disabled the clock
                this.lblTime.Text = "";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.showClock)
            {
                this.lblTime.Text = DateTime.Now.ToLongDateString() + " " 
                    + DateTime.Now.ToLongTimeString();

            }
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            // Pass to the item change function
            this.selectionChanged(sender, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset check states
            this.radPepperoni.Checked = this.radPineapple.Checked = this.radVeggie.Checked =
                this.radMeatlover.Checked = this.chkCoke.Checked = this.chkFries.Checked =
                this.chkWater.Checked = false;

            // Reset textual inputs and outputs
            this.txtTotal.Text = this.txtQuantity.Text = this.txtPizzaDrinks.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by John Lettman\n\nsomething something TOS");
        }

        private void becomeTheGuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * this is an easter egg that you probably shouldnt mess with because
             * of secret magic numbers and that jazz. i mean, if you're truly interested,
             * google would probably explain what the numbers mean- i took great joy in
             * making this simple function to rustle people's jimmies.
             */

            const int WM_SYSCOMMAND = 0x0112,
                SUPER_ULTRA_SECRET_MAGICAL_UNICORN_NUMBER = 0xF170;

            Secret.SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, 
                SUPER_ULTRA_SECRET_MAGICAL_UNICORN_NUMBER, 2);
        }
    }

    public class Secret
    {
        [DllImport("user32.dll")] // shhh this doesn't exist
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
    }
}
