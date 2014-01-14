using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Juice_Bar
{
    class DrinkOrder {
        public enum SIZE
        {
            OZ_12,
            OZ_16,
            OZ_20
        }

        public enum TYPE
        {
            NONE,
            FRUIT,
            VEGGIE,
            POMEGRANATE,
            STRAWBERRY_BANANA,
            WHEAT_BERRY
        }

        public SIZE size;
        public TYPE type = TYPE.NONE;

        // extras
        public bool vp, eb, ftl;

        // meta
        public double unit_cost;
        public uint quantity;
    }



    public partial class MainWindow : Form
    {
        private Stack<DrinkOrder> orders = new Stack<DrinkOrder>();
        private uint order_count = 0;

        private DrinkOrder current_drink = new DrinkOrder();

        public MainWindow()
        {
            InitializeComponent();

            /*
             * Add event handlers
             */

            this.fruitRadio.CheckedChanged += this.orderComponent_Click;
            this.pomRadio.CheckedChanged += this.orderComponent_Click;
            this.sbRadio.CheckedChanged += this.orderComponent_Click;
            this.veggieRadio.CheckedChanged += this.orderComponent_Click;
            this.wbRadio.CheckedChanged += this.orderComponent_Click;

            this.ounces12radio.CheckedChanged += this.orderComponent_Click;
            this.ounces16radio.CheckedChanged += this.orderComponent_Click;
            this.ounces20radio.CheckedChanged += this.orderComponent_Click;

            this.ebCheck.CheckedChanged += this.orderComponent_Click;
            this.ftlCheck.CheckedChanged += this.orderComponent_Click;
            this.vpCheck.CheckedChanged += this.orderComponent_Click;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderComponent_Click(object sender, EventArgs e)
        {
            uint amount = 0;

            try
            {
                amount = uint.Parse(this.quantityInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not interpret the input for `Quantity`. " + ex.Message,
                    "Interpretation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.current_drink.unit_cost = 0.00;


            // size

            if (this.ounces12radio.Checked)
            {
                this.current_drink.size = DrinkOrder.SIZE.OZ_12;
                this.current_drink.unit_cost += 3.00;
            }
            else if (this.ounces16radio.Checked)
            {
                this.current_drink.size = DrinkOrder.SIZE.OZ_12;
                this.current_drink.unit_cost += 3.50;
            }
            else if (this.ounces20radio.Checked)
            {
                this.current_drink.size = DrinkOrder.SIZE.OZ_12;
                this.current_drink.unit_cost += 4.00;
            }


            // extras

            if (vpCheck.Checked)
            {
                this.current_drink.unit_cost += 0.50;
            }

            if (ebCheck.Checked)
            {
                this.current_drink.unit_cost += 0.50;
            }

            if (ftlCheck.Checked)
            {
                this.current_drink.unit_cost += 0.50;
            }

            if (this.fruitRadio.Checked)
            {

            }

            if (this.fruitRadio.Checked)
            {

            }

        



            this.current_drink.vp = vpCheck.Checked;
            this.current_drink.eb = ebCheck.Checked;
            this.current_drink.ftl = ftlCheck.Checked;

            this.current_drink.quantity = amount;

            this.itemPriceOutput.Text = this.current_drink.unit_cost.ToString("C");

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (this.current_drink.type == DrinkOrder.TYPE.NONE)
            {
                MessageBox.Show("Please select a drink type. ",
    "Semantic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.orders.Push(this.current_drink);
            this.current_drink = new DrinkOrder();

            // reset inputs
            this.fruitRadio.Checked = this.pomRadio.Checked = this.sbRadio.Checked =
                this.veggieRadio.Checked = this.wbRadio.Checked = this.ebCheck.Checked =
                this.ftlCheck.Checked = this.vpCheck.Checked = this.ounces12radio.Checked =
                this.ounces16radio.Checked = this.ounces20radio.Checked = false;
        }
    }
}
