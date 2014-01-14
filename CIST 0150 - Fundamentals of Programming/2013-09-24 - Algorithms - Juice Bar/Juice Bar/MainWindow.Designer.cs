namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Juice_Bar
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
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.sizeFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ounces12radio = new System.Windows.Forms.RadioButton();
            this.ounces16radio = new System.Windows.Forms.RadioButton();
            this.ounces20radio = new System.Windows.Forms.RadioButton();
            this.extrasGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vpCheck = new System.Windows.Forms.CheckBox();
            this.ebCheck = new System.Windows.Forms.CheckBox();
            this.ftlCheck = new System.Windows.Forms.CheckBox();
            this.drinkGroup = new System.Windows.Forms.GroupBox();
            this.drinkFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.fruitRadio = new System.Windows.Forms.RadioButton();
            this.veggieRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pomRadio = new System.Windows.Forms.RadioButton();
            this.sbRadio = new System.Windows.Forms.RadioButton();
            this.wbRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.itemPriceOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryReportButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.sizeGroup.SuspendLayout();
            this.sizeFlow.SuspendLayout();
            this.extrasGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.drinkGroup.SuspendLayout();
            this.drinkFlow.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGroup
            // 
            this.sizeGroup.Controls.Add(this.sizeFlow);
            this.sizeGroup.Location = new System.Drawing.Point(12, 12);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(190, 105);
            this.sizeGroup.TabIndex = 0;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Size";
            // 
            // sizeFlow
            // 
            this.sizeFlow.Controls.Add(this.ounces12radio);
            this.sizeFlow.Controls.Add(this.ounces16radio);
            this.sizeFlow.Controls.Add(this.ounces20radio);
            this.sizeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sizeFlow.Location = new System.Drawing.Point(3, 16);
            this.sizeFlow.Name = "sizeFlow";
            this.sizeFlow.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sizeFlow.Size = new System.Drawing.Size(184, 86);
            this.sizeFlow.TabIndex = 0;
            // 
            // ounces12radio
            // 
            this.ounces12radio.AutoSize = true;
            this.ounces12radio.Location = new System.Drawing.Point(8, 10);
            this.ounces12radio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ounces12radio.Name = "ounces12radio";
            this.ounces12radio.Size = new System.Drawing.Size(105, 17);
            this.ounces12radio.TabIndex = 0;
            this.ounces12radio.TabStop = true;
            this.ounces12radio.Text = "12 Ounce: $3.00";
            this.ounces12radio.UseVisualStyleBackColor = true;
            // 
            // ounces16radio
            // 
            this.ounces16radio.AutoSize = true;
            this.ounces16radio.Location = new System.Drawing.Point(8, 35);
            this.ounces16radio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ounces16radio.Name = "ounces16radio";
            this.ounces16radio.Size = new System.Drawing.Size(105, 17);
            this.ounces16radio.TabIndex = 1;
            this.ounces16radio.TabStop = true;
            this.ounces16radio.Text = "16 Ounce: $3.50";
            this.ounces16radio.UseVisualStyleBackColor = true;
            // 
            // ounces20radio
            // 
            this.ounces20radio.AutoSize = true;
            this.ounces20radio.Location = new System.Drawing.Point(8, 60);
            this.ounces20radio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ounces20radio.Name = "ounces20radio";
            this.ounces20radio.Size = new System.Drawing.Size(105, 17);
            this.ounces20radio.TabIndex = 2;
            this.ounces20radio.TabStop = true;
            this.ounces20radio.Text = "20 Ounce: $4.00";
            this.ounces20radio.UseVisualStyleBackColor = true;
            // 
            // extrasGroup
            // 
            this.extrasGroup.Controls.Add(this.flowLayoutPanel1);
            this.extrasGroup.Location = new System.Drawing.Point(12, 123);
            this.extrasGroup.Name = "extrasGroup";
            this.extrasGroup.Size = new System.Drawing.Size(190, 105);
            this.extrasGroup.TabIndex = 1;
            this.extrasGroup.TabStop = false;
            this.extrasGroup.Text = "Extras: $0.50 each";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vpCheck);
            this.flowLayoutPanel1.Controls.Add(this.ebCheck);
            this.flowLayoutPanel1.Controls.Add(this.ftlCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 86);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // vpCheck
            // 
            this.vpCheck.AutoSize = true;
            this.vpCheck.Location = new System.Drawing.Point(8, 10);
            this.vpCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.vpCheck.Name = "vpCheck";
            this.vpCheck.Size = new System.Drawing.Size(88, 17);
            this.vpCheck.TabIndex = 0;
            this.vpCheck.Text = "&Vitamin Pack";
            this.vpCheck.UseVisualStyleBackColor = true;
            // 
            // ebCheck
            // 
            this.ebCheck.AutoSize = true;
            this.ebCheck.Location = new System.Drawing.Point(8, 35);
            this.ebCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ebCheck.Name = "ebCheck";
            this.ebCheck.Size = new System.Drawing.Size(98, 17);
            this.ebCheck.TabIndex = 1;
            this.ebCheck.Text = "Energy &Booster";
            this.ebCheck.UseVisualStyleBackColor = true;
            // 
            // ftlCheck
            // 
            this.ftlCheck.AutoSize = true;
            this.ftlCheck.Location = new System.Drawing.Point(8, 60);
            this.ftlCheck.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.ftlCheck.Name = "ftlCheck";
            this.ftlCheck.Size = new System.Drawing.Size(93, 17);
            this.ftlCheck.TabIndex = 2;
            this.ftlCheck.Text = "For the &Ladies";
            this.ftlCheck.UseVisualStyleBackColor = true;
            // 
            // drinkGroup
            // 
            this.drinkGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drinkGroup.Controls.Add(this.drinkFlow);
            this.drinkGroup.Location = new System.Drawing.Point(208, 12);
            this.drinkGroup.Name = "drinkGroup";
            this.drinkGroup.Size = new System.Drawing.Size(190, 216);
            this.drinkGroup.TabIndex = 2;
            this.drinkGroup.TabStop = false;
            this.drinkGroup.Text = "Select the drink type:";
            // 
            // drinkFlow
            // 
            this.drinkFlow.Controls.Add(this.label3);
            this.drinkFlow.Controls.Add(this.fruitRadio);
            this.drinkFlow.Controls.Add(this.veggieRadio);
            this.drinkFlow.Controls.Add(this.label4);
            this.drinkFlow.Controls.Add(this.pomRadio);
            this.drinkFlow.Controls.Add(this.sbRadio);
            this.drinkFlow.Controls.Add(this.wbRadio);
            this.drinkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.drinkFlow.Location = new System.Drawing.Point(3, 16);
            this.drinkFlow.Name = "drinkFlow";
            this.drinkFlow.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.drinkFlow.Size = new System.Drawing.Size(184, 197);
            this.drinkFlow.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Juices";
            // 
            // fruitRadio
            // 
            this.fruitRadio.AutoSize = true;
            this.fruitRadio.Location = new System.Drawing.Point(20, 21);
            this.fruitRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.fruitRadio.Name = "fruitRadio";
            this.fruitRadio.Size = new System.Drawing.Size(45, 17);
            this.fruitRadio.TabIndex = 1;
            this.fruitRadio.TabStop = true;
            this.fruitRadio.Text = "&Fruit";
            this.fruitRadio.UseVisualStyleBackColor = true;
            // 
            // veggieRadio
            // 
            this.veggieRadio.AutoSize = true;
            this.veggieRadio.Location = new System.Drawing.Point(20, 44);
            this.veggieRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.veggieRadio.Name = "veggieRadio";
            this.veggieRadio.Size = new System.Drawing.Size(58, 17);
            this.veggieRadio.TabIndex = 2;
            this.veggieRadio.TabStop = true;
            this.veggieRadio.Text = "Ve&ggie";
            this.veggieRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Smoothies";
            // 
            // pomRadio
            // 
            this.pomRadio.AutoSize = true;
            this.pomRadio.Location = new System.Drawing.Point(20, 90);
            this.pomRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pomRadio.Name = "pomRadio";
            this.pomRadio.Size = new System.Drawing.Size(88, 17);
            this.pomRadio.TabIndex = 3;
            this.pomRadio.TabStop = true;
            this.pomRadio.Text = "&Pomegranate";
            this.pomRadio.UseVisualStyleBackColor = true;
            // 
            // sbRadio
            // 
            this.sbRadio.AutoSize = true;
            this.sbRadio.Location = new System.Drawing.Point(20, 113);
            this.sbRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.sbRadio.Name = "sbRadio";
            this.sbRadio.Size = new System.Drawing.Size(115, 17);
            this.sbRadio.TabIndex = 4;
            this.sbRadio.TabStop = true;
            this.sbRadio.Text = "&Strawberry Banana";
            this.sbRadio.UseVisualStyleBackColor = true;
            // 
            // wbRadio
            // 
            this.wbRadio.AutoSize = true;
            this.wbRadio.Location = new System.Drawing.Point(20, 136);
            this.wbRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.Size = new System.Drawing.Size(84, 17);
            this.wbRadio.TabIndex = 5;
            this.wbRadio.TabStop = true;
            this.wbRadio.Text = "&Wheat Berry";
            this.wbRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInput.Location = new System.Drawing.Point(65, 2);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(36, 22);
            this.quantityInput.TabIndex = 3;
            this.quantityInput.Text = "1";
            // 
            // itemPriceOutput
            // 
            this.itemPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceOutput.Location = new System.Drawing.Point(65, 30);
            this.itemPriceOutput.Name = "itemPriceOutput";
            this.itemPriceOutput.ReadOnly = true;
            this.itemPriceOutput.Size = new System.Drawing.Size(80, 22);
            this.itemPriceOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Price:";
            // 
            // outputPanel
            // 
            this.outputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputPanel.Controls.Add(this.totalOutput);
            this.outputPanel.Controls.Add(this.label5);
            this.outputPanel.Controls.Add(this.quantityInput);
            this.outputPanel.Controls.Add(this.itemPriceOutput);
            this.outputPanel.Controls.Add(this.label1);
            this.outputPanel.Controls.Add(this.label2);
            this.outputPanel.Location = new System.Drawing.Point(12, 271);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(148, 93);
            this.outputPanel.TabIndex = 6;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(65, 58);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(80, 22);
            this.totalOutput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total:";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(299, 339);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryReportButton
            // 
            this.summaryReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryReportButton.Enabled = false;
            this.summaryReportButton.Location = new System.Drawing.Point(298, 305);
            this.summaryReportButton.Name = "summaryReportButton";
            this.summaryReportButton.Size = new System.Drawing.Size(100, 28);
            this.summaryReportButton.TabIndex = 8;
            this.summaryReportButton.Text = "Summary &Report";
            this.summaryReportButton.UseVisualStyleBackColor = true;
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCompleteButton.Enabled = false;
            this.orderCompleteButton.Location = new System.Drawing.Point(298, 271);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(100, 28);
            this.orderCompleteButton.TabIndex = 9;
            this.orderCompleteButton.Text = "Order &Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToOrderButton.Location = new System.Drawing.Point(298, 237);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(100, 28);
            this.addToOrderButton.TabIndex = 10;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 376);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.summaryReportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.drinkGroup);
            this.Controls.Add(this.extrasGroup);
            this.Controls.Add(this.sizeGroup);
            this.MinimumSize = new System.Drawing.Size(427, 414);
            this.Name = "MainWindow";
            this.Text = "Juice Bar Orders";
            this.sizeGroup.ResumeLayout(false);
            this.sizeFlow.ResumeLayout(false);
            this.sizeFlow.PerformLayout();
            this.extrasGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.drinkGroup.ResumeLayout(false);
            this.drinkFlow.ResumeLayout(false);
            this.drinkFlow.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.FlowLayoutPanel sizeFlow;
        private System.Windows.Forms.RadioButton ounces12radio;
        private System.Windows.Forms.RadioButton ounces16radio;
        private System.Windows.Forms.RadioButton ounces20radio;
        private System.Windows.Forms.GroupBox extrasGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox vpCheck;
        private System.Windows.Forms.CheckBox ebCheck;
        private System.Windows.Forms.CheckBox ftlCheck;
        private System.Windows.Forms.GroupBox drinkGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox itemPriceOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.FlowLayoutPanel drinkFlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton fruitRadio;
        private System.Windows.Forms.RadioButton veggieRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton pomRadio;
        private System.Windows.Forms.RadioButton sbRadio;
        private System.Windows.Forms.RadioButton wbRadio;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryReportButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label label5;
    }
}

