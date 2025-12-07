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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class MusicPlayerModel
    {
        private IPlaybackStrategy playbackStrategy;
        public WaveOutEvent OutputDevice { get; private set; } = new WaveOutEvent();
        public AudioFileReader AudioFile { get; private set; }
        public List<string> Paths { get; private set; } = new List<string>();
        public int SelectedIndex { get; set; }

        public MusicPlayerModel() 
        { 
            playbackStrategy = new NormalPlaybackStrategy();
        }
        /// <summary>
        /// Metodă pentru setarea strategiei de redare
        /// </summary>
        /// <param name="strategy"></param>
        public void SetPlaybackStrategy(IPlaybackStrategy strategy)
        {
            playbackStrategy = strategy;
        }
        /// <summary>
        /// Metodă pentru redarea melodiilor
        /// </summary>
        public void Play()
        {
            if (OutputDevice.PlaybackState == PlaybackState.Paused)
                OutputDevice.Play();
            else
                playbackStrategy.Play(this);
        }
        /// <summary>
        /// Metodă pentru redarea unei melodii selectate
        /// </summary>
        public void PlaySelectedTrack()
        {
            try
            {
                if(OutputDevice == null)
                {
                    OutputDevice = new WaveOutEvent();
                }
                if(OutputDevice.PlaybackState == PlaybackState.Playing)
                {
                    OutputDevice.Stop();
                }
                if(AudioFile != null)
                {
                    AudioFile.Dispose();
                }
                if (SelectedIndex < 0 || SelectedIndex >= Paths.Count)
                {
                    throw new InvalidOperationException("Nicio melodie selectată.");
                }
                AudioFile = new AudioFileReader(Paths[SelectedIndex]);
                AudioFile.Position = 0;
                OutputDevice.Init(AudioFile);
                OutputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la redarea melodiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodă pentru redarea unei melodii la un anumit index
        /// </summary>
        /// <param name="index"></param>
        public void PlayTrackAt(int index)
        {
            try
            {
                if (index < 0 || index >= Paths.Count)
                {
                    throw new InvalidOperationException("Indice de melodie invalid.");
                }

                SelectedIndex = index;
                PlaySelectedTrack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la redarea melodiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodă pentru pauzarea redării melodiei
        /// </summary>
        public void Pause()
        {
            try
            {
                if (OutputDevice != null)
                {
                    if(OutputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        OutputDevice.Pause();
                    }
                    else if (OutputDevice.PlaybackState == PlaybackState.Paused)
                    {
                        OutputDevice.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la pauzarea melodiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodă pentru oprirea redării melodiei
        /// </summary>
        public void Stop()
        {
            try
            {
                if (OutputDevice != null)
                {
                    OutputDevice.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la oprirea melodiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodă pentru trecerea la următoarea melodie
        /// </summary>
        public void NextTrack()
        {
            try
            {
                if (SelectedIndex < Paths.Count - 1)
                {
                    SelectedIndex++;
                }
                else
                {
                    SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la urmatoarea melodie: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Metodă pentru trecerea la melodia precedentă
        /// </summary>
        public void PrevTrack()
        {
            try
            {
                if (SelectedIndex > 0)
                {
                    SelectedIndex--;
                }
                else
                {
                    SelectedIndex = Paths.Count - 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Eroare la melodia precedenta: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
