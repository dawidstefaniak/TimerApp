using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTimePickers();
        }

        private void SetTimePickers()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "mm:s";
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "mm:s";
            dateTimePicker2.Value = DateTime.Now.Date;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker1.Value.Minute == 0 && dateTimePicker1.Value.Second == 0) ||
                (dateTimePicker2.Value.Minute == 0 && dateTimePicker2.Value.Second == 0))
                MessageBox.Show("Timers cannot be set at 0:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                var timer = new TimerStartForm(dateTimePicker1.Value, dateTimePicker2.Value);
                timer.Show();
            }
        }
    }
}
