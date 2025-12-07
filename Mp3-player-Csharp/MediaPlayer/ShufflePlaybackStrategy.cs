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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class ShufflePlaybackStrategy : IPlaybackStrategy
    {
        private Random random = new Random();
        /// <summary>
        /// Metoda PlayTrackAt din modelul MusicPlayerModel este apelată pentru a face shuffle la melodii
        /// </summary>
        /// <param name="player"></param>
        public void Play(MusicPlayerModel player)
        {
            try
            {
                int nextTrackIndex = random.Next(player.Paths.Count);
                player.PlayTrackAt(nextTrackIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la redarea melodiei: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
