﻿namespace AcousticsNowPlaying
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.playerIcons = new System.Windows.Forms.ImageList(this.components);
            this.progressTicker = new System.Windows.Forms.Timer(this.components);
            this.coolProgressBar1 = new CoolProgressBar();
            this.lblSongAlbum = new TransparentLabel();
            this.lblSongArtist = new TransparentLabel();
            this.lblSongTitle = new TransparentLabel();
            this.SuspendLayout();
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 15000;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // playerIcons
            // 
            this.playerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playerIcons.ImageStream")));
            this.playerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.playerIcons.Images.SetKeyName(0, "play.png");
            this.playerIcons.Images.SetKeyName(1, "skip.png");
            this.playerIcons.Images.SetKeyName(2, "stop.png");
            this.playerIcons.Images.SetKeyName(3, "volume-down.png");
            this.playerIcons.Images.SetKeyName(4, "volume-up.png");
            // 
            // progressTicker
            // 
            this.progressTicker.Enabled = true;
            this.progressTicker.Interval = 1000;
            this.progressTicker.Tick += new System.EventHandler(this.progressTicker_Tick);
            // 
            // coolProgressBar1
            // 
            this.coolProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.coolProgressBar1.Location = new System.Drawing.Point(12, 475);
            this.coolProgressBar1.Name = "coolProgressBar1";
            this.coolProgressBar1.Size = new System.Drawing.Size(476, 16);
            this.coolProgressBar1.TabIndex = 4;
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSongAlbum.AutoSize = true;
            this.lblSongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongAlbum.ForeColor = System.Drawing.Color.White;
            this.lblSongAlbum.Location = new System.Drawing.Point(12, 446);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(72, 25);
            this.lblSongAlbum.TabIndex = 3;
            this.lblSongAlbum.Text = "Album";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(12, 421);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(61, 25);
            this.lblSongArtist.TabIndex = 2;
            this.lblSongArtist.Text = "Artist";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(12, 390);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(146, 31);
            this.lblSongTitle.TabIndex = 1;
            this.lblSongTitle.Text = "Song Title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.coolProgressBar1);
            this.Controls.Add(this.lblSongAlbum);
            this.Controls.Add(this.lblSongArtist);
            this.Controls.Add(this.lblSongTitle);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Acoustics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        private TransparentLabel lblSongTitle;
        private TransparentLabel lblSongArtist;
        private TransparentLabel lblSongAlbum;
        private System.Windows.Forms.ImageList playerIcons;
        private CoolProgressBar coolProgressBar1;
        private System.Windows.Forms.Timer progressTicker;

    }
}
