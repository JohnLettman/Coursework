namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Flag_Viewer
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
            this.countryGroup = new System.Windows.Forms.GroupBox();
            this.countryFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.unitedStatesFlagRadio = new System.Windows.Forms.RadioButton();
            this.japanFlagRadio = new System.Windows.Forms.RadioButton();
            this.mexicoFlagRadio = new System.Windows.Forms.RadioButton();
            this.russiaFlagRadio = new System.Windows.Forms.RadioButton();
            this.chinaFlagRadio = new System.Windows.Forms.RadioButton();
            this.canadaFlagRadio = new System.Windows.Forms.RadioButton();
            this.displayGroup = new System.Windows.Forms.GroupBox();
            this.displayFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.titleCheckbox = new System.Windows.Forms.CheckBox();
            this.countryNameCheckbox = new System.Windows.Forms.CheckBox();
            this.programmerCheckbox = new System.Windows.Forms.CheckBox();
            this.flagImage = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.programmerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.creditsPanel = new System.Windows.Forms.Panel();
            this.countryNamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.countryLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.countryGroup.SuspendLayout();
            this.countryFlow.SuspendLayout();
            this.displayGroup.SuspendLayout();
            this.displayFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.creditsPanel.SuspendLayout();
            this.countryNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryGroup
            // 
            this.countryGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.countryGroup.Controls.Add(this.countryFlow);
            this.countryGroup.Location = new System.Drawing.Point(12, 50);
            this.countryGroup.Name = "countryGroup";
            this.countryGroup.Size = new System.Drawing.Size(160, 190);
            this.countryGroup.TabIndex = 1;
            this.countryGroup.TabStop = false;
            this.countryGroup.Text = "Country";
            // 
            // countryFlow
            // 
            this.countryFlow.Controls.Add(this.unitedStatesFlagRadio);
            this.countryFlow.Controls.Add(this.japanFlagRadio);
            this.countryFlow.Controls.Add(this.mexicoFlagRadio);
            this.countryFlow.Controls.Add(this.russiaFlagRadio);
            this.countryFlow.Controls.Add(this.chinaFlagRadio);
            this.countryFlow.Controls.Add(this.canadaFlagRadio);
            this.countryFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.countryFlow.Location = new System.Drawing.Point(3, 16);
            this.countryFlow.Name = "countryFlow";
            this.countryFlow.Size = new System.Drawing.Size(154, 171);
            this.countryFlow.TabIndex = 0;
            // 
            // unitedStatesFlagRadio
            // 
            this.unitedStatesFlagRadio.AutoSize = true;
            this.unitedStatesFlagRadio.Location = new System.Drawing.Point(3, 3);
            this.unitedStatesFlagRadio.Name = "unitedStatesFlagRadio";
            this.unitedStatesFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.unitedStatesFlagRadio.Size = new System.Drawing.Size(99, 22);
            this.unitedStatesFlagRadio.TabIndex = 0;
            this.unitedStatesFlagRadio.TabStop = true;
            this.unitedStatesFlagRadio.Text = "United States";
            this.unitedStatesFlagRadio.UseVisualStyleBackColor = true;
            this.unitedStatesFlagRadio.CheckedChanged += new System.EventHandler(this.unitedStatesFlagRadio_CheckedChanged);
            // 
            // japanFlagRadio
            // 
            this.japanFlagRadio.AutoSize = true;
            this.japanFlagRadio.Location = new System.Drawing.Point(3, 31);
            this.japanFlagRadio.Name = "japanFlagRadio";
            this.japanFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.japanFlagRadio.Size = new System.Drawing.Size(64, 22);
            this.japanFlagRadio.TabIndex = 1;
            this.japanFlagRadio.TabStop = true;
            this.japanFlagRadio.Text = "Japan";
            this.japanFlagRadio.UseVisualStyleBackColor = true;
            this.japanFlagRadio.CheckedChanged += new System.EventHandler(this.japanFlagRadio_CheckedChanged);
            // 
            // mexicoFlagRadio
            // 
            this.mexicoFlagRadio.AutoSize = true;
            this.mexicoFlagRadio.Location = new System.Drawing.Point(3, 59);
            this.mexicoFlagRadio.Name = "mexicoFlagRadio";
            this.mexicoFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.mexicoFlagRadio.Size = new System.Drawing.Size(69, 22);
            this.mexicoFlagRadio.TabIndex = 2;
            this.mexicoFlagRadio.TabStop = true;
            this.mexicoFlagRadio.Text = "Mexico";
            this.mexicoFlagRadio.UseVisualStyleBackColor = true;
            this.mexicoFlagRadio.CheckedChanged += new System.EventHandler(this.mexicoFlagRadio_CheckedChanged);
            // 
            // russiaFlagRadio
            // 
            this.russiaFlagRadio.AutoSize = true;
            this.russiaFlagRadio.Location = new System.Drawing.Point(3, 87);
            this.russiaFlagRadio.Name = "russiaFlagRadio";
            this.russiaFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.russiaFlagRadio.Size = new System.Drawing.Size(67, 22);
            this.russiaFlagRadio.TabIndex = 3;
            this.russiaFlagRadio.TabStop = true;
            this.russiaFlagRadio.Text = "Russia";
            this.russiaFlagRadio.UseVisualStyleBackColor = true;
            this.russiaFlagRadio.CheckedChanged += new System.EventHandler(this.russiaFlagRadio_CheckedChanged);
            // 
            // chinaFlagRadio
            // 
            this.chinaFlagRadio.AutoSize = true;
            this.chinaFlagRadio.Location = new System.Drawing.Point(3, 115);
            this.chinaFlagRadio.Name = "chinaFlagRadio";
            this.chinaFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.chinaFlagRadio.Size = new System.Drawing.Size(62, 22);
            this.chinaFlagRadio.TabIndex = 4;
            this.chinaFlagRadio.TabStop = true;
            this.chinaFlagRadio.Text = "China";
            this.chinaFlagRadio.UseVisualStyleBackColor = true;
            this.chinaFlagRadio.CheckedChanged += new System.EventHandler(this.chinaFlagRadio_CheckedChanged);
            // 
            // canadaFlagRadio
            // 
            this.canadaFlagRadio.AutoSize = true;
            this.canadaFlagRadio.Location = new System.Drawing.Point(3, 143);
            this.canadaFlagRadio.Name = "canadaFlagRadio";
            this.canadaFlagRadio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.canadaFlagRadio.Size = new System.Drawing.Size(72, 22);
            this.canadaFlagRadio.TabIndex = 5;
            this.canadaFlagRadio.TabStop = true;
            this.canadaFlagRadio.Text = "Canada";
            this.canadaFlagRadio.UseVisualStyleBackColor = true;
            this.canadaFlagRadio.CheckedChanged += new System.EventHandler(this.canadaFlagRadio_CheckedChanged);
            // 
            // displayGroup
            // 
            this.displayGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayGroup.Controls.Add(this.displayFlow);
            this.displayGroup.Location = new System.Drawing.Point(484, 50);
            this.displayGroup.Name = "displayGroup";
            this.displayGroup.Size = new System.Drawing.Size(160, 190);
            this.displayGroup.TabIndex = 2;
            this.displayGroup.TabStop = false;
            this.displayGroup.Text = "Display";
            // 
            // displayFlow
            // 
            this.displayFlow.Controls.Add(this.titleCheckbox);
            this.displayFlow.Controls.Add(this.countryNameCheckbox);
            this.displayFlow.Controls.Add(this.programmerCheckbox);
            this.displayFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.displayFlow.Location = new System.Drawing.Point(3, 16);
            this.displayFlow.Name = "displayFlow";
            this.displayFlow.Size = new System.Drawing.Size(154, 171);
            this.displayFlow.TabIndex = 0;
            // 
            // titleCheckbox
            // 
            this.titleCheckbox.AutoSize = true;
            this.titleCheckbox.Checked = true;
            this.titleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.titleCheckbox.Location = new System.Drawing.Point(3, 3);
            this.titleCheckbox.Name = "titleCheckbox";
            this.titleCheckbox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.titleCheckbox.Size = new System.Drawing.Size(56, 22);
            this.titleCheckbox.TabIndex = 0;
            this.titleCheckbox.Text = "Title";
            this.titleCheckbox.UseVisualStyleBackColor = true;
            this.titleCheckbox.CheckedChanged += new System.EventHandler(this.titleCheckbox_CheckedChanged);
            // 
            // countryNameCheckbox
            // 
            this.countryNameCheckbox.AutoSize = true;
            this.countryNameCheckbox.Checked = true;
            this.countryNameCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countryNameCheckbox.Location = new System.Drawing.Point(3, 31);
            this.countryNameCheckbox.Name = "countryNameCheckbox";
            this.countryNameCheckbox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.countryNameCheckbox.Size = new System.Drawing.Size(103, 22);
            this.countryNameCheckbox.TabIndex = 1;
            this.countryNameCheckbox.Text = "Country Name";
            this.countryNameCheckbox.UseVisualStyleBackColor = true;
            this.countryNameCheckbox.CheckedChanged += new System.EventHandler(this.countryNameCheckbox_CheckedChanged);
            // 
            // programmerCheckbox
            // 
            this.programmerCheckbox.AutoSize = true;
            this.programmerCheckbox.Checked = true;
            this.programmerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.programmerCheckbox.Location = new System.Drawing.Point(3, 59);
            this.programmerCheckbox.Name = "programmerCheckbox";
            this.programmerCheckbox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.programmerCheckbox.Size = new System.Drawing.Size(127, 22);
            this.programmerCheckbox.TabIndex = 2;
            this.programmerCheckbox.Text = "Programmer Credits";
            this.programmerCheckbox.UseVisualStyleBackColor = true;
            this.programmerCheckbox.CheckedChanged += new System.EventHandler(this.programmerCheckbox_CheckedChanged);
            // 
            // flagImage
            // 
            this.flagImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flagImage.Location = new System.Drawing.Point(178, 59);
            this.flagImage.Name = "flagImage";
            this.flagImage.Size = new System.Drawing.Size(300, 181);
            this.flagImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagImage.TabIndex = 3;
            this.flagImage.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.ColumnCount = 1;
            this.titlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titlePanel.Controls.Add(this.titleLabel, 0, 0);
            this.titlePanel.Location = new System.Drawing.Point(12, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.RowCount = 1;
            this.titlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.titlePanel.Size = new System.Drawing.Size(632, 32);
            this.titlePanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(626, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Flag Viewer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Location = new System.Drawing.Point(9, 15);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(150, 13);
            this.programmerLabel.TabIndex = 5;
            this.programmerLabel.Text = "Programmed by: John Lettman";
            // 
            // programmerLinkLabel
            // 
            this.programmerLinkLabel.AutoSize = true;
            this.programmerLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.programmerLinkLabel.Location = new System.Drawing.Point(157, 15);
            this.programmerLinkLabel.Name = "programmerLinkLabel";
            this.programmerLinkLabel.Size = new System.Drawing.Size(104, 13);
            this.programmerLinkLabel.TabIndex = 6;
            this.programmerLinkLabel.TabStop = true;
            this.programmerLinkLabel.Text = "<jlettman@acm.org>";
            this.programmerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.programmerLinkLabel_LinkClicked);
            // 
            // creditsPanel
            // 
            this.creditsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creditsPanel.Controls.Add(this.programmerLabel);
            this.creditsPanel.Controls.Add(this.programmerLinkLabel);
            this.creditsPanel.Location = new System.Drawing.Point(0, 286);
            this.creditsPanel.Name = "creditsPanel";
            this.creditsPanel.Size = new System.Drawing.Size(304, 37);
            this.creditsPanel.TabIndex = 7;
            // 
            // countryNamePanel
            // 
            this.countryNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryNamePanel.ColumnCount = 1;
            this.countryNamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countryNamePanel.Controls.Add(this.countryLabel, 0, 0);
            this.countryNamePanel.Location = new System.Drawing.Point(12, 246);
            this.countryNamePanel.Name = "countryNamePanel";
            this.countryNamePanel.RowCount = 1;
            this.countryNamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.countryNamePanel.Size = new System.Drawing.Size(632, 32);
            this.countryNamePanel.TabIndex = 8;
            // 
            // countryLabel
            // 
            this.countryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(3, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(626, 32);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(572, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 28);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 332);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countryNamePanel);
            this.Controls.Add(this.creditsPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.flagImage);
            this.Controls.Add(this.displayGroup);
            this.Controls.Add(this.countryGroup);
            this.MinimumSize = new System.Drawing.Size(472, 370);
            this.Name = "MainWindow";
            this.Text = "Flag Viewer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.countryGroup.ResumeLayout(false);
            this.countryFlow.ResumeLayout(false);
            this.countryFlow.PerformLayout();
            this.displayGroup.ResumeLayout(false);
            this.displayFlow.ResumeLayout(false);
            this.displayFlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.creditsPanel.ResumeLayout(false);
            this.creditsPanel.PerformLayout();
            this.countryNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox countryGroup;
        private System.Windows.Forms.GroupBox displayGroup;
        private System.Windows.Forms.PictureBox flagImage;
        private System.Windows.Forms.FlowLayoutPanel countryFlow;
        private System.Windows.Forms.RadioButton unitedStatesFlagRadio;
        private System.Windows.Forms.RadioButton japanFlagRadio;
        private System.Windows.Forms.RadioButton mexicoFlagRadio;
        private System.Windows.Forms.RadioButton russiaFlagRadio;
        private System.Windows.Forms.RadioButton chinaFlagRadio;
        private System.Windows.Forms.RadioButton canadaFlagRadio;
        private System.Windows.Forms.FlowLayoutPanel displayFlow;
        private System.Windows.Forms.CheckBox titleCheckbox;
        private System.Windows.Forms.CheckBox countryNameCheckbox;
        private System.Windows.Forms.CheckBox programmerCheckbox;
        private System.Windows.Forms.TableLayoutPanel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.LinkLabel programmerLinkLabel;
        private System.Windows.Forms.Panel creditsPanel;
        private System.Windows.Forms.TableLayoutPanel countryNamePanel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

