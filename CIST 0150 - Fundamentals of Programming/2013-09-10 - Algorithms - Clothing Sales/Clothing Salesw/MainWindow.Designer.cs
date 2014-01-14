namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Clothing_Sales
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
            this.enterBox = new System.Windows.Forms.GroupBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.numberOfItemsInput = new System.Windows.Forms.TextBox();
            this.noiLabel = new System.Windows.Forms.Label();
            this.titleTable = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dueOutput = new System.Windows.Forms.TextBox();
            this.dueLabel = new System.Windows.Forms.Label();
            this.discountOutput = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.extendedPriceOutput = new System.Windows.Forms.TextBox();
            this.extendedPriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.enterBox.SuspendLayout();
            this.titleTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterBox
            // 
            this.enterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterBox.Controls.Add(this.priceInput);
            this.enterBox.Controls.Add(this.priceLabel);
            this.enterBox.Controls.Add(this.numberOfItemsInput);
            this.enterBox.Controls.Add(this.noiLabel);
            this.enterBox.Location = new System.Drawing.Point(12, 45);
            this.enterBox.Name = "enterBox";
            this.enterBox.Size = new System.Drawing.Size(320, 87);
            this.enterBox.TabIndex = 0;
            this.enterBox.TabStop = false;
            // 
            // priceInput
            // 
            this.priceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceInput.Location = new System.Drawing.Point(126, 50);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(177, 20);
            this.priceInput.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(81, 52);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 16);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfItemsInput
            // 
            this.numberOfItemsInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfItemsInput.Location = new System.Drawing.Point(126, 24);
            this.numberOfItemsInput.Name = "numberOfItemsInput";
            this.numberOfItemsInput.Size = new System.Drawing.Size(177, 20);
            this.numberOfItemsInput.TabIndex = 1;
            // 
            // noiLabel
            // 
            this.noiLabel.AutoSize = true;
            this.noiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiLabel.Location = new System.Drawing.Point(15, 25);
            this.noiLabel.Name = "noiLabel";
            this.noiLabel.Size = new System.Drawing.Size(105, 16);
            this.noiLabel.TabIndex = 0;
            this.noiLabel.Text = "Number of Items";
            this.noiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleTable
            // 
            this.titleTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTable.ColumnCount = 1;
            this.titleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleTable.Controls.Add(this.title, 0, 0);
            this.titleTable.Location = new System.Drawing.Point(12, 12);
            this.titleTable.Name = "titleTable";
            this.titleTable.RowCount = 1;
            this.titleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.titleTable.Size = new System.Drawing.Size(320, 27);
            this.titleTable.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(314, 27);
            this.title.TabIndex = 0;
            this.title.Text = "Clothing Sales";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dueOutput);
            this.groupBox1.Controls.Add(this.dueLabel);
            this.groupBox1.Controls.Add(this.discountOutput);
            this.groupBox1.Controls.Add(this.discountLabel);
            this.groupBox1.Controls.Add(this.extendedPriceOutput);
            this.groupBox1.Controls.Add(this.extendedPriceLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dueOutput
            // 
            this.dueOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dueOutput.Location = new System.Drawing.Point(126, 76);
            this.dueOutput.Name = "dueOutput";
            this.dueOutput.ReadOnly = true;
            this.dueOutput.Size = new System.Drawing.Size(177, 20);
            this.dueOutput.TabIndex = 5;
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueLabel.Location = new System.Drawing.Point(39, 77);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(81, 16);
            this.dueLabel.TabIndex = 4;
            this.dueLabel.Text = "Amount Due";
            this.dueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // discountOutput
            // 
            this.discountOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountOutput.Location = new System.Drawing.Point(126, 50);
            this.discountOutput.Name = "discountOutput";
            this.discountOutput.ReadOnly = true;
            this.discountOutput.Size = new System.Drawing.Size(177, 20);
            this.discountOutput.TabIndex = 3;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(31, 52);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(89, 16);
            this.discountLabel.TabIndex = 2;
            this.discountLabel.Text = "30% Discount";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extendedPriceOutput
            // 
            this.extendedPriceOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedPriceOutput.Location = new System.Drawing.Point(126, 24);
            this.extendedPriceOutput.Name = "extendedPriceOutput";
            this.extendedPriceOutput.ReadOnly = true;
            this.extendedPriceOutput.Size = new System.Drawing.Size(177, 20);
            this.extendedPriceOutput.TabIndex = 1;
            // 
            // extendedPriceLabel
            // 
            this.extendedPriceLabel.AutoSize = true;
            this.extendedPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedPriceLabel.Location = new System.Drawing.Point(21, 26);
            this.extendedPriceLabel.Name = "extendedPriceLabel";
            this.extendedPriceLabel.Size = new System.Drawing.Size(99, 16);
            this.extendedPriceLabel.TabIndex = 0;
            this.extendedPriceLabel.Text = "Extended Price";
            this.extendedPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(257, 263);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateButton.Location = new System.Drawing.Point(12, 263);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(93, 263);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(174, 268);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(51, 13);
            this.clockLabel.TabIndex = 4;
            this.clockLabel.Text = "00:00 am";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 298);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleTable);
            this.Controls.Add(this.enterBox);
            this.MinimumSize = new System.Drawing.Size(360, 336);
            this.Name = "MainWindow";
            this.Text = "Look Sharp Fitness Center";
            this.enterBox.ResumeLayout(false);
            this.enterBox.PerformLayout();
            this.titleTable.ResumeLayout(false);
            this.titleTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox enterBox;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox numberOfItemsInput;
        private System.Windows.Forms.Label noiLabel;
        private System.Windows.Forms.TableLayoutPanel titleTable;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dueOutput;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.TextBox discountOutput;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox extendedPriceOutput;
        private System.Windows.Forms.Label extendedPriceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clockLabel;
    }
}

