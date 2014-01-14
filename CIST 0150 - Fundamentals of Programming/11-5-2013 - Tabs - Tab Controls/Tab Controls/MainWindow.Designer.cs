namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Tab_Controls
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.contactListTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.contactsCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactEmailOutput = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.special = new System.Windows.Forms.Timer(this.components);
            this.mainTabs.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            this.contactListTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.loginTabPage);
            this.mainTabs.Controls.Add(this.contactListTabPage);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(414, 337);
            this.mainTabs.TabIndex = 0;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginTabPage.Controls.Add(this.loginButton);
            this.loginTabPage.Controls.Add(this.passwordInput);
            this.loginTabPage.Controls.Add(this.label2);
            this.loginTabPage.Controls.Add(this.usernameInput);
            this.loginTabPage.Controls.Add(this.label1);
            this.loginTabPage.Location = new System.Drawing.Point(4, 22);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(406, 311);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            // 
            // contactListTabPage
            // 
            this.contactListTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contactListTabPage.Controls.Add(this.logoutButton);
            this.contactListTabPage.Controls.Add(this.contactEmailOutput);
            this.contactListTabPage.Controls.Add(this.label3);
            this.contactListTabPage.Controls.Add(this.contactsCombo);
            this.contactListTabPage.Location = new System.Drawing.Point(4, 22);
            this.contactListTabPage.Name = "contactListTabPage";
            this.contactListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactListTabPage.Size = new System.Drawing.Size(406, 311);
            this.contactListTabPage.TabIndex = 1;
            this.contactListTabPage.Text = "Contact List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(173, 75);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(132, 26);
            this.usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(173, 106);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '◌';
            this.passwordInput.Size = new System.Drawing.Size(132, 26);
            this.passwordInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(230, 138);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // contactsCombo
            // 
            this.contactsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsCombo.FormattingEnabled = true;
            this.contactsCombo.Location = new System.Drawing.Point(87, 20);
            this.contactsCombo.Name = "contactsCombo";
            this.contactsCombo.Size = new System.Drawing.Size(301, 26);
            this.contactsCombo.TabIndex = 0;
            this.contactsCombo.SelectedIndexChanged += new System.EventHandler(this.contactsCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact:";
            // 
            // contactEmailOutput
            // 
            this.contactEmailOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEmailOutput.Location = new System.Drawing.Point(20, 61);
            this.contactEmailOutput.Name = "contactEmailOutput";
            this.contactEmailOutput.Size = new System.Drawing.Size(368, 190);
            this.contactEmailOutput.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(323, 280);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // special
            // 
            this.special.Interval = 50;
            this.special.Tick += new System.EventHandler(this.special_Tick);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 337);
            this.Controls.Add(this.mainTabs);
            this.MaximumSize = new System.Drawing.Size(430, 375);
            this.MinimumSize = new System.Drawing.Size(430, 375);
            this.Name = "MainWindow";
            this.Text = "Tab Pages";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainTabs.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            this.contactListTabPage.ResumeLayout(false);
            this.contactListTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage contactListTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox contactsCombo;
        private System.Windows.Forms.Label contactEmailOutput;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Timer special;

    }
}

