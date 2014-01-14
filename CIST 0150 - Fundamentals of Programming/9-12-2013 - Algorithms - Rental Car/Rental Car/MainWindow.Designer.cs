namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Rental_Car
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
            this.entryGroup = new System.Windows.Forms.GroupBox();
            this.daysInput = new System.Windows.Forms.TextBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.endingOdoInput = new System.Windows.Forms.TextBox();
            this.endingOdoLabel = new System.Windows.Forms.Label();
            this.beginningOdoInput = new System.Windows.Forms.TextBox();
            this.beginningOdoLabel = new System.Windows.Forms.Label();
            this.totalsGroup = new System.Windows.Forms.GroupBox();
            this.chargeOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.milesOutput = new System.Windows.Forms.TextBox();
            this.milesLabel = new System.Windows.Forms.Label();
            this.rentalRateLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.entryGroup.SuspendLayout();
            this.totalsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryGroup
            // 
            this.entryGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryGroup.Controls.Add(this.daysInput);
            this.entryGroup.Controls.Add(this.daysLabel);
            this.entryGroup.Controls.Add(this.endingOdoInput);
            this.entryGroup.Controls.Add(this.endingOdoLabel);
            this.entryGroup.Controls.Add(this.beginningOdoInput);
            this.entryGroup.Controls.Add(this.beginningOdoLabel);
            this.entryGroup.Location = new System.Drawing.Point(12, 12);
            this.entryGroup.Name = "entryGroup";
            this.entryGroup.Size = new System.Drawing.Size(237, 107);
            this.entryGroup.TabIndex = 0;
            this.entryGroup.TabStop = false;
            this.entryGroup.Text = "Enter Rental Information:";
            // 
            // daysInput
            // 
            this.daysInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daysInput.Location = new System.Drawing.Point(155, 71);
            this.daysInput.Name = "daysInput";
            this.daysInput.Size = new System.Drawing.Size(63, 20);
            this.daysInput.TabIndex = 5;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(41, 72);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.daysLabel.Size = new System.Drawing.Size(108, 16);
            this.daysLabel.TabIndex = 4;
            this.daysLabel.Text = "Number of Days:";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endingOdoInput
            // 
            this.endingOdoInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endingOdoInput.Location = new System.Drawing.Point(155, 45);
            this.endingOdoInput.Name = "endingOdoInput";
            this.endingOdoInput.Size = new System.Drawing.Size(63, 20);
            this.endingOdoInput.TabIndex = 3;
            // 
            // endingOdoLabel
            // 
            this.endingOdoLabel.AutoSize = true;
            this.endingOdoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingOdoLabel.Location = new System.Drawing.Point(33, 46);
            this.endingOdoLabel.Name = "endingOdoLabel";
            this.endingOdoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endingOdoLabel.Size = new System.Drawing.Size(116, 16);
            this.endingOdoLabel.TabIndex = 2;
            this.endingOdoLabel.Text = "Ending Odometer:";
            this.endingOdoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // beginningOdoInput
            // 
            this.beginningOdoInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beginningOdoInput.Location = new System.Drawing.Point(155, 19);
            this.beginningOdoInput.Name = "beginningOdoInput";
            this.beginningOdoInput.Size = new System.Drawing.Size(63, 20);
            this.beginningOdoInput.TabIndex = 1;
            // 
            // beginningOdoLabel
            // 
            this.beginningOdoLabel.AutoSize = true;
            this.beginningOdoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginningOdoLabel.Location = new System.Drawing.Point(15, 20);
            this.beginningOdoLabel.Name = "beginningOdoLabel";
            this.beginningOdoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beginningOdoLabel.Size = new System.Drawing.Size(134, 16);
            this.beginningOdoLabel.TabIndex = 0;
            this.beginningOdoLabel.Text = "Beginning Odometer:";
            this.beginningOdoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalsGroup
            // 
            this.totalsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalsGroup.Controls.Add(this.chargeOutput);
            this.totalsGroup.Controls.Add(this.label2);
            this.totalsGroup.Controls.Add(this.milesOutput);
            this.totalsGroup.Controls.Add(this.milesLabel);
            this.totalsGroup.Location = new System.Drawing.Point(12, 125);
            this.totalsGroup.Name = "totalsGroup";
            this.totalsGroup.Size = new System.Drawing.Size(237, 80);
            this.totalsGroup.TabIndex = 1;
            this.totalsGroup.TabStop = false;
            this.totalsGroup.Text = "Totals";
            // 
            // chargeOutput
            // 
            this.chargeOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chargeOutput.Location = new System.Drawing.Point(155, 45);
            this.chargeOutput.Name = "chargeOutput";
            this.chargeOutput.ReadOnly = true;
            this.chargeOutput.Size = new System.Drawing.Size(63, 20);
            this.chargeOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Charge*:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // milesOutput
            // 
            this.milesOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.milesOutput.Location = new System.Drawing.Point(155, 19);
            this.milesOutput.Name = "milesOutput";
            this.milesOutput.ReadOnly = true;
            this.milesOutput.Size = new System.Drawing.Size(63, 20);
            this.milesOutput.TabIndex = 3;
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLabel.Location = new System.Drawing.Point(64, 20);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.milesLabel.Size = new System.Drawing.Size(85, 16);
            this.milesLabel.TabIndex = 2;
            this.milesLabel.Text = "Miles Driven:";
            this.milesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rentalRateLabel
            // 
            this.rentalRateLabel.AutoSize = true;
            this.rentalRateLabel.Location = new System.Drawing.Point(12, 215);
            this.rentalRateLabel.Name = "rentalRateLabel";
            this.rentalRateLabel.Size = new System.Drawing.Size(0, 13);
            this.rentalRateLabel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(174, 249);
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
            this.calculateButton.Location = new System.Drawing.Point(12, 249);
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
            this.clearButton.Location = new System.Drawing.Point(93, 249);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 284);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rentalRateLabel);
            this.Controls.Add(this.totalsGroup);
            this.Controls.Add(this.entryGroup);
            this.MinimumSize = new System.Drawing.Size(277, 322);
            this.Name = "MainWindow";
            this.Text = "Rental Car";
            this.entryGroup.ResumeLayout(false);
            this.entryGroup.PerformLayout();
            this.totalsGroup.ResumeLayout(false);
            this.totalsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox entryGroup;
        private System.Windows.Forms.TextBox daysInput;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox endingOdoInput;
        private System.Windows.Forms.Label endingOdoLabel;
        private System.Windows.Forms.TextBox beginningOdoInput;
        private System.Windows.Forms.Label beginningOdoLabel;
        private System.Windows.Forms.GroupBox totalsGroup;
        private System.Windows.Forms.TextBox chargeOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox milesOutput;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.Label rentalRateLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

