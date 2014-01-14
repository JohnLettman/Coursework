using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Databases
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactListDataSet.Friends' table. You can move, or remove it, as needed.
            this.friendsTableAdapter.Fill(this.contactListDataSet.Friends);

        }

        private void friendsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strphoto = this.contactListDataSet.Friends.Rows[friendsCombobox.SelectedIndex]["Photo"].ToString();
            this.photoTextbox.Text = strphoto;

            this.contactPhoto.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\images\" + strphoto);
        }
    }
}
