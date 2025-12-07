namespace MediaPlayer
{
    partial class Music_Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Player));
            this.PreviewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StopButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PlayButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PauseButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.OpenFileButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TrackList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.PictureArt = new System.Windows.Forms.PictureBox();
            this.TrackVolume = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Volume = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.ExitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(17, 546);
            this.PreviewButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(145, 33);
            this.PreviewButton.TabIndex = 0;
            this.PreviewButton.Values.Text = "Prev";
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(171, 546);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(145, 33);
            this.NextButton.TabIndex = 1;
            this.NextButton.Values.Text = "Next";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(631, 546);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(168, 33);
            this.StopButton.TabIndex = 2;
            this.StopButton.Values.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(324, 546);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(145, 33);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Values.Text = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(477, 546);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(145, 33);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Values.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(807, 546);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(297, 33);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Values.Text = "Open";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // TrackList
            // 
            this.TrackList.Location = new System.Drawing.Point(359, 212);
            this.TrackList.Margin = new System.Windows.Forms.Padding(4);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(829, 277);
            this.TrackList.TabIndex = 7;
            // 
            // PictureArt
            // 
            this.PictureArt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PictureArt.Image = ((System.Drawing.Image)(resources.GetObject("PictureArt.Image")));
            this.PictureArt.Location = new System.Drawing.Point(17, 212);
            this.PictureArt.Margin = new System.Windows.Forms.Padding(4);
            this.PictureArt.Name = "PictureArt";
            this.PictureArt.Size = new System.Drawing.Size(225, 225);
            this.PictureArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureArt.TabIndex = 8;
            this.PictureArt.TabStop = false;
            // 
            // TrackVolume
            // 
            this.TrackVolume.DrawBackground = true;
            this.TrackVolume.Location = new System.Drawing.Point(1207, 231);
            this.TrackVolume.Margin = new System.Windows.Forms.Padding(4);
            this.TrackVolume.Maximum = 100;
            this.TrackVolume.Name = "TrackVolume";
            this.TrackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackVolume.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.TrackVolume.Size = new System.Drawing.Size(27, 238);
            this.TrackVolume.TabIndex = 10;
            this.TrackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackVolume.Value = 100;
            this.TrackVolume.ValueChanged += new System.EventHandler(this.TrackVolume_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutAppToolStripMenuItem
            // 
            this.aboutAppToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.aboutAppToolStripMenuItem.Text = "About app";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Volume.Location = new System.Drawing.Point(1197, 473);
            this.Volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(61, 17);
            this.Volume.TabIndex = 13;
            this.Volume.Text = "Volume";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelVolume.Location = new System.Drawing.Point(1203, 212);
            this.LabelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(48, 17);
            this.LabelVolume.TabIndex = 14;
            this.LabelVolume.Text = "100%";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1113, 546);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(148, 31);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Values.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.Location = new System.Drawing.Point(36, 92);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(126, 44);
            this.lbl_track_start.TabIndex = 22;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.Location = new System.Drawing.Point(1111, 92);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(126, 44);
            this.lbl_track_end.TabIndex = 23;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 514);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1244, 16);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Music_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1277, 594);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.TrackVolume);
            this.Controls.Add(this.PictureArt);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Music_Player";
            this.Text = "Music Player Project ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton PreviewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton StopButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PlayButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PauseButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OpenFileButton;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox TrackList;
        private System.Windows.Forms.PictureBox PictureArt;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar TrackVolume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label LabelVolume;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ExitButton;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

