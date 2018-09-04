using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class TimerStartForm : Form
    {
        private System.Timers.Timer timer = new System.Timers.Timer(1000);
        //State W for work, state B for Break
        private char state = 'W';
        private DateTime _currentTime;
        private DateTime _workingTime;
        private DateTime _breakTime;
        private SoundPlayer soundPlayer;
        private FileInfo[] musicFiles;
        private bool ballonTipWasShown = false;

        public TimerStartForm(DateTime workingTime, DateTime breakTime)
        {
            InitializeComponent();

            _workingTime = workingTime;
            _breakTime = breakTime;
            _currentTime = _workingTime;
            var musicDir = new DirectoryInfo("Music");
            musicFiles = musicDir.GetFiles();
            lblTime.Text = _workingTime.ToString("HH:mm:ss");
            timer.Elapsed += timer_tick;
            timer.Elapsed += LabelUpdate;
        }

        private void StartTimer()
        {
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () {
                btnResume.Enabled = false;
                btnPause.Enabled = true;

                //Updates the label every second
                timer.Enabled = true;
            });
        }

        private void timer_tick(object source, ElapsedEventArgs e)
        {
            _currentTime = _currentTime.AddSeconds(-1);
            if (_currentTime.Minute == 0 && _currentTime.Second == 0 && _currentTime.Hour == 0)
            {
                StopTimer();
            }
        }

        private void StopTimer()
        {
            DialogResult dialogResult = new DialogResult();
            timer.Stop();
            PlayMusic();

            if (state == 'W')
            {
                _currentTime = _breakTime;
                state = 'B';
                lblTime.BackColor = Color.Cyan;
                dialogResult = MessageBox.Show("Your break is starting now. Do you want to start the timer?", "Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }

            else if (state == 'B')
            {
                _currentTime = _workingTime;
                state = 'W';
                lblTime.BackColor = Color.HotPink;
                dialogResult = MessageBox.Show("Time to work. Do you want to start the timer?", "Timer",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
            }

            //After clicking on messagebox, stop the music
            soundPlayer.Stop();

            //Update Label and start button using Invoke
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("HH:mm:ss"); btnResume.Enabled = true; });

            if (dialogResult == DialogResult.Yes)
            {
                StartTimer();
            }
        }

        private void PlayMusic()
        {
            try
            {
                if (state == 'W')
                    soundPlayer = new SoundPlayer(musicFiles.FirstOrDefault(x => x.Name == "bicycle.wav").FullName);
                else
                    soundPlayer = new SoundPlayer(musicFiles.FirstOrDefault(x => x.Name == "airhorn.wav").FullName);
                soundPlayer.PlayLooping();
            }
            catch
            {
                MessageBox.Show("No music files found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelUpdate(object source, ElapsedEventArgs e)
        {
            try
            {
                this.BeginInvoke((System.Windows.Forms.MethodInvoker) delegate(){lblTime.Text = _currentTime.ToString("HH:mm:ss"); notifyIcon1.Text = $"Time left: {_currentTime.ToString("HH:mm:ss")}"; });
            }
            catch
            {
                // ignored
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnResume.Enabled = true;
            btnPause.Enabled = false;
            timer.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnBreakReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _currentTime = _breakTime;
            state = 'B';
            lblTime.BackColor = Color.Cyan;

            //Update time in form
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("HH:mm:ss");btnResume.Enabled = true; btnPause.Enabled = false; });
        }

        private void btnWorkReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _currentTime = _workingTime;
            state = 'W';
            lblTime.BackColor = Color.HotPink;

            //Update time in form
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("HH:mm:ss"); btnResume.Enabled = true; btnPause.Enabled = false; });
        }

        //Hide app to taskbar when the window is being minimized
        private void TimerStartForm_Resize(object sender, EventArgs e)
        {
            MinimizeTheApp();
        }

        private void MinimizeTheApp()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                if (!ballonTipWasShown)
                {
                    ballonTipWasShown = true;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = @"The timer is now hidden in the system tray.";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }
        }

        //TODO Baloon tip
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeTheApp(this, new EventArgs());
        }

        private void MaximizeTheApp(object sender, EventArgs e)
        {
            Maximize();
        }

        private void Maximize()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
