namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Web_Browser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.goButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.browserWindow = new System.Windows.Forms.WebBrowser();
            this.topAreaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.urlBar = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.bottomStrip = new System.Windows.Forms.StatusStrip();
            this.pageLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.securePageIndicatorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.topAreaPanel.SuspendLayout();
            this.bottomStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButtonTooltip
            // 
            this.goButtonTooltip.ToolTipTitle = "Go button";
            // 
            // browserWindow
            // 
            this.browserWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserWindow.Location = new System.Drawing.Point(0, 30);
            this.browserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserWindow.Name = "browserWindow";
            this.browserWindow.Size = new System.Drawing.Size(687, 393);
            this.browserWindow.TabIndex = 2;
            this.browserWindow.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browserWindow_Navigated);
            this.browserWindow.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.browserWindow_ProgressChanged);
            // 
            // topAreaPanel
            // 
            this.topAreaPanel.BackColor = System.Drawing.Color.Azure;
            this.topAreaPanel.Controls.Add(this.urlBar);
            this.topAreaPanel.Controls.Add(this.goButton);
            this.topAreaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topAreaPanel.Location = new System.Drawing.Point(0, 0);
            this.topAreaPanel.Name = "topAreaPanel";
            this.topAreaPanel.Size = new System.Drawing.Size(687, 28);
            this.topAreaPanel.TabIndex = 3;
            // 
            // urlBar
            // 
            this.urlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBar.FormattingEnabled = true;
            this.urlBar.Location = new System.Drawing.Point(3, 3);
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(411, 21);
            this.urlBar.TabIndex = 0;
            this.urlBar.SelectedIndexChanged += new System.EventHandler(this.urlBar_SelectedIndexChanged);
            this.urlBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlBar_KeyUp);
            // 
            // goButton
            // 
            this.goButton.AccessibleDescription = "Goes to the entered URL";
            this.goButton.AccessibleName = "Go";
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goButton.Location = new System.Drawing.Point(420, 3);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(25, 21);
            this.goButton.TabIndex = 1;
            this.goButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // bottomStrip
            // 
            this.bottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageLoadProgress,
            this.securePageIndicatorLabel});
            this.bottomStrip.Location = new System.Drawing.Point(0, 426);
            this.bottomStrip.Name = "bottomStrip";
            this.bottomStrip.Size = new System.Drawing.Size(687, 22);
            this.bottomStrip.TabIndex = 4;
            this.bottomStrip.Text = "statusStrip1";
            // 
            // pageLoadProgress
            // 
            this.pageLoadProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pageLoadProgress.Name = "pageLoadProgress";
            this.pageLoadProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pageLoadProgress.Size = new System.Drawing.Size(100, 16);
            this.pageLoadProgress.ToolTipText = "Progress";
            // 
            // securePageIndicatorLabel
            // 
            this.securePageIndicatorLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.securePageIndicatorLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.securePageIndicatorLabel.Name = "securePageIndicatorLabel";
            this.securePageIndicatorLabel.Size = new System.Drawing.Size(71, 17);
            this.securePageIndicatorLabel.Text = "Secure Page";
            this.securePageIndicatorLabel.Visible = false;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 448);
            this.Controls.Add(this.bottomStrip);
            this.Controls.Add(this.topAreaPanel);
            this.Controls.Add(this.browserWindow);
            this.Name = "Browser";
            this.Text = "Icewolf";
            this.topAreaPanel.ResumeLayout(false);
            this.bottomStrip.ResumeLayout(false);
            this.bottomStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip goButtonTooltip;
        private System.Windows.Forms.WebBrowser browserWindow;
        private System.Windows.Forms.FlowLayoutPanel topAreaPanel;
        private System.Windows.Forms.ComboBox urlBar;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.StatusStrip bottomStrip;
        private System.Windows.Forms.ToolStripProgressBar pageLoadProgress;
        private System.Windows.Forms.ToolStripStatusLabel securePageIndicatorLabel;
    }
}

