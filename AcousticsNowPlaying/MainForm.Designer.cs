namespace AcousticsNowPlaying
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRoomName = new TransparentLabel();
            this.lblUserName = new TransparentLabel();
            this.lblSongAlbum = new TransparentLabel();
            this.lblSongArtist = new TransparentLabel();
            this.lblSongTitle = new TransparentLabel();
            this.coolProgressBar1 = new CoolProgressBar();
            this.contextMenuStrip.SuspendLayout();
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
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 76);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // lblRoomName
            // 
            this.lblRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomName.EllipseOnOverflow = false;
            this.lblRoomName.Location = new System.Drawing.Point(383, 9);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(100, 15);
            this.lblRoomName.TabIndex = 6;
            this.lblRoomName.Text = "room";
            this.lblRoomName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRoomName.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.EllipseOnOverflow = false;
            this.lblUserName.Location = new System.Drawing.Point(383, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongAlbum.EllipseOnOverflow = true;
            this.lblSongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongAlbum.ForeColor = System.Drawing.Color.White;
            this.lblSongAlbum.Location = new System.Drawing.Point(12, 446);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(471, 25);
            this.lblSongAlbum.TabIndex = 3;
            this.lblSongAlbum.Text = "Album";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongArtist.EllipseOnOverflow = true;
            this.lblSongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.ForeColor = System.Drawing.Color.White;
            this.lblSongArtist.Location = new System.Drawing.Point(12, 421);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(471, 25);
            this.lblSongArtist.TabIndex = 2;
            this.lblSongArtist.Text = "Artist";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSongTitle.EllipseOnOverflow = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(12, 390);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(471, 31);
            this.lblSongTitle.TabIndex = 1;
            this.lblSongTitle.Text = "Song Title";
            // 
            // coolProgressBar1
            // 
            this.coolProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.coolProgressBar1.DisplayMode = CoolProgressDisplayMode.Time;
            this.coolProgressBar1.Location = new System.Drawing.Point(12, 475);
            this.coolProgressBar1.Maximum = 100;
            this.coolProgressBar1.Minimum = 0;
            this.coolProgressBar1.Name = "coolProgressBar1";
            this.coolProgressBar1.Size = new System.Drawing.Size(471, 22);
            this.coolProgressBar1.TabIndex = 4;
            this.coolProgressBar1.Value = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblSongAlbum);
            this.Controls.Add(this.lblSongArtist);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.coolProgressBar1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Acoustics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        private TransparentLabel lblSongTitle;
        private TransparentLabel lblSongArtist;
        private TransparentLabel lblSongAlbum;
        private System.Windows.Forms.ImageList playerIcons;
        private CoolProgressBar coolProgressBar1;
        private System.Windows.Forms.Timer progressTicker;
        private TransparentLabel lblUserName;
        private TransparentLabel lblRoomName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

    }
}

