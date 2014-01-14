using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Web_Browser
{
    public partial class Browser : Form
    {
        public const string NAME = "Icewolf";

        public Browser()
        {
            InitializeComponent();
            this.browserWindow.ScriptErrorsSuppressed = true;
            this.Text = Browser.NAME;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                browserWindow.Navigate(this.urlBar.Text);

                string formalized_url = browserWindow.Url.ToString();
                if (this.notHistoricalDuplicateCheck(formalized_url))
                {
                    this.urlBar.Items.Add(formalized_url);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool notHistoricalDuplicateCheck(string url)
        {
            foreach(object item in this.urlBar.Items)
            {
                if((string) item == url)
                {
                    return false;
                }
            }

            return true;
        }

        private void browserWindow_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.Text = browserWindow.DocumentTitle + " - " + Browser.NAME;
            this.urlBar.Text = browserWindow.Url.ToString();
        }

        private void urlBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goButton_Click(sender, null);
            }
        }

        private void browserWindow_ProgressChanged(object sender, 
            WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                int progress = Convert.ToInt32((e.CurrentProgress / e.MaximumProgress) * 100);
                this.pageLoadProgress.Value = progress > 100 ? 100 : progress;
                this.pageLoadProgress.ToolTipText = "Progress - %" + this.pageLoadProgress.Value.ToString();
            }
        }

        private void urlBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.urlBar.SelectedText != this.browserWindow.Url.ToString())
            {
                this.goButton_Click(sender, null);
            }
        }
    }
}
