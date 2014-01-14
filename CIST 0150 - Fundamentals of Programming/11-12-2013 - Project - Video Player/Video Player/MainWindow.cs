using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyVideo;
using System.IO; // Imported from classroom video DLL

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Video_Player
{
    public partial class MainWindow : Form
    {
        private Media player = new Media();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file_open = new OpenFileDialog())
            {
                file_open.Filter = "Video Files | *.wmv; *.avi; *.mpg; *.mpeg; *.mp3";
                file_open.InitialDirectory = Directory.GetCurrentDirectory();
                file_open.ShowDialog();

                if (file_open.FileName != "")
                {
                    this.player.Open(file_open.FileName, this.movieBox);
                    this.movieProgress.Maximum = this.movieProgressTrackbar.Maximum = player.Duration();
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.player.Play();
            this.timer.Start();

            // Set volume to medium level
            this.volumeTrackbar.Value = 50;
            this.player.Volume = 500;
        }

        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            this.player.FullScreen();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.player.Pause = !this.player.Pause;
            this.timer.Enabled = !this.player.Pause;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.player.Stop();
            this.timer.Stop();
        }

        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {
            this.player.Volume = this.volumeTrackbar.Value * 10;
        }

        private void movieProgressTrackbar_Scroll(object sender, EventArgs e)
        {
            this.player.Position = this.movieProgressTrackbar.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.movieProgress.Value = this.movieProgressTrackbar.Value = player.Position;
            this.movieProgress.Update();
            this.movieProgressTrackbar.Update();
        }
    }
}
