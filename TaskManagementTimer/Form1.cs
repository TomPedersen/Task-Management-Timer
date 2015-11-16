using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TaskManagementTimer
{
    public partial class MainForm : Form
    {
        public int m;
        public int s;
        public int pomoCount;
        private bool _isReset;

        public bool isReset
        {
            get { return _isReset; }
            set
            {
                _isReset = value;
                stopTimer.Text = _isReset ? "Stop Your Timer" : "Reset Timer";
                timer1.Stop();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void begin_timer(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    Thread popUp = new Thread((new ThreadStart(ShowMessage)));
            //    Thread.Sleep(1 * (60 * 1000)); // 1 minute
            //    popUp.Start();
            //}

            if (setTimer.Text == "")
            {
                m = 25;
                s = 0;
            }
            else if (setTimer.Text != "")
            {
                m = Convert.ToInt32(setTimer.Text);
                s = 0;
            }

            timer1.Start(); //set to 100 speed during development process

        }

        void ShowMessage()
        {
            MessageBox.Show(string.Format("Time for a break!{0}{1}Take 5 minutes to review the past interval, record any unplanned activities and tick the appropriate checkboxes.{2}{3}Click the Start Timer button when you're ready to start working again!", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine));
        }

        void ShowMessageFourthBreak()
        {
            MessageBox.Show(string.Format("Time for a break!{0}{1}This is your fourth \"Pomodoro\" and so you should take a bit of a longer break. Take 10-15 minutes to review your day, set new tasks or just stretch your legs.{2}{3}Click the Start Timer button when you're ready to start working again!", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (s == 0)
            {
                s = 59;
                m--;
            }
            else
            {
                s--;
            }


            if (m == 0 && s == 0 && pomoCount == 3)
            {
                timer1.Stop();
                m = 1;
                ShowMessageFourthBreak();
                pomoCount = 0;
            }
            else if (m == 0 && s == 0)
            {
                timer1.Stop();
                m = 1;
                ShowMessage();
                pomoCount += 1;
            }

            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            Minutes.Text = mm;
            Seconds.Text = ss;
        }
        
        private void stopTimer_Click(object sender, EventArgs e)
        {
            isReset = !isReset;
        }
    }
}
