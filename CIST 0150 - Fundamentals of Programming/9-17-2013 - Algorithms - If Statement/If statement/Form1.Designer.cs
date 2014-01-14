namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.If_statement
{
    partial class Form1
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
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.appleRadioButton = new System.Windows.Forms.RadioButton();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.cranberryRadioButton = new System.Windows.Forms.RadioButton();
            this.crbButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkboxGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.appleCheck = new System.Windows.Forms.CheckBox();
            this.bananaCheck = new System.Windows.Forms.CheckBox();
            this.cranberryCheck = new System.Windows.Forms.CheckBox();
            this.ccbButton = new System.Windows.Forms.Button();
            this.mainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.radioGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.checkboxGroup.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.mainFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.flowLayoutPanel1);
            this.radioGroup.Location = new System.Drawing.Point(3, 3);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(200, 100);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Foods: Radio Buttons";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.appleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.bananaRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.cranberryRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // appleRadioButton
            // 
            this.appleRadioButton.AutoSize = true;
            this.appleRadioButton.Location = new System.Drawing.Point(3, 3);
            this.appleRadioButton.Name = "appleRadioButton";
            this.appleRadioButton.Size = new System.Drawing.Size(52, 17);
            this.appleRadioButton.TabIndex = 0;
            this.appleRadioButton.TabStop = true;
            this.appleRadioButton.Text = "Apple";
            this.appleRadioButton.UseVisualStyleBackColor = true;
            // 
            // bananaRadioButton
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Location = new System.Drawing.Point(3, 26);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(62, 17);
            this.bananaRadioButton.TabIndex = 1;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "Banana";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // cranberryRadioButton
            // 
            this.cranberryRadioButton.AutoSize = true;
            this.cranberryRadioButton.Location = new System.Drawing.Point(3, 49);
            this.cranberryRadioButton.Name = "cranberryRadioButton";
            this.cranberryRadioButton.Size = new System.Drawing.Size(70, 17);
            this.cranberryRadioButton.TabIndex = 2;
            this.cranberryRadioButton.TabStop = true;
            this.cranberryRadioButton.Text = "Cranberry";
            this.cranberryRadioButton.UseVisualStyleBackColor = true;
            // 
            // crbButton
            // 
            this.crbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crbButton.Location = new System.Drawing.Point(12, 253);
            this.crbButton.Name = "crbButton";
            this.crbButton.Size = new System.Drawing.Size(133, 23);
            this.crbButton.TabIndex = 1;
            this.crbButton.Text = "Check Radio Buttons";
            this.crbButton.UseVisualStyleBackColor = true;
            this.crbButton.Click += new System.EventHandler(this.crbButtons_Click);
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(151, 257);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(44, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "???";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // checkboxGroup
            // 
            this.checkboxGroup.Controls.Add(this.flowLayoutPanel2);
            this.checkboxGroup.Location = new System.Drawing.Point(209, 3);
            this.checkboxGroup.Name = "checkboxGroup";
            this.checkboxGroup.Size = new System.Drawing.Size(200, 100);
            this.checkboxGroup.TabIndex = 3;
            this.checkboxGroup.TabStop = false;
            this.checkboxGroup.Text = "Foods: Checkboxes";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.appleCheck);
            this.flowLayoutPanel2.Controls.Add(this.bananaCheck);
            this.flowLayoutPanel2.Controls.Add(this.cranberryCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 81);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // appleCheck
            // 
            this.appleCheck.AutoSize = true;
            this.appleCheck.Location = new System.Drawing.Point(3, 3);
            this.appleCheck.Name = "appleCheck";
            this.appleCheck.Size = new System.Drawing.Size(53, 17);
            this.appleCheck.TabIndex = 3;
            this.appleCheck.Text = "Apple";
            this.appleCheck.UseVisualStyleBackColor = true;
            // 
            // bananaCheck
            // 
            this.bananaCheck.AutoSize = true;
            this.bananaCheck.Location = new System.Drawing.Point(3, 26);
            this.bananaCheck.Name = "bananaCheck";
            this.bananaCheck.Size = new System.Drawing.Size(63, 17);
            this.bananaCheck.TabIndex = 4;
            this.bananaCheck.Text = "Banana";
            this.bananaCheck.UseVisualStyleBackColor = true;
            // 
            // cranberryCheck
            // 
            this.cranberryCheck.AutoSize = true;
            this.cranberryCheck.Location = new System.Drawing.Point(3, 49);
            this.cranberryCheck.Name = "cranberryCheck";
            this.cranberryCheck.Size = new System.Drawing.Size(71, 17);
            this.cranberryCheck.TabIndex = 5;
            this.cranberryCheck.Text = "Cranberry";
            this.cranberryCheck.UseVisualStyleBackColor = true;
            // 
            // ccbButton
            // 
            this.ccbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ccbButton.Location = new System.Drawing.Point(12, 224);
            this.ccbButton.Name = "ccbButton";
            this.ccbButton.Size = new System.Drawing.Size(133, 23);
            this.ccbButton.TabIndex = 4;
            this.ccbButton.Text = "Check Check Boxes";
            this.ccbButton.UseVisualStyleBackColor = true;
            this.ccbButton.Click += new System.EventHandler(this.ccbButton_Click);
            // 
            // mainFlow
            // 
            this.mainFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlow.Controls.Add(this.radioGroup);
            this.mainFlow.Controls.Add(this.checkboxGroup);
            this.mainFlow.Location = new System.Drawing.Point(0, 0);
            this.mainFlow.Name = "mainFlow";
            this.mainFlow.Size = new System.Drawing.Size(413, 213);
            this.mainFlow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 288);
            this.Controls.Add(this.mainFlow);
            this.Controls.Add(this.ccbButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.crbButton);
            this.MinimumSize = new System.Drawing.Size(223, 326);
            this.Name = "Form1";
            this.Text = "If Statements";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radioGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.checkboxGroup.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.mainFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton appleRadioButton;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.RadioButton cranberryRadioButton;
        private System.Windows.Forms.Button crbButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.GroupBox checkboxGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox appleCheck;
        private System.Windows.Forms.CheckBox bananaCheck;
        private System.Windows.Forms.CheckBox cranberryCheck;
        private System.Windows.Forms.Button ccbButton;
        private System.Windows.Forms.FlowLayoutPanel mainFlow;
    }
}

