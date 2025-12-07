/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2024,                                                *
 *  Description: MediaPlayer Antet                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using NAudio.Wave;
using NAudio.Wave.SampleProviders;
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
using WMPLib;

namespace MediaPlayer
{
    /// <summary>
    /// Clasa pentru construirea MusicPlayer
    /// </summary>
    public partial class Music_Player : Form
    {
        private MusicPlayerModel model = new MusicPlayerModel();
        public Music_Player()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda pentru butonul Exit
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            model.Stop();
            Application.Exit();
        }

        /// <summary>
        /// Metoda pentru deschiderea unui folder
        /// </summary>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All Files|*.*",
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Title = "Select a folder containing music files",
                FileName = "Select folder"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = Path.GetDirectoryName(ofd.FileName);
                string[] filesInFolder = Directory.GetFiles(selectedFolderPath);

                foreach (string file in filesInFolder)
                {
                    string fileName = Path.GetFileName(file);
                    model.Paths.Add(file);
                    TrackList.Items.Add(fileName);
                }
            }
        }

        /// <summary>
        /// Metoda pentru oprirea muzicii
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            model.Stop();
            progressBar1.Value = 0;
            lbl_track_start.Text = "00:00";
        }

        /// <summary>
        ///Metoda pentru punerea in pausa a muzicii 
        /// </summary>
        private void PauseButton_Click(object sender, EventArgs e)
        {
            model.Pause();
        }

        /// <summary>
        /// Metoda apelanta pentru inceperea muzicii (butonul play)
        /// </summary>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            model.Play();
            lbl_track_end.Text = model.AudioFile.TotalTime.ToString(@"mm\:ss");
            timer1.Start();
        }

        /// <summary>
        /// Metoda pentru trecerea la melodia urmatoare
        /// </summary>
        private void NextButton_Click(object sender, EventArgs e)
        {
            model.NextTrack();
            model.Play();
            lbl_track_end.Text = model.AudioFile.TotalTime.ToString(@"mm\:ss");
        }

        /// <summary>
        /// Metoda pentru trecerea la melodia precedenta
        /// </summary>
        private void PreviewButton_Click(object sender, EventArgs e)
        {
            model.PrevTrack();
            model.Play();
            lbl_track_end.Text = model.AudioFile.TotalTime.ToString(@"mm\:ss");
        }

        /// <summary>
        /// Metoda care afiseaza help-ul
        /// </summary>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string chmFileName = "MediaPlayer.chm";
                string chmFilePath = Path.Combine(Application.StartupPath, chmFileName);
                System.Diagnostics.Process.Start(chmFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o eroare la deschiderea fisierului de help");
            }
        }

        /// <summary>
        /// Metoda care afiseaza o fereastra cu informatii despre aplicatie
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MP3 Player\n\nUn player MP3 ușor de utilizat.\n\n" +
                "\t\tAutori:\nCiobanu Ciprian\nBahrim Casian\nVieriu Gabriel\nNicodei Radu-George\n\n" +
                "Pentru mai multe informații, consultați help-ul.", "Despre MP3 Player");
        }

        /// <summary>
        /// Metoda care schimba volumul muzicii din aplicatie
        /// </summary>
        private void TrackVolume_ValueChanged(object sender, EventArgs e)
        {
            if (model.OutputDevice != null && model.AudioFile != null)
            {
                float volume = (float)TrackVolume.Value / 100.0f;
                model.AudioFile.Volume = volume;
            }
        }
        /// <summary>
        /// Metoda pentru a actualiza interfața utilizatorului în funcție de progresul redării unui fișier audio
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (model.AudioFile != null)
            {
                lbl_track_start.Text = model.AudioFile.CurrentTime.ToString(@"mm\:ss");
                progressBar1.Maximum = (int)model.AudioFile.TotalTime.TotalSeconds;
                progressBar1.Value = (int)model.AudioFile.CurrentTime.TotalSeconds;

                if ((int)model.AudioFile.TotalTime.TotalSeconds == (int)model.AudioFile.CurrentTime.TotalSeconds)
                {
                    NextButton_Click(sender, e);  // Trecerea la următoarea piesă
                }
            }
        }
        /// <summary>
        /// Metoda pentru a schimba poziția curentă a redării audio prin clic pe progressBar
        /// </summary>
        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (model.AudioFile != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                int mouseX = me.X;
                int duration = progressBar1.Maximum;
                int position = (int)((double)mouseX / progressBar1.Width * duration);

                model.AudioFile.CurrentTime = TimeSpan.FromSeconds(position);
                progressBar1.Value = position;
            }
        }
    }
}
