namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Listbox_Demo
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
            this.listA = new System.Windows.Forms.ListBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.copyRightButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.copyLeftButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listA
            // 
            this.listA.AllowDrop = true;
            this.listA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listA.FormattingEnabled = true;
            this.listA.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Cranberry",
            "Watermelon"});
            this.listA.Location = new System.Drawing.Point(12, 37);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(138, 290);
            this.listA.TabIndex = 0;
            this.listA.DragDrop += new System.Windows.Forms.DragEventHandler(this.listA_DragDrop);
            this.listA.DragEnter += new System.Windows.Forms.DragEventHandler(this.listA_DragEnter);
            this.listA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listA_MouseDown);
            // 
            // listB
            // 
            this.listB.AllowDrop = true;
            this.listB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listB.FormattingEnabled = true;
            this.listB.Location = new System.Drawing.Point(237, 37);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(138, 290);
            this.listB.TabIndex = 1;
            this.listB.DragDrop += new System.Windows.Forms.DragEventHandler(this.listB_DragDrop);
            this.listB.DragEnter += new System.Windows.Forms.DragEventHandler(this.listB_DragEnter);
            this.listB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listB_MouseDown);
            // 
            // copyRightButton
            // 
            this.copyRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightButton.Location = new System.Drawing.Point(156, 104);
            this.copyRightButton.Name = "copyRightButton";
            this.copyRightButton.Size = new System.Drawing.Size(75, 23);
            this.copyRightButton.TabIndex = 2;
            this.copyRightButton.Text = "Copy ->>";
            this.copyRightButton.UseVisualStyleBackColor = true;
            this.copyRightButton.Click += new System.EventHandler(this.copyRightButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveRightButton.Location = new System.Drawing.Point(156, 133);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(75, 23);
            this.moveRightButton.TabIndex = 3;
            this.moveRightButton.Text = "Move ->>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveLeftButton.Location = new System.Drawing.Point(156, 212);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(75, 23);
            this.moveLeftButton.TabIndex = 5;
            this.moveLeftButton.Text = "<<- Move";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // copyLeftButton
            // 
            this.copyLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyLeftButton.Location = new System.Drawing.Point(156, 183);
            this.copyLeftButton.Name = "copyLeftButton";
            this.copyLeftButton.Size = new System.Drawing.Size(75, 23);
            this.copyLeftButton.TabIndex = 4;
            this.copyLeftButton.Text = "<<- Copy";
            this.copyLeftButton.UseVisualStyleBackColor = true;
            this.copyLeftButton.Click += new System.EventHandler(this.copyLeftButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(156, 304);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "E&xit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(6, 19);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 9;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(87, 19);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print List";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countButton);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 49);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List A Controls";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.copyLeftButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.copyRightButton);
            this.Controls.Add(this.listB);
            this.Controls.Add(this.listA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(404, 440);
            this.MinimumSize = new System.Drawing.Size(404, 440);
            this.Name = "MainWindow";
            this.Text = "Listbox Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.ListBox listB;
        private System.Windows.Forms.Button copyRightButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button copyLeftButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox groupBox1;


    }
}

