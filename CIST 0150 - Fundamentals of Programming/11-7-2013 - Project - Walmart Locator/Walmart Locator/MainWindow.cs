using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Walmart_Locator
{
    public partial class MainWindow : Form
    {
        string[] store_names = new string[100];
        string[] store_addresses = new string[100];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("stores.txt"))
            {
                for (int i = 0; reader.Peek() != -1; i++)
                {
                    // First line -- store name
                    try
                    {
                        this.store_names[i] = reader.ReadLine();
                        this.storeSelectionComboBox.Items.Add(this.store_names[i]);
                    }
                    catch
                    {
                        // Not fatal, exit
                        break;
                    }

                    // Second line -- store address
                    try
                    {
                        this.store_addresses[i] = reader.ReadLine();
                    }
                    catch
                    {
                        MessageBox.Show("Could not load stores.txt correctly." +
                            "Please ensure that it is in the proper format!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                } // for(int i = 0; reader.Peek() != -1; i++)
            } // using (StreamReader reader = new StreamReader("stores.txt"))
        }

        private void storeSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.storeSelectionComboBox.SelectedIndex;

            if (index == -1)
            {
                this.locationLabel.Text = "";
            }
            else
            {
                this.locationLabel.Text = this.store_names[index] + " is located at\n" +
                    this.store_addresses[index] + ".";

                this.mapBrowser.Navigate("http://maps.google.com/?q=" + this.store_addresses[index], false);
            }
        }
    }
}
