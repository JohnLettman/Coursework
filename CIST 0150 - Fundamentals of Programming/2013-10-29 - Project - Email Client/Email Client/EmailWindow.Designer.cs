namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Email_Client
{
    partial class EmailWindow
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
            this.addressBookList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sendLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.toList = new System.Windows.Forms.ListBox();
            this.subjectInput = new System.Windows.Forms.TextBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.newContactInput = new System.Windows.Forms.TextBox();
            this.sendLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressBookList
            // 
            this.addressBookList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addressBookList.FormattingEnabled = true;
            this.addressBookList.Items.AddRange(new object[] {
            "abc@example.com",
            "def@example.com"});
            this.addressBookList.Location = new System.Drawing.Point(12, 12);
            this.addressBookList.Name = "addressBookList";
            this.addressBookList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.addressBookList.Size = new System.Drawing.Size(153, 381);
            this.addressBookList.TabIndex = 0;
            this.addressBookList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addressBookList_MouseDown);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(12, 425);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(82, 425);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(64, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sendLayout
            // 
            this.sendLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendLayout.ColumnCount = 2;
            this.sendLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.sendLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sendLayout.Controls.Add(this.toLabel, 0, 0);
            this.sendLayout.Controls.Add(this.subjectLabel, 0, 1);
            this.sendLayout.Controls.Add(this.messageLabel, 0, 2);
            this.sendLayout.Controls.Add(this.toList, 1, 0);
            this.sendLayout.Controls.Add(this.subjectInput, 1, 1);
            this.sendLayout.Controls.Add(this.messageInput, 1, 2);
            this.sendLayout.Location = new System.Drawing.Point(171, 12);
            this.sendLayout.Name = "sendLayout";
            this.sendLayout.RowCount = 3;
            this.sendLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.sendLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sendLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sendLayout.Size = new System.Drawing.Size(533, 407);
            this.sendLayout.TabIndex = 3;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toLabel.Location = new System.Drawing.Point(44, 6);
            this.toLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 84);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.subjectLabel.Location = new System.Drawing.Point(21, 96);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 20);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageLabel.Location = new System.Drawing.Point(14, 122);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 285);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message:";
            // 
            // toList
            // 
            this.toList.AllowDrop = true;
            this.toList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toList.FormattingEnabled = true;
            this.toList.Location = new System.Drawing.Point(73, 3);
            this.toList.Name = "toList";
            this.toList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toList.Size = new System.Drawing.Size(460, 84);
            this.toList.TabIndex = 3;
            this.toList.DragDrop += new System.Windows.Forms.DragEventHandler(this.toList_DragDrop);
            this.toList.DragEnter += new System.Windows.Forms.DragEventHandler(this.toList_DragEnter);
            // 
            // subjectInput
            // 
            this.subjectInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectInput.Location = new System.Drawing.Point(73, 93);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(460, 20);
            this.subjectInput.TabIndex = 4;
            // 
            // messageInput
            // 
            this.messageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageInput.Location = new System.Drawing.Point(73, 119);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(460, 285);
            this.messageInput.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(629, 425);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "&Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(325, 425);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(244, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addAddressButton
            // 
            this.addAddressButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAddressButton.Location = new System.Drawing.Point(152, 425);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(13, 23);
            this.addAddressButton.TabIndex = 7;
            this.addAddressButton.Text = "+";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // newContactInput
            // 
            this.newContactInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newContactInput.Location = new System.Drawing.Point(12, 399);
            this.newContactInput.Name = "newContactInput";
            this.newContactInput.Size = new System.Drawing.Size(153, 20);
            this.newContactInput.TabIndex = 8;
            // 
            // EmailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 459);
            this.Controls.Add(this.newContactInput);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendLayout);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressBookList);
            this.MinimumSize = new System.Drawing.Size(732, 497);
            this.Name = "EmailWindow";
            this.Text = "Email Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailWindow_FormClosing);
            this.Load += new System.EventHandler(this.EmailWindow_Load);
            this.sendLayout.ResumeLayout(false);
            this.sendLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox addressBookList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel sendLayout;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ListBox toList;
        private System.Windows.Forms.TextBox subjectInput;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.TextBox newContactInput;
    }
}

