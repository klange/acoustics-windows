using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Windows7.DesktopIntegration;
using Windows7.DesktopIntegration.WindowsForms;
using Acoustics;

namespace AcousticsNowPlaying {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            Windows7Taskbar.AllowTaskbarWindowMessagesThroughUIPI();
            Windows7Taskbar.SetCurrentProcessAppId("AcousticsTaskbar");
            client = new AcousticsClient("http://192.168.1.182/amp/");
            client.login("derp", "herp");
            performUpdate();
        }

        private ThumbButtonManager _thumbButtonManager;
        private AcousticsClient client;


        protected override void WndProc(ref Message m) {
            if (m.Msg == Windows7Taskbar.TaskbarButtonCreatedMessage) {
                _thumbButtonManager = this.CreateThumbButtonManager();

                /*
                Bitmap icon = new Bitmap("stop.png");
                IntPtr icon_ref = icon.GetHicon();
                Icon icon_ico = System.Drawing.Icon.FromHandle(icon_ref);
                 */

                ThumbButton stopButton = _thumbButtonManager.CreateThumbButton(101, Icon.FromHandle(((Bitmap)playerIcons.Images["stop.png"]).GetHicon()), "Stop");
                stopButton.Clicked += delegate {
                    client.stop();
                };
                ThumbButton playButton = _thumbButtonManager.CreateThumbButton(102, Icon.FromHandle(((Bitmap)playerIcons.Images["play.png"]).GetHicon()), "Play/Pause");
                playButton.Clicked += delegate {
                    client.playPause();
                };
                ThumbButton skipButton = _thumbButtonManager.CreateThumbButton(103, Icon.FromHandle(((Bitmap)playerIcons.Images["skip.png"]).GetHicon()), "Skip");
                skipButton.Clicked += delegate {
                    client.skip();
                    coolProgressBar1.Value = coolProgressBar1.Maximum;
                };
                ThumbButton volDownButton = _thumbButtonManager.CreateThumbButton(104, Icon.FromHandle(((Bitmap)playerIcons.Images["volume-down.png"]).GetHicon()), "Volume Down");
                volDownButton.Clicked += delegate {
                    client.volume(-1);
                };
                ThumbButton volUpButton = _thumbButtonManager.CreateThumbButton(105, Icon.FromHandle(((Bitmap)playerIcons.Images["volume-up.png"]).GetHicon()), "Volume Up");
                volUpButton.Clicked += delegate {
                    client.volume(1);
                };
                _thumbButtonManager.AddThumbButtons(stopButton, playButton, skipButton, volDownButton, volUpButton);
            }

            if (_thumbButtonManager != null)
                _thumbButtonManager.DispatchMessage(ref m);

            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void performUpdate() {
            AcousticsStatus status = client.getStatus();
            if (status.currentSong != null) {
                this.BackgroundImage = client.getAlbumArt(status.currentSong);
                this.Icon = Icon.FromHandle(((Bitmap)this.BackgroundImage).GetHicon());
                lblSongTitle.Text = status.currentSong.title;
                lblSongArtist.Text = status.currentSong.artist;
                lblSongAlbum.Text = status.currentSong.album;
                this.Text = status.currentSong.title + " - " + status.currentSong.artist;
                coolProgressBar1.Maximum = status.length;
                coolProgressBar1.Value = status.time - status.start_time;
                coolProgressBar1.Visible = true;
            } else {
                this.Text = "Nothing Playing";
                lblSongTitle.Text = "Nothing Playing";
                lblSongArtist.Text = "";
                lblSongAlbum.Text = "";
                coolProgressBar1.Visible = false;
            }
        }

        private void updateTick_Tick(object sender, EventArgs e) {
            performUpdate();
        }

        private void progressTicker_Tick(object sender, EventArgs e) {
            if (coolProgressBar1.Value < coolProgressBar1.Maximum) {
                coolProgressBar1.Value += 1;
                coolProgressBar1.Refresh();
            } else {
                performUpdate();
            }
        }

    }
}
