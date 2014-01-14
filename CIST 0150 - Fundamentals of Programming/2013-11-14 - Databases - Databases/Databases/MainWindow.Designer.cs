namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Databases
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
            this.friendsCombobox = new System.Windows.Forms.ComboBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataSet = new Databases.ContactListDataSet();
            this.friendsTableAdapter = new Databases.ContactListDataSetTableAdapters.FriendsTableAdapter();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.contactPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.photoTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // friendsCombobox
            // 
            this.friendsCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsCombobox.DataSource = this.friendsBindingSource;
            this.friendsCombobox.DisplayMember = "FullName";
            this.friendsCombobox.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsCombobox.FormattingEnabled = true;
            this.friendsCombobox.Location = new System.Drawing.Point(12, 36);
            this.friendsCombobox.Name = "friendsCombobox";
            this.friendsCombobox.Size = new System.Drawing.Size(367, 27);
            this.friendsCombobox.TabIndex = 0;
            this.friendsCombobox.ValueMember = "ID";
            this.friendsCombobox.SelectedIndexChanged += new System.EventHandler(this.friendsCombobox_SelectedIndexChanged);
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.contactListDataSet;
            // 
            // contactListDataSet
            // 
            this.contactListDataSet.DataSetName = "ContactListDataSet";
            this.contactListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // friendsTableAdapter
            // 
            this.friendsTableAdapter.ClearBeforeFill = true;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsBindingSource, "LastName", true));
            this.lastNameTextbox.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.Location = new System.Drawing.Point(92, 85);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(253, 25);
            this.lastNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsBindingSource, "FirstName", true));
            this.firstNameTextbox.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.Location = new System.Drawing.Point(92, 116);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(253, 25);
            this.firstNameTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsBindingSource, "Email", true));
            this.emailTextbox.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(92, 147);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(253, 25);
            this.emailTextbox.TabIndex = 5;
            // 
            // contactPhoto
            // 
            this.contactPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPhoto.Location = new System.Drawing.Point(12, 209);
            this.contactPhoto.Name = "contactPhoto";
            this.contactPhoto.Size = new System.Drawing.Size(367, 162);
            this.contactPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactPhoto.TabIndex = 9;
            this.contactPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Photo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // photoTextbox
            // 
            this.photoTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoTextbox.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoTextbox.Location = new System.Drawing.Point(92, 178);
            this.photoTextbox.Name = "photoTextbox";
            this.photoTextbox.Size = new System.Drawing.Size(253, 25);
            this.photoTextbox.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.photoTextbox);
            this.Controls.Add(this.contactPhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.friendsCombobox);
            this.Name = "MainWindow";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox friendsCombobox;
        private ContactListDataSet contactListDataSet;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private ContactListDataSetTableAdapters.FriendsTableAdapter friendsTableAdapter;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.PictureBox contactPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox photoTextbox;
    }
}

