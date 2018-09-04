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
            SetComboBoxes();
        }

        private void SetComboBoxes()
        {
            for (var x = 0; x<= 59; x++)
            {
                //Add hours up to 24
                if (x<=24)
                {
                    cboBreakHours.Items.Add(x);
                    cboWorkHours.Items.Add(x);
                }
                cboBreakMinutes.Items.Add(x);
                cboWorkMinutes.Items.Add(x);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //input validation
            if (FieldsAreValid())
            {
                var workTime = new DateTime(2018,1,1,Convert.ToInt32(cboWorkHours.Text), Convert.ToInt32(cboWorkMinutes.Text),0);
                var breakTime = new DateTime(2018, 1, 1, Convert.ToInt32(cboBreakHours.Text), Convert.ToInt32(cboBreakMinutes.Text), 0);
                var timer = new TimerStartForm(workTime, breakTime);
                this.Hide();
                //When next form is closed, this form appears again
                timer.FormClosed += (s, args) => this.Show();
                timer.Show();
            }
            else
                MessageBox.Show("The fields are not valid. Check them and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool FieldsAreValid()
        {
            try
            {
                var workMinutes = Convert.ToInt32(cboWorkMinutes.Text);
                var workHours = Convert.ToInt32(cboWorkHours.Text);
                var breakMinutes = Convert.ToInt32(cboBreakMinutes.Text);
                var breakHours = Convert.ToInt32(cboBreakHours.Text);
                if ((workHours == 0 && workMinutes == 0) || (breakHours == 0 && breakMinutes == 0))
                    return false;
                if (workMinutes > 59 || workMinutes < 0 || breakMinutes > 59 || breakMinutes < 0
                    || workHours < 0 || workHours > 23 || breakHours < 0 || breakHours > 23 )
                    return false;
                else return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
