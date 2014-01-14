namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Square_Thing
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
            this.buttomControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.speedLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.speedControlButtonsPanel = new System.Windows.Forms.Panel();
            this.speedDownButton = new System.Windows.Forms.Button();
            this.speedUpButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBoxColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scenePanel = new System.Windows.Forms.Panel();
            this.animationBox = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.buttomControlPanel.SuspendLayout();
            this.speedControlButtonsPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.scenePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttomControlPanel
            // 
            this.buttomControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttomControlPanel.ColumnCount = 3;
            this.buttomControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttomControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttomControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttomControlPanel.Controls.Add(this.speedLabel, 0, 0);
            this.buttomControlPanel.Controls.Add(this.positionLabel, 1, 0);
            this.buttomControlPanel.Controls.Add(this.speedControlButtonsPanel, 2, 0);
            this.buttomControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomControlPanel.Location = new System.Drawing.Point(0, 220);
            this.buttomControlPanel.Name = "buttomControlPanel";
            this.buttomControlPanel.RowCount = 1;
            this.buttomControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttomControlPanel.Size = new System.Drawing.Size(314, 42);
            this.buttomControlPanel.TabIndex = 0;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(10, 15);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(56, 13);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Speed: 10";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(114, 8);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(10, 8, 3, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 26);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Position:\r\n(10, 10)";
            // 
            // speedControlButtonsPanel
            // 
            this.speedControlButtonsPanel.Controls.Add(this.speedDownButton);
            this.speedControlButtonsPanel.Controls.Add(this.speedUpButton);
            this.speedControlButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedControlButtonsPanel.Location = new System.Drawing.Point(211, 3);
            this.speedControlButtonsPanel.Name = "speedControlButtonsPanel";
            this.speedControlButtonsPanel.Size = new System.Drawing.Size(100, 36);
            this.speedControlButtonsPanel.TabIndex = 1;
            // 
            // speedDownButton
            // 
            this.speedDownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.speedDownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.speedDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedDownButton.Location = new System.Drawing.Point(50, 0);
            this.speedDownButton.Name = "speedDownButton";
            this.speedDownButton.Size = new System.Drawing.Size(50, 36);
            this.speedDownButton.TabIndex = 2;
            this.speedDownButton.Text = "Speed &Down (-)";
            this.speedDownButton.UseVisualStyleBackColor = true;
            this.speedDownButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // speedUpButton
            // 
            this.speedUpButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.speedUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedUpButton.Location = new System.Drawing.Point(0, 0);
            this.speedUpButton.Name = "speedUpButton";
            this.speedUpButton.Size = new System.Drawing.Size(50, 36);
            this.speedUpButton.TabIndex = 2;
            this.speedUpButton.Text = "Speed &Up (+)";
            this.speedUpButton.UseVisualStyleBackColor = true;
            this.speedUpButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "mainMenu";
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setColorToolStripMenuItem,
            this.pauseAnimationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.blockToolStripMenuItem.Text = "Main";
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.setColorToolStripMenuItem.Text = "Begin Animation";
            this.setColorToolStripMenuItem.Click += new System.EventHandler(this.setColorToolStripMenuItem_Click);
            // 
            // pauseAnimationToolStripMenuItem
            // 
            this.pauseAnimationToolStripMenuItem.Name = "pauseAnimationToolStripMenuItem";
            this.pauseAnimationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pauseAnimationToolStripMenuItem.Text = "Pause Animation";
            this.pauseAnimationToolStripMenuItem.Click += new System.EventHandler(this.pauseAnimationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleDirectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // toggleDirectionToolStripMenuItem
            // 
            this.toggleDirectionToolStripMenuItem.Name = "toggleDirectionToolStripMenuItem";
            this.toggleDirectionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.toggleDirectionToolStripMenuItem.Text = "Toggle Direction";
            this.toggleDirectionToolStripMenuItem.Click += new System.EventHandler(this.toggleDirectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTextColorToolStripMenuItem,
            this.setBoxColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setTextColorToolStripMenuItem
            // 
            this.setTextColorToolStripMenuItem.Name = "setTextColorToolStripMenuItem";
            this.setTextColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.setTextColorToolStripMenuItem.Text = "Set Text Color";
            this.setTextColorToolStripMenuItem.Click += new System.EventHandler(this.setTextColorToolStripMenuItem_Click);
            // 
            // setBoxColorToolStripMenuItem
            // 
            this.setBoxColorToolStripMenuItem.Name = "setBoxColorToolStripMenuItem";
            this.setBoxColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.setBoxColorToolStripMenuItem.Text = "Set Box Color";
            this.setBoxColorToolStripMenuItem.Click += new System.EventHandler(this.setBoxColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.keyShortcutsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // keyShortcutsToolStripMenuItem
            // 
            this.keyShortcutsToolStripMenuItem.Name = "keyShortcutsToolStripMenuItem";
            this.keyShortcutsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.keyShortcutsToolStripMenuItem.Text = "Key Shortcuts";
            this.keyShortcutsToolStripMenuItem.Click += new System.EventHandler(this.keyShortcutsToolStripMenuItem_Click);
            // 
            // scenePanel
            // 
            this.scenePanel.Controls.Add(this.animationBox);
            this.scenePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenePanel.Location = new System.Drawing.Point(0, 24);
            this.scenePanel.Name = "scenePanel";
            this.scenePanel.Size = new System.Drawing.Size(314, 196);
            this.scenePanel.TabIndex = 3;
            // 
            // animationBox
            // 
            this.animationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.animationBox.Location = new System.Drawing.Point(10, 10);
            this.animationBox.Name = "animationBox";
            this.animationBox.Size = new System.Drawing.Size(20, 20);
            this.animationBox.TabIndex = 0;
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 262);
            this.Controls.Add(this.scenePanel);
            this.Controls.Add(this.buttomControlPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(330, 300);
            this.Name = "MainWindow";
            this.Text = "Chapter 5 Lab";
            this.buttomControlPanel.ResumeLayout(false);
            this.buttomControlPanel.PerformLayout();
            this.speedControlButtonsPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scenePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttomControlPanel;
        private System.Windows.Forms.Panel speedControlButtonsPanel;
        private System.Windows.Forms.Button speedDownButton;
        private System.Windows.Forms.Button speedUpButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.Panel scenePanel;
        private System.Windows.Forms.ToolStripMenuItem pauseAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBoxColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleDirectionToolStripMenuItem;
        private System.Windows.Forms.Label animationBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.ToolStripMenuItem keyShortcutsToolStripMenuItem;

    }
}

