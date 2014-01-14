using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Listbox_Demo
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate list A at run time using Add() method
            listA.Items.Add("Peach");
            listA.Items.Add("Pear");
            listA.Items.Add("Pineapple");


        }

        private void copyRightButton_Click(object sender, EventArgs e)
        {
            if (listA.SelectedItem != null)
            {
                listB.Items.Add(listA.SelectedItem.ToString());
            }
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            if (listA.SelectedItem != null)
            {
                listB.Items.Add(listA.SelectedItem.ToString());
                listA.Items.RemoveAt(listA.SelectedIndex);
            }
        }

        private void copyLeftButton_Click(object sender, EventArgs e)
        {
            if (listB.SelectedItem != null)
            {
                listA.Items.Add(listB.SelectedItem.ToString());
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            if (listB.SelectedItem != null)
            {
                listA.Items.Add(listB.SelectedItem.ToString());
                listB.Items.RemoveAt(listB.SelectedIndex);
            }
        }

        private void listA_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                listA.Items.Add(e.Data.GetData(DataFormats.Text));

                if(listB.SelectedIndex != -1)
                    listB.Items.RemoveAt(listB.SelectedIndex);
            }
        }

        private void listB_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                listB.Items.Add(e.Data.GetData(DataFormats.Text));

                if (listA.SelectedIndex != -1)
                    listA.Items.RemoveAt(listA.SelectedIndex);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listA.SelectedIndex = listB.SelectedIndex = -1;
            listB.Items.Clear();
        }

        private void listA_MouseDown(object sender, MouseEventArgs e)
        {
            if (listA.SelectedItem != null)
            {
                listA.DoDragDrop(listA.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void listB_MouseDown(object sender, MouseEventArgs e)
        {
            if (listB.SelectedItem != null)
            {
                listB.DoDragDrop(listB.SelectedItem, DragDropEffects.Copy);
            }
        }

        private void listA_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total number of fruits in List A: " + listA.Items.Count.ToString());
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string list_string = "";

            for (int i = 0; i < listA.Items.Count; i++)
            {
                list_string += listA.Items[i].ToString();

                if (i < listA.Items.Count - 1)
                {
                    list_string += ", ";
                }
            }

            MessageBox.Show(list_string);
        }




    }
}
