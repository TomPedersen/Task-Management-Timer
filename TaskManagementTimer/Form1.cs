using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using Timer = System.Timers.Timer; // You can remove the unused usings

namespace TaskManagementTimer
{
    public partial class MainForm : Form
    {
        // Renamed these to my typical 'Russian novel length' variable naming style
        private int _minutesRemainingUntilBreak = 1; //Will set to 25 mins for release
        private int _secondsRemainingUntilBreak;
        private int _numberOfPomodorosSinceLastLongBreak;


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
            //} // You can remove this commented-out code

            timer1.Start(); //set to 100 speed during development process
        }

        private void ShowMessage()
        {
            MessageBox.Show(string.Format("Time for a break!{0}{1} Take 5 minutes to review the past 25 minutes and record any unplanned activities and tick the appropriate checkboxes.{2}{3} Click the Start Timer button when you're ready to start working again!", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine));
        }

        private void ShowMessageFourthBreak()
        {
            MessageBox.Show(string.Format("Time for a break!{0}{1} This is your fourth \"Pomodoro\" and so you should take a bit of a longer break. Take 10-15 minutes to review your day, set new tasks or just stretch your legs.{2}{3} Click the Start Timer button when you're ready to start working again!", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (_secondsRemainingUntilBreak == 0)
            {
                _secondsRemainingUntilBreak = 59;
                _minutesRemainingUntilBreak--;
            }
            else
            {
                _secondsRemainingUntilBreak--;
            }

            // This logic can be written differently, like this. Slighly less duplication.
            if (_minutesRemainingUntilBreak == 0 && _secondsRemainingUntilBreak == 0)
            {
                timer1.Stop();
                _minutesRemainingUntilBreak = 1;
                if (_numberOfPomodorosSinceLastLongBreak == 3)
                {
                    ShowMessageFourthBreak(); 
                    _numberOfPomodorosSinceLastLongBreak = 0;
                }
                else
                {
                    ShowMessage();
                    _numberOfPomodorosSinceLastLongBreak += 1;
                }
            }

            // I think this will do what you want - slightly less code
            Minutes.Text = _minutesRemainingUntilBreak.ToString();
            Seconds.Text = _secondsRemainingUntilBreak.ToString();
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
