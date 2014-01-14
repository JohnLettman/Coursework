using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Tab_Controls
{
    public partial class MainWindow : Form
    {
        string[] name = new string[100];
        string[] address = new string[100];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.usernameInput.Select();
            this.mainTabs.TabPages.RemoveAt(1);

            this.AcceptButton = this.loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.usernameInput.Text == "username" &&
                this.passwordInput.Text == "password")
            {
                // Authentication successful

                // Clear up login page
                this.passwordInput.Text = this.usernameInput.Text = "";
                this.AcceptButton = null;

                // Load addresses
                using (StreamReader reader = new StreamReader("addresses.txt"))
                {
                    for(int i = 0; reader.Peek() != -1; i++)
                    {
                        // First line -- name
                        try
                        {
                            this.name[i] = reader.ReadLine();
                            this.contactsCombo.Items.Add(this.name[i]);
                        }
                        catch
                        {
                            // Not fatal, exit
                            break;
                        }

                        // Second line -- address
                        try
                        {
                            this.address[i] = reader.ReadLine();
                        }
                        catch
                        {
                            MessageBox.Show("Could not load addresses.txt correctly." +
                                "Please ensure that it is in the proper format!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
                    } // for(int i = 0; reader.Peek() != -1; i++)
                } // using (StreamReader reader = new StreamReader("addresses.txt"))

                // Switch to contacts page
                this.mainTabs.TabPages.RemoveAt(0);
                this.mainTabs.TabPages.Insert(0, this.contactListTabPage);

            } // if (this.usernameInput.Text == "username" ...
            else
            {
                // Authentication failed
                MessageBox.Show("The specified username and password combination does not exist.", 
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contactsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.contactsCombo.SelectedIndex == -1)
            {
                this.contactEmailOutput.Text = "";
            }
            else
            {
                int index = this.contactsCombo.SelectedIndex;
                this.contactEmailOutput.Text = this.name[index] + "'s email address is " +
                    this.address[index] + ".";
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Unload addresses and names (for security)
            this.name = new string[100];
            this.address = new string[100];
            this.contactsCombo.Items.Clear();

            // Allow the login button to be the acceptor
            this.AcceptButton = this.loginButton;

            // Switch to login tab
            this.mainTabs.TabPages.RemoveAt(0);
            this.mainTabs.TabPages.Insert(0, this.loginTabPage);
        }

        private void special_Tick(object sender, EventArgs e)
        {
            bool direction = false;
            int x = 0;
            

        }
    }
}
