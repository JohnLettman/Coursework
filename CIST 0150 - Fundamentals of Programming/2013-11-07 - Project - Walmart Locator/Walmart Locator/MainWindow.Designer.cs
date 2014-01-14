namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Walmart_Locator
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.locatorPage = new System.Windows.Forms.TabPage();
            this.locationLabel = new System.Windows.Forms.Label();
            this.storeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.mapPage = new System.Windows.Forms.TabPage();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.mainTabs.SuspendLayout();
            this.locatorPage.SuspendLayout();
            this.mapPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.locatorPage);
            this.mainTabs.Controls.Add(this.mapPage);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(478, 324);
            this.mainTabs.TabIndex = 0;
            // 
            // locatorPage
            // 
            this.locatorPage.Controls.Add(this.locationLabel);
            this.locatorPage.Controls.Add(this.storeSelectionComboBox);
            this.locatorPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locatorPage.Location = new System.Drawing.Point(4, 25);
            this.locatorPage.Name = "locatorPage";
            this.locatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.locatorPage.Size = new System.Drawing.Size(470, 295);
            this.locatorPage.TabIndex = 0;
            this.locatorPage.Text = "Walmart Locator";
            this.locatorPage.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.locationLabel.Location = new System.Drawing.Point(8, 46);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(454, 244);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeSelectionComboBox
            // 
            this.storeSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeSelectionComboBox.FormattingEnabled = true;
            this.storeSelectionComboBox.Location = new System.Drawing.Point(8, 6);
            this.storeSelectionComboBox.Name = "storeSelectionComboBox";
            this.storeSelectionComboBox.Size = new System.Drawing.Size(454, 24);
            this.storeSelectionComboBox.TabIndex = 0;
            this.storeSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.storeSelectionComboBox_SelectedIndexChanged);
            // 
            // mapPage
            // 
            this.mapPage.Controls.Add(this.mapBrowser);
            this.mapPage.Location = new System.Drawing.Point(4, 25);
            this.mapPage.Name = "mapPage";
            this.mapPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapPage.Size = new System.Drawing.Size(470, 295);
            this.mapPage.TabIndex = 1;
            this.mapPage.Text = "Map";
            this.mapPage.UseVisualStyleBackColor = true;
            // 
            // mapBrowser
            // 
            this.mapBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBrowser.Location = new System.Drawing.Point(3, 3);
            this.mapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.Size = new System.Drawing.Size(464, 289);
            this.mapBrowser.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 324);
            this.Controls.Add(this.mainTabs);
            this.MinimumSize = new System.Drawing.Size(280, 190);
            this.Name = "MainWindow";
            this.Text = "Walmart Locator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainTabs.ResumeLayout(false);
            this.locatorPage.ResumeLayout(false);
            this.mapPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage locatorPage;
        private System.Windows.Forms.TabPage mapPage;
        private System.Windows.Forms.ComboBox storeSelectionComboBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.WebBrowser mapBrowser;
    }
}

