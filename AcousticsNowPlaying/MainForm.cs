using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using Windows7.DesktopIntegration;
using Windows7.DesktopIntegration.WindowsForms;
using Acoustics;

namespace AcousticsNowPlaying {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            Windows7Taskbar.AllowTaskbarWindowMessagesThroughUIPI();
            Windows7Taskbar.SetCurrentProcessAppId("AcousticsTaskbar");

            /* Reset the form labels */
            lblSongTitle.TextAlign = ContentAlignment.TopCenter;
            lblSongTitle.Text = "Nothing Playing";
            lblSongAlbum.Text = "";
            lblSongArtist.Text = "";
            coolProgressBar1.Visible = false;
            originalIcon = this.Icon;

            lblUserName.Visible = Properties.Settings.Default.showExtraInfo;
            lblRoomName.Visible = Properties.Settings.Default.showExtraInfo;

            if (Properties.Settings.Default.promptForPassword) {
                InputBox tmp = new InputBox();
                DialogResult _result = tmp.ShowDialog(this);
                if (_result == DialogResult.OK) {
                    _password = tmp.Password;
                }
            }

            /* Send the initial login request */
            Thread _worker = new Thread(new ThreadStart(doLogin));
            _worker.Name = "Login Thread";
            _worker.Start();
        }

        string _password = "";

        void doLogin() {
            client = new AcousticsClient(Properties.Settings.Default.serverBaseAddress);
            client.ForcePlayer = Properties.Settings.Default.roomName;
            client.login(Properties.Settings.Default.userName,_password);
            performUpdate();
        }

        private ThumbButtonManager _thumbButtonManager;
        private AcousticsClient client;
        private Icon originalIcon;
        private int asyncCount = 0;

        protected override void WndProc(ref Message m) {
            if (m.Msg == Windows7Taskbar.TaskbarButtonCreatedMessage) {
                _thumbButtonManager = this.CreateThumbButtonManager();

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
                Image albumart = client.getAlbumArt(status.currentSong);
                if (InvokeRequired) {
                    this.Invoke(new MethodInvoker(delegate {
                        this.BackgroundImage = albumart;
                        try {
                            this.Icon = Icon.FromHandle(((Bitmap)this.BackgroundImage).GetHicon());
                        } catch {

                        }
                        lblSongTitle.TextAlign = ContentAlignment.TopLeft;
                        lblSongTitle.Text = status.currentSong.title;
                        lblSongArtist.Text = status.currentSong.artist;
                        lblSongAlbum.Text = status.currentSong.album;
                        lblUserName.Text = status.user;
                        lblRoomName.Text = status.player;
                        this.Text = status.currentSong.title + " - " + status.currentSong.artist;
                        coolProgressBar1.Maximum = status.length;
                        coolProgressBar1.Value = status.time - status.start_time;
                        coolProgressBar1.Visible = true;
                    }));
                }
                
            } else {
                if (InvokeRequired) {
                    this.Invoke(new MethodInvoker(delegate {
                        this.Text = "Nothing Playing";
                        this.BackgroundImage = null;
                        this.Icon = originalIcon;
                        lblSongTitle.TextAlign = ContentAlignment.TopCenter;
                        lblSongTitle.Text = "Nothing Playing";
                        lblSongArtist.Text = "";
                        lblSongAlbum.Text = "";
                        lblUserName.Text = status.user;
                        lblRoomName.Text = status.player;
                        coolProgressBar1.Visible = false;
                    }));
                }
            }
        }

        private void doUpdate() {
            asyncCount++;
            Thread _worker = new Thread(new ThreadStart(performUpdate));
            _worker.Name = "Async Request #" + asyncCount.ToString();
            _worker.Start();
        }

        private void updateTick_Tick(object sender, EventArgs e) {
            doUpdate();
        }

        private void progressTicker_Tick(object sender, EventArgs e) {
            if (coolProgressBar1.Value < coolProgressBar1.Maximum) {
                if (coolProgressBar1.Visible) {
                    coolProgressBar1.Value += 1;
                    coolProgressBar1.Refresh();
                }
            } else {
                doUpdate();
            }
        }

        private AboutWindow _aboutWindow;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                _aboutWindow.Show();
            } catch {
                _aboutWindow = new AboutWindow();
                _aboutWindow.Show();
            }
        }

        private SettingsWindow _settingsWindow;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                _settingsWindow.Show();
            } catch {
                _settingsWindow = new SettingsWindow();
                _settingsWindow.Show();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            doUpdate();
        }

        

    }
}
