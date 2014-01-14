namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Change_Pictures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.selectPictureGroupBox = new System.Windows.Forms.GroupBox();
            this.buttomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topTable = new System.Windows.Forms.TableLayoutPanel();
            this.koalaRadio = new System.Windows.Forms.RadioButton();
            this.lighthouseRadio = new System.Windows.Forms.RadioButton();
            this.tulipsRadio = new System.Windows.Forms.RadioButton();
            this.penguinsRadio = new System.Windows.Forms.RadioButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.showPictureCheckbox = new System.Windows.Forms.CheckBox();
            this.showSelectionsCheckbox = new System.Windows.Forms.CheckBox();
            this.blackTextRadio = new System.Windows.Forms.RadioButton();
            this.blueTextRadio = new System.Windows.Forms.RadioButton();
            this.selectPictureGroupBox.SuspendLayout();
            this.buttomLayout.SuspendLayout();
            this.topTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPictureGroupBox
            // 
            this.selectPictureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPictureGroupBox.Controls.Add(this.buttomLayout);
            this.selectPictureGroupBox.Controls.Add(this.topTable);
            this.selectPictureGroupBox.Location = new System.Drawing.Point(12, 338);
            this.selectPictureGroupBox.Name = "selectPictureGroupBox";
            this.selectPictureGroupBox.Size = new System.Drawing.Size(520, 92);
            this.selectPictureGroupBox.TabIndex = 0;
            this.selectPictureGroupBox.TabStop = false;
            this.selectPictureGroupBox.Text = "Select Picture";
            // 
            // buttomLayout
            // 
            this.buttomLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomLayout.AutoSize = true;
            this.buttomLayout.ColumnCount = 4;
            this.buttomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttomLayout.Controls.Add(this.showPictureCheckbox, 0, 0);
            this.buttomLayout.Controls.Add(this.showSelectionsCheckbox, 1, 0);
            this.buttomLayout.Controls.Add(this.blackTextRadio, 2, 0);
            this.buttomLayout.Controls.Add(this.blueTextRadio, 3, 0);
            this.buttomLayout.Location = new System.Drawing.Point(6, 55);
            this.buttomLayout.Name = "buttomLayout";
            this.buttomLayout.RowCount = 1;
            this.buttomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttomLayout.Size = new System.Drawing.Size(508, 27);
            this.buttomLayout.TabIndex = 3;
            // 
            // topTable
            // 
            this.topTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topTable.ColumnCount = 4;
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTable.Controls.Add(this.koalaRadio, 0, 0);
            this.topTable.Controls.Add(this.lighthouseRadio, 1, 0);
            this.topTable.Controls.Add(this.tulipsRadio, 3, 0);
            this.topTable.Controls.Add(this.penguinsRadio, 2, 0);
            this.topTable.Location = new System.Drawing.Point(6, 19);
            this.topTable.Name = "topTable";
            this.topTable.RowCount = 1;
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topTable.Size = new System.Drawing.Size(508, 30);
            this.topTable.TabIndex = 2;
            // 
            // koalaRadio
            // 
            this.koalaRadio.AutoSize = true;
            this.koalaRadio.Checked = true;
            this.koalaRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koalaRadio.Location = new System.Drawing.Point(3, 3);
            this.koalaRadio.Name = "koalaRadio";
            this.koalaRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.koalaRadio.Size = new System.Drawing.Size(121, 24);
            this.koalaRadio.TabIndex = 0;
            this.koalaRadio.TabStop = true;
            this.koalaRadio.Text = "Koala";
            this.koalaRadio.UseVisualStyleBackColor = true;
            this.koalaRadio.CheckedChanged += new System.EventHandler(this.koalaRadio_CheckedChanged);
            // 
            // lighthouseRadio
            // 
            this.lighthouseRadio.AutoSize = true;
            this.lighthouseRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lighthouseRadio.Location = new System.Drawing.Point(130, 3);
            this.lighthouseRadio.Name = "lighthouseRadio";
            this.lighthouseRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lighthouseRadio.Size = new System.Drawing.Size(121, 24);
            this.lighthouseRadio.TabIndex = 1;
            this.lighthouseRadio.Text = "Lighthouse";
            this.lighthouseRadio.UseVisualStyleBackColor = true;
            this.lighthouseRadio.CheckedChanged += new System.EventHandler(this.lighthouseRadio_CheckedChanged);
            // 
            // tulipsRadio
            // 
            this.tulipsRadio.AutoSize = true;
            this.tulipsRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tulipsRadio.Location = new System.Drawing.Point(384, 3);
            this.tulipsRadio.Name = "tulipsRadio";
            this.tulipsRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tulipsRadio.Size = new System.Drawing.Size(121, 24);
            this.tulipsRadio.TabIndex = 3;
            this.tulipsRadio.Text = "Tulips";
            this.tulipsRadio.UseVisualStyleBackColor = true;
            this.tulipsRadio.CheckedChanged += new System.EventHandler(this.tulipsRadio_CheckedChanged);
            // 
            // penguinsRadio
            // 
            this.penguinsRadio.AutoSize = true;
            this.penguinsRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penguinsRadio.Location = new System.Drawing.Point(257, 3);
            this.penguinsRadio.Name = "penguinsRadio";
            this.penguinsRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.penguinsRadio.Size = new System.Drawing.Size(121, 24);
            this.penguinsRadio.TabIndex = 2;
            this.penguinsRadio.Text = "Penguins";
            this.penguinsRadio.UseVisualStyleBackColor = true;
            this.penguinsRadio.CheckedChanged += new System.EventHandler(this.penguinsRadio_CheckedChanged);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Image = global::UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Change_Pictures.Properties.Resources.Koala;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(520, 320);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // showPictureCheckbox
            // 
            this.showPictureCheckbox.AutoSize = true;
            this.showPictureCheckbox.Checked = true;
            this.showPictureCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPictureCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPictureCheckbox.Location = new System.Drawing.Point(3, 3);
            this.showPictureCheckbox.Name = "showPictureCheckbox";
            this.showPictureCheckbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showPictureCheckbox.Size = new System.Drawing.Size(121, 21);
            this.showPictureCheckbox.TabIndex = 2;
            this.showPictureCheckbox.Text = "Show Picture";
            this.showPictureCheckbox.UseVisualStyleBackColor = true;
            this.showPictureCheckbox.CheckedChanged += new System.EventHandler(this.showPictureCheckbox_CheckedChanged);
            // 
            // showSelectionsCheckbox
            // 
            this.showSelectionsCheckbox.AutoSize = true;
            this.showSelectionsCheckbox.Checked = true;
            this.showSelectionsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSelectionsCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSelectionsCheckbox.Location = new System.Drawing.Point(130, 3);
            this.showSelectionsCheckbox.Name = "showSelectionsCheckbox";
            this.showSelectionsCheckbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showSelectionsCheckbox.Size = new System.Drawing.Size(121, 21);
            this.showSelectionsCheckbox.TabIndex = 3;
            this.showSelectionsCheckbox.Text = "Show Selections";
            this.showSelectionsCheckbox.UseVisualStyleBackColor = true;
            this.showSelectionsCheckbox.CheckedChanged += new System.EventHandler(this.showSelectionsCheckbox_CheckedChanged);
            // 
            // blackTextRadio
            // 
            this.blackTextRadio.AutoSize = true;
            this.blackTextRadio.Checked = true;
            this.blackTextRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackTextRadio.Location = new System.Drawing.Point(257, 3);
            this.blackTextRadio.Name = "blackTextRadio";
            this.blackTextRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.blackTextRadio.Size = new System.Drawing.Size(121, 21);
            this.blackTextRadio.TabIndex = 4;
            this.blackTextRadio.TabStop = true;
            this.blackTextRadio.Text = "Black Text";
            this.blackTextRadio.UseVisualStyleBackColor = true;
            this.blackTextRadio.CheckedChanged += new System.EventHandler(this.blackTextRadio_CheckedChanged);
            // 
            // blueTextRadio
            // 
            this.blueTextRadio.AutoSize = true;
            this.blueTextRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTextRadio.Location = new System.Drawing.Point(384, 3);
            this.blueTextRadio.Name = "blueTextRadio";
            this.blueTextRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.blueTextRadio.Size = new System.Drawing.Size(121, 21);
            this.blueTextRadio.TabIndex = 5;
            this.blueTextRadio.Text = "Blue Text";
            this.blueTextRadio.UseVisualStyleBackColor = true;
            this.blueTextRadio.CheckedChanged += new System.EventHandler(this.blueTextRadio_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 442);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.selectPictureGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 480);
            this.Name = "MainWindow";
            this.Text = "Change Pictures";
            this.selectPictureGroupBox.ResumeLayout(false);
            this.selectPictureGroupBox.PerformLayout();
            this.buttomLayout.ResumeLayout(false);
            this.buttomLayout.PerformLayout();
            this.topTable.ResumeLayout(false);
            this.topTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectPictureGroupBox;
        private System.Windows.Forms.RadioButton koalaRadio;
        private System.Windows.Forms.RadioButton lighthouseRadio;
        private System.Windows.Forms.RadioButton penguinsRadio;
        private System.Windows.Forms.RadioButton tulipsRadio;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TableLayoutPanel topTable;
        private System.Windows.Forms.TableLayoutPanel buttomLayout;
        private System.Windows.Forms.CheckBox showPictureCheckbox;
        private System.Windows.Forms.CheckBox showSelectionsCheckbox;
        private System.Windows.Forms.RadioButton blackTextRadio;
        private System.Windows.Forms.RadioButton blueTextRadio;
    }
}

