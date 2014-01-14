using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Clothing_Sales
{
    public partial class MainWindow : Form
    {
        const double DISCOUNT = 0.30; // 30%

        public MainWindow()
        {
            InitializeComponent();

            Timer clock_timer = new Timer();
            clock_timer.Interval = 1000;

            clock_timer.Tick += tick_event;
            clock_timer.Start();

            tick_event(null, null);
        }

        private void tick_event(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int number_of_items;
            double price, extended_price, discount_amount, total;

            try
            {
                number_of_items = int.Parse(this.numberOfItemsInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Number of Items`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                price = double.Parse(this.priceInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Price`. " +
                    ex.Message, "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            extended_price = price * number_of_items;       // calculate price before discount
            discount_amount = extended_price * DISCOUNT;    // calculate discount amount
            total = extended_price - discount_amount;       // calculate total after discount

            // Output variables with money formatting
            this.extendedPriceOutput.Text = extended_price.ToString("C");
            this.discountOutput.Text = discount_amount.ToString("C");
            this.dueOutput.Text = total.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all fields
            this.extendedPriceOutput.Text = this.discountOutput.Text = 
                this.dueOutput.Text = this.priceInput.Text = 
                this.numberOfItemsInput.Text = "";

            this.numberOfItemsInput.Focus();
        }
    }
}
