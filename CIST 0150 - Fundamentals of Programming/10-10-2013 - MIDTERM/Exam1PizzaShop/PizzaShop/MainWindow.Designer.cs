namespace PizzaShop
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPizzaDrinks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toppingGroupBox = new System.Windows.Forms.GroupBox();
            this.radVeggie = new System.Windows.Forms.RadioButton();
            this.radPineapple = new System.Windows.Forms.RadioButton();
            this.radMeatlover = new System.Windows.Forms.RadioButton();
            this.radPepperoni = new System.Windows.Forms.RadioButton();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drinksGroupBox = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.becomeTheGuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).BeginInit();
            this.toppingGroupBox.SuspendLayout();
            this.drinksGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaPictureBox
            // 
            this.pizzaPictureBox.Location = new System.Drawing.Point(265, 110);
            this.pizzaPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pizzaPictureBox.Name = "pizzaPictureBox";
            this.pizzaPictureBox.Size = new System.Drawing.Size(259, 152);
            this.pizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizzaPictureBox.TabIndex = 31;
            this.pizzaPictureBox.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(233, 468);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 27);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPizzaDrinks
            // 
            this.txtPizzaDrinks.Location = new System.Drawing.Point(233, 374);
            this.txtPizzaDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.txtPizzaDrinks.Name = "txtPizzaDrinks";
            this.txtPizzaDrinks.ReadOnly = true;
            this.txtPizzaDrinks.Size = new System.Drawing.Size(132, 27);
            this.txtPizzaDrinks.TabIndex = 25;
            this.txtPizzaDrinks.TabStop = false;
            this.txtPizzaDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Order Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(48, 451);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(473, 2);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "Label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pizza and Drinks:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toppingGroupBox
            // 
            this.toppingGroupBox.Controls.Add(this.radVeggie);
            this.toppingGroupBox.Controls.Add(this.radPineapple);
            this.toppingGroupBox.Controls.Add(this.radMeatlover);
            this.toppingGroupBox.Controls.Add(this.radPepperoni);
            this.toppingGroupBox.Location = new System.Drawing.Point(37, 99);
            this.toppingGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.toppingGroupBox.Name = "toppingGroupBox";
            this.toppingGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.toppingGroupBox.Size = new System.Drawing.Size(218, 152);
            this.toppingGroupBox.TabIndex = 22;
            this.toppingGroupBox.TabStop = false;
            this.toppingGroupBox.Text = "Toppings";
            // 
            // radVeggie
            // 
            this.radVeggie.Location = new System.Drawing.Point(22, 109);
            this.radVeggie.Margin = new System.Windows.Forms.Padding(5);
            this.radVeggie.Name = "radVeggie";
            this.radVeggie.Size = new System.Drawing.Size(179, 29);
            this.radVeggie.TabIndex = 3;
            this.radVeggie.Text = "Veggie ($9.99)";
            this.radVeggie.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // radPineapple
            // 
            this.radPineapple.Location = new System.Drawing.Point(22, 82);
            this.radPineapple.Margin = new System.Windows.Forms.Padding(5);
            this.radPineapple.Name = "radPineapple";
            this.radPineapple.Size = new System.Drawing.Size(179, 29);
            this.radPineapple.TabIndex = 2;
            this.radPineapple.Text = "Pineapple ($10.99)";
            this.radPineapple.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // radMeatlover
            // 
            this.radMeatlover.Location = new System.Drawing.Point(22, 58);
            this.radMeatlover.Margin = new System.Windows.Forms.Padding(5);
            this.radMeatlover.Name = "radMeatlover";
            this.radMeatlover.Size = new System.Drawing.Size(179, 29);
            this.radMeatlover.TabIndex = 1;
            this.radMeatlover.Text = "Meatlover\'s ($13.99)";
            this.radMeatlover.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // radPepperoni
            // 
            this.radPepperoni.Location = new System.Drawing.Point(22, 31);
            this.radPepperoni.Margin = new System.Windows.Forms.Padding(5);
            this.radPepperoni.Name = "radPepperoni";
            this.radPepperoni.Size = new System.Drawing.Size(179, 29);
            this.radPepperoni.TabIndex = 0;
            this.radPepperoni.Text = "Pepperoni ($12.99)";
            this.radPepperoni.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // chkCoke
            // 
            this.chkCoke.Location = new System.Drawing.Point(46, 29);
            this.chkCoke.Margin = new System.Windows.Forms.Padding(5);
            this.chkCoke.Name = "chkCoke";
            this.chkCoke.Size = new System.Drawing.Size(70, 29);
            this.chkCoke.TabIndex = 0;
            this.chkCoke.Text = "Coke ($1.99)";
            this.chkCoke.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(233, 411);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 27);
            this.txtQuantity.TabIndex = 21;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 413);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drinksGroupBox
            // 
            this.drinksGroupBox.Controls.Add(this.chkFries);
            this.drinksGroupBox.Controls.Add(this.chkWater);
            this.drinksGroupBox.Controls.Add(this.chkCoke);
            this.drinksGroupBox.Location = new System.Drawing.Point(37, 282);
            this.drinksGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drinksGroupBox.Name = "drinksGroupBox";
            this.drinksGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drinksGroupBox.Size = new System.Drawing.Size(494, 71);
            this.drinksGroupBox.TabIndex = 32;
            this.drinksGroupBox.TabStop = false;
            this.drinksGroupBox.Text = "Drinks and Sides";
            // 
            // chkFries
            // 
            this.chkFries.Location = new System.Drawing.Point(317, 24);
            this.chkFries.Margin = new System.Windows.Forms.Padding(5);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(169, 38);
            this.chkFries.TabIndex = 3;
            this.chkFries.Text = "Fish Fries ($2.99)";
            this.chkFries.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // chkWater
            // 
            this.chkWater.Location = new System.Drawing.Point(126, 24);
            this.chkWater.Margin = new System.Windows.Forms.Padding(5);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(171, 38);
            this.chkWater.TabIndex = 2;
            this.chkWater.Text = "Bottle Water ($0.99)";
            this.chkWater.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(416, 468);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(107, 27);
            this.btnTotal.TabIndex = 33;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.selectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Italiano Pizzeria";
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Location = new System.Drawing.Point(41, 533);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(324, 21);
            this.lblTime.TabIndex = 38;
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.Checked = true;
            this.chkShowHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowHide.Location = new System.Drawing.Point(386, 533);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(145, 25);
            this.chkShowHide.TabIndex = 39;
            this.chkShowHide.Text = "Show/Hide Clock";
            this.chkShowHide.UseVisualStyleBackColor = true;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.becomeTheGuyToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Extra";
            // 
            // becomeTheGuyToolStripMenuItem
            // 
            this.becomeTheGuyToolStripMenuItem.Name = "becomeTheGuyToolStripMenuItem";
            this.becomeTheGuyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.becomeTheGuyToolStripMenuItem.Text = "Become the guy";
            this.becomeTheGuyToolStripMenuItem.Click += new System.EventHandler(this.becomeTheGuyToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 578);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.drinksGroupBox);
            this.Controls.Add(this.pizzaPictureBox);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPizzaDrinks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toppingGroupBox);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(597, 616);
            this.MinimumSize = new System.Drawing.Size(597, 616);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).EndInit();
            this.toppingGroupBox.ResumeLayout(false);
            this.drinksGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pizzaPictureBox;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtPizzaDrinks;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox toppingGroupBox;
        internal System.Windows.Forms.RadioButton radVeggie;
        internal System.Windows.Forms.RadioButton radPineapple;
        internal System.Windows.Forms.RadioButton radMeatlover;
        internal System.Windows.Forms.RadioButton radPepperoni;
        internal System.Windows.Forms.CheckBox chkCoke;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox drinksGroupBox;
        internal System.Windows.Forms.CheckBox chkWater;
        internal System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox chkShowHide;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem becomeTheGuyToolStripMenuItem;
    }
}

