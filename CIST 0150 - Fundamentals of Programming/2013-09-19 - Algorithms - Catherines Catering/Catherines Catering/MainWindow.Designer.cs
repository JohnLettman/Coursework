namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Catherines_Catering
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
            this.menuChoicesGroup = new System.Windows.Forms.GroupBox();
            this.menuChoicesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.primeRibRadio = new System.Windows.Forms.RadioButton();
            this.chickenRadio = new System.Windows.Forms.RadioButton();
            this.pastaRadio = new System.Windows.Forms.RadioButton();
            this.amountDueGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.amountDueOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.openBarCheck = new System.Windows.Forms.CheckBox();
            this.wineCheck = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.numberOfGuestsGroup = new System.Windows.Forms.GroupBox();
            this.numberOfGuestsInput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuChoicesGroup.SuspendLayout();
            this.menuChoicesFlow.SuspendLayout();
            this.amountDueGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.numberOfGuestsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuChoicesGroup
            // 
            this.menuChoicesGroup.Controls.Add(this.menuChoicesFlow);
            this.menuChoicesGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuChoicesGroup.Location = new System.Drawing.Point(132, 3);
            this.menuChoicesGroup.Name = "menuChoicesGroup";
            this.menuChoicesGroup.Size = new System.Drawing.Size(160, 140);
            this.menuChoicesGroup.TabIndex = 0;
            this.menuChoicesGroup.TabStop = false;
            this.menuChoicesGroup.Text = "Menu Choices";
            // 
            // menuChoicesFlow
            // 
            this.menuChoicesFlow.Controls.Add(this.primeRibRadio);
            this.menuChoicesFlow.Controls.Add(this.chickenRadio);
            this.menuChoicesFlow.Controls.Add(this.pastaRadio);
            this.menuChoicesFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuChoicesFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuChoicesFlow.Location = new System.Drawing.Point(3, 16);
            this.menuChoicesFlow.Name = "menuChoicesFlow";
            this.menuChoicesFlow.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.menuChoicesFlow.Size = new System.Drawing.Size(154, 121);
            this.menuChoicesFlow.TabIndex = 0;
            // 
            // primeRibRadio
            // 
            this.primeRibRadio.AutoSize = true;
            this.primeRibRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeRibRadio.Location = new System.Drawing.Point(13, 13);
            this.primeRibRadio.Name = "primeRibRadio";
            this.primeRibRadio.Size = new System.Drawing.Size(69, 17);
            this.primeRibRadio.TabIndex = 2;
            this.primeRibRadio.TabStop = true;
            this.primeRibRadio.Text = "Prime &Rib";
            this.primeRibRadio.UseVisualStyleBackColor = true;
            // 
            // chickenRadio
            // 
            this.chickenRadio.AutoSize = true;
            this.chickenRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chickenRadio.Location = new System.Drawing.Point(13, 36);
            this.chickenRadio.Name = "chickenRadio";
            this.chickenRadio.Size = new System.Drawing.Size(63, 17);
            this.chickenRadio.TabIndex = 3;
            this.chickenRadio.TabStop = true;
            this.chickenRadio.Text = "C&hicken";
            this.chickenRadio.UseVisualStyleBackColor = true;
            // 
            // pastaRadio
            // 
            this.pastaRadio.AutoSize = true;
            this.pastaRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastaRadio.Location = new System.Drawing.Point(13, 59);
            this.pastaRadio.Name = "pastaRadio";
            this.pastaRadio.Size = new System.Drawing.Size(51, 17);
            this.pastaRadio.TabIndex = 4;
            this.pastaRadio.TabStop = true;
            this.pastaRadio.Text = "&Pasta";
            this.pastaRadio.UseVisualStyleBackColor = true;
            // 
            // amountDueGroup
            // 
            this.amountDueGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amountDueGroup.Controls.Add(this.flowLayoutPanel1);
            this.amountDueGroup.Location = new System.Drawing.Point(6, 152);
            this.amountDueGroup.Name = "amountDueGroup";
            this.amountDueGroup.Padding = new System.Windows.Forms.Padding(0);
            this.amountDueGroup.Size = new System.Drawing.Size(182, 60);
            this.amountDueGroup.TabIndex = 1;
            this.amountDueGroup.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.amountDueLabel);
            this.flowLayoutPanel1.Controls.Add(this.amountDueOutput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(10, 10);
            this.amountDueLabel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(87, 16);
            this.amountDueLabel.TabIndex = 1;
            this.amountDueLabel.Text = "Amount Due: ";
            // 
            // amountDueOutput
            // 
            this.amountDueOutput.Location = new System.Drawing.Point(97, 10);
            this.amountDueOutput.Margin = new System.Windows.Forms.Padding(0, 10, 3, 3);
            this.amountDueOutput.Name = "amountDueOutput";
            this.amountDueOutput.ReadOnly = true;
            this.amountDueOutput.Size = new System.Drawing.Size(66, 20);
            this.amountDueOutput.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(298, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bar Selection";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.openBarCheck);
            this.flowLayoutPanel2.Controls.Add(this.wineCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(154, 121);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // openBarCheck
            // 
            this.openBarCheck.AutoSize = true;
            this.openBarCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBarCheck.Location = new System.Drawing.Point(13, 13);
            this.openBarCheck.Name = "openBarCheck";
            this.openBarCheck.Size = new System.Drawing.Size(68, 17);
            this.openBarCheck.TabIndex = 0;
            this.openBarCheck.Text = "&Open Bar";
            this.openBarCheck.UseVisualStyleBackColor = true;
            // 
            // wineCheck
            // 
            this.wineCheck.AutoSize = true;
            this.wineCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wineCheck.Location = new System.Drawing.Point(13, 36);
            this.wineCheck.Name = "wineCheck";
            this.wineCheck.Size = new System.Drawing.Size(104, 17);
            this.wineCheck.TabIndex = 1;
            this.wineCheck.Text = "&Wine with Dinner";
            this.wineCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.numberOfGuestsGroup);
            this.flowLayoutPanel3.Controls.Add(this.menuChoicesGroup);
            this.flowLayoutPanel3.Controls.Add(this.groupBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(462, 146);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // numberOfGuestsGroup
            // 
            this.numberOfGuestsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.numberOfGuestsGroup.Controls.Add(this.numberOfGuestsInput);
            this.numberOfGuestsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberOfGuestsGroup.Location = new System.Drawing.Point(3, 3);
            this.numberOfGuestsGroup.Name = "numberOfGuestsGroup";
            this.numberOfGuestsGroup.Padding = new System.Windows.Forms.Padding(10);
            this.numberOfGuestsGroup.Size = new System.Drawing.Size(123, 59);
            this.numberOfGuestsGroup.TabIndex = 3;
            this.numberOfGuestsGroup.TabStop = false;
            this.numberOfGuestsGroup.Text = "Number of &Guests";
            // 
            // numberOfGuestsInput
            // 
            this.numberOfGuestsInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfGuestsInput.Location = new System.Drawing.Point(10, 23);
            this.numberOfGuestsInput.MinimumSize = new System.Drawing.Size(100, 20);
            this.numberOfGuestsInput.Name = "numberOfGuestsInput";
            this.numberOfGuestsInput.Size = new System.Drawing.Size(103, 20);
            this.numberOfGuestsInput.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(375, 189);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(294, 189);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(213, 189);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(462, 224);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.amountDueGroup);
            this.MinimumSize = new System.Drawing.Size(478, 262);
            this.Name = "MainWindow";
            this.Text = "Catherine\'s Catering";
            this.menuChoicesGroup.ResumeLayout(false);
            this.menuChoicesFlow.ResumeLayout(false);
            this.menuChoicesFlow.PerformLayout();
            this.amountDueGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.numberOfGuestsGroup.ResumeLayout(false);
            this.numberOfGuestsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuChoicesGroup;
        private System.Windows.Forms.FlowLayoutPanel menuChoicesFlow;
        private System.Windows.Forms.RadioButton primeRibRadio;
        private System.Windows.Forms.RadioButton chickenRadio;
        private System.Windows.Forms.RadioButton pastaRadio;
        private System.Windows.Forms.GroupBox amountDueGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.TextBox amountDueOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox openBarCheck;
        private System.Windows.Forms.CheckBox wineCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox numberOfGuestsGroup;
        private System.Windows.Forms.TextBox numberOfGuestsInput;
    }
}

