using MediaPlayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAudio.Wave;
using System;

namespace TestareAplicatie
{
    [TestClass]
    public class MusicPlayerTests
    {
        [TestMethod]
        public void TestPlay()
        {
            var player = new MusicPlayerModel();

            player.Play();

            Assert.AreEqual(PlaybackState.Playing, player.OutputDevice.PlaybackState);
        }
        [TestMethod]
        public void TestStop()
        {
            var player = new MusicPlayerModel();

            player.Stop();

            Assert.AreEqual(PlaybackState.Stopped, player.OutputDevice.PlaybackState);
            Assert.AreEqual(TimeSpan.Zero, player.AudioFile.Position);
        }
        [TestMethod]
        public void TestPause()
        {
            var player = new MusicPlayerModel();

            player.Pause();

            Assert.AreEqual(PlaybackState.Paused, player.OutputDevice.PlaybackState);
        }
        [TestMethod]
        public void TestAddTrack()
        {
            var player = new MusicPlayerModel();
            var trackCount = player.Paths.Count;

            player.Paths.Add("test.mp3");

            Assert.AreEqual(trackCount + 1, player.Paths.Count);
        }
        [TestMethod]
        public void TestPlaySelectedTrack()
        {
            var player = new MusicPlayerModel();
            player.Paths.Add("test.mp3");

            player.PlaySelectedTrack();

            Assert.AreEqual(PlaybackState.Playing, player.OutputDevice.PlaybackState);
        }
        [TestMethod]
        public void TestNextTrack()
        {
            var player = new MusicPlayerModel();
            player.Paths.Add("test1.mp3");
            player.Paths.Add("test2.mp3");
            player.PlaySelectedTrack();

            player.NextTrack();

            Assert.AreEqual("test2.mp3", player.Paths[player.SelectedIndex]);
        }
    }
}
