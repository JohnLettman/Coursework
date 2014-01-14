using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Email_Client
{
    public partial class EmailWindow : Form
    {
        public EmailWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= addressBookList.SelectedItems.Count - 1; i++)
            {
                toList.Items.Add(addressBookList.SelectedItems[i].ToString());
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= toList.SelectedItems.Count - 1; i++)
            {
                toList.Items.Remove(toList.SelectedItems[i]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private bool listContains(ListBox lv, string str)
        {
            bool contains = false;

            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (str == lv.Items[i].ToString())
                {
                    contains = true;
                    break;
                }
            }

            return contains;
        }

        private void addressBookList_MouseDown(object sender, MouseEventArgs e)
        {
            if (addressBookList.SelectedItem != null)
            {
                addressBookList.DoDragDrop(addressBookList.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void toList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string dropData = e.Data.GetData(DataFormats.Text).ToString();

                if (!this.listContains(toList, dropData))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void toList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string dropData = e.Data.GetData(DataFormats.Text).ToString();

                if (!this.listContains(toList, dropData))
                {
                    toList.Items.Add(e.Data.GetData(DataFormats.Text));
                }
            }
        }

        private void EmailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader addressReader = new StreamReader("addressbook.txt");
                addressBookList.Items.Clear();

                string current_address = "";
                while (!addressReader.EndOfStream)
                {
                    current_address = addressReader.ReadLine();

                    if (current_address != null && current_address != "")
                    {
                        addressBookList.Items.Add(current_address);
                    }
                }

                addressReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addAddressButton_Click(object sender, EventArgs e)
        {
            string new_contact;

            try
            {
                new_contact = new MailAddress(newContactInput.Text).Address;
            }
            catch
            {
                return;
            }

            try
            {
                using (StreamWriter addressBookWriter = new StreamWriter("addressbook.txt", true))
                {
                    addressBookWriter.WriteLine(new_contact);
                    addressBookWriter.Close();
                }
            }
            catch { }

            EmailWindow_Load(this, null);

        }

        private void EmailWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            e.Cancel = (dr == System.Windows.Forms.DialogResult.No);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MailMessage myMail = new MailMessage();

            myMail.From = new MailAddress("pittcist@gmail.com", "pittcist0265");

            for (int i = 0; i <= toList.Items.Count - 1; i++)
            {
                myMail.To.Add(new MailAddress(toList.Items[i].ToString()));
            }

            myMail.Subject = subjectInput.Text;
            myMail.Body = messageInput.Text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("pittcist@gmail.com", "pittcist0265");

            //Net.NetworkCredential("pittcist@gmail.com", "pittcist0265")

            try
            {
                smtp.Send(myMail);
                MessageBox.Show("Message sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
