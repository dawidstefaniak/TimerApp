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
        private System.Timers.Timer timer;
        //State W for work, state B for Break
        private char state = 'W';
        private DateTime _currentTime;
        private DateTime _workingTime;
        private DateTime _breakTime;
        private SoundPlayer soundPlayer;
        private FileInfo[] musicFiles;
        public TimerStartForm(DateTime workingTime, DateTime breakTime)
        {
            _workingTime = workingTime;
            _breakTime = breakTime;
            _currentTime = _workingTime;
            var musicDir = new DirectoryInfo("Music");
            musicFiles = musicDir.GetFiles(@"*.wav");
            InitializeComponent();
            lblTime.Text = _workingTime.ToString("mm:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            btnStart.Enabled = false;
            timer = new System.Timers.Timer(1000);
            //Updates the label every second
            timer.Elapsed += EverySecondRefresh;
            timer.Elapsed += LabelUpdate;
            timer.Enabled = true;
        }

        private void EverySecondRefresh(object source, ElapsedEventArgs e)
        {
            _currentTime = _currentTime.AddSeconds(-1);
            if (_currentTime.Minute == 0 && _currentTime.Second == 0)
            {
                StopTimer();
            }
        }

        private void StopTimer()
        {
            timer.Stop();
            try
            {
                soundPlayer = new SoundPlayer(musicFiles[new Random().Next(0,musicFiles.Length)].FullName);
            }
            catch
            {
                MessageBox.Show("No music files found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            soundPlayer.Play();

            if (state == 'W')
            {
                _currentTime = _breakTime;
                state = 'B';
                this.BackColor = Color.Cyan;
                MessageBox.Show("Your break is starting now.", "Time to break", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                _currentTime = _workingTime;
                state = 'W';
                this.BackColor = Color.HotPink;
                MessageBox.Show("The end of the break!!!","The end",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            //Update Label and start button using Invoke
            soundPlayer.Stop();
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("mm:ss"); btnStart.Enabled = true; });
        }

        private void LabelUpdate(object source, ElapsedEventArgs e)
        {
            try
            {
                this.BeginInvoke((System.Windows.Forms.MethodInvoker) delegate(){lblTime.Text = _currentTime.ToString("mm:ss");});
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
            btnResume.Enabled = false;
            btnPause.Enabled = true;
            timer.Start();
        }

        private void btnBreakReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _currentTime = _breakTime;
            this.BackColor = Color.Cyan;
            //Update time in form
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("mm:ss");btnStart.Enabled = true;});
        }

        private void TimerStartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWorkReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _currentTime = _workingTime;
            this.BackColor = Color.HotPink;
            //Update time in form
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { lblTime.Text = _currentTime.ToString("mm:ss"); btnStart.Enabled = true; });
        }
    }
}
