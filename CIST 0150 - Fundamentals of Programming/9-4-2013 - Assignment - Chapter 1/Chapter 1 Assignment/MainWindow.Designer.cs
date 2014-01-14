namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Chapter_1_Assignment
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
            this.fullNameButton = new System.Windows.Forms.Button();
            this.majorButton = new System.Windows.Forms.Button();
            this.telephoneButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.programmedByLabel = new System.Windows.Forms.Label();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.havePictureLink = new System.Windows.Forms.LinkLabel();
            this.mePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameButton
            // 
            this.fullNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameButton.Location = new System.Drawing.Point(12, 12);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(120, 30);
            this.fullNameButton.TabIndex = 0;
            this.fullNameButton.Text = "Full Name";
            this.fullNameButton.UseVisualStyleBackColor = true;
            this.fullNameButton.Click += new System.EventHandler(this.fullNameButton_Click);
            // 
            // majorButton
            // 
            this.majorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorButton.Location = new System.Drawing.Point(12, 48);
            this.majorButton.Name = "majorButton";
            this.majorButton.Size = new System.Drawing.Size(120, 30);
            this.majorButton.TabIndex = 1;
            this.majorButton.Text = "Major";
            this.majorButton.UseVisualStyleBackColor = true;
            this.majorButton.Click += new System.EventHandler(this.majorButton_Click);
            // 
            // telephoneButton
            // 
            this.telephoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneButton.Location = new System.Drawing.Point(12, 84);
            this.telephoneButton.Name = "telephoneButton";
            this.telephoneButton.Size = new System.Drawing.Size(120, 30);
            this.telephoneButton.TabIndex = 2;
            this.telephoneButton.Text = "Telephone";
            this.telephoneButton.UseVisualStyleBackColor = true;
            this.telephoneButton.Click += new System.EventHandler(this.telephoneButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(138, 12);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(284, 30);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // majorLabel
            // 
            this.majorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(138, 48);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(284, 30);
            this.majorLabel.TabIndex = 4;
            this.majorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(138, 84);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(284, 30);
            this.telephoneLabel.TabIndex = 5;
            this.telephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(347, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // programmedByLabel
            // 
            this.programmedByLabel.AutoSize = true;
            this.programmedByLabel.Location = new System.Drawing.Point(9, 182);
            this.programmedByLabel.Name = "programmedByLabel";
            this.programmedByLabel.Size = new System.Drawing.Size(150, 13);
            this.programmedByLabel.TabIndex = 8;
            this.programmedByLabel.Text = "Programmed by: John Lettman";
            // 
            // emailLink
            // 
            this.emailLink.AutoSize = true;
            this.emailLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.emailLink.Location = new System.Drawing.Point(157, 182);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(104, 13);
            this.emailLink.TabIndex = 9;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "<jlettman@acm.org>";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // havePictureLink
            // 
            this.havePictureLink.AutoSize = true;
            this.havePictureLink.Location = new System.Drawing.Point(12, 121);
            this.havePictureLink.Name = "havePictureLink";
            this.havePictureLink.Size = new System.Drawing.Size(98, 13);
            this.havePictureLink.TabIndex = 11;
            this.havePictureLink.TabStop = true;
            this.havePictureLink.Text = "Have a picture too.";
            this.havePictureLink.Visible = false;
            this.havePictureLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.havePictureLink_LinkClicked);
            // 
            // mePicture
            // 
            this.mePicture.Image = global::UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Chapter_1_Assignment.Properties.Resources.john_lettman_litmag_portrait;
            this.mePicture.Location = new System.Drawing.Point(321, 12);
            this.mePicture.Name = "mePicture";
            this.mePicture.Size = new System.Drawing.Size(101, 102);
            this.mePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mePicture.TabIndex = 12;
            this.mePicture.TabStop = false;
            this.mePicture.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.mePicture);
            this.Controls.Add(this.havePictureLink);
            this.Controls.Add(this.emailLink);
            this.Controls.Add(this.programmedByLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.telephoneButton);
            this.Controls.Add(this.majorButton);
            this.Controls.Add(this.fullNameButton);
            this.MaximumSize = new System.Drawing.Size(450, 250);
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "MainWindow";
            this.Text = "Contact Information for John Lettman";
            ((System.ComponentModel.ISupportInitialize)(this.mePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullNameButton;
        private System.Windows.Forms.Button majorButton;
        private System.Windows.Forms.Button telephoneButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label programmedByLabel;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.LinkLabel havePictureLink;
        private System.Windows.Forms.PictureBox mePicture;
    }
}

