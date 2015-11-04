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
        public int m = 2;
        public int s;

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

            timer1.Start();
        }

        void ShowMessage()
        {
            MessageBox.Show("Hi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == 0 && s == 0)
            {
                timer1.Stop();
                ShowMessage();
            }

            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            Minutes.Text = mm;
            Seconds.Text = ss;
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
