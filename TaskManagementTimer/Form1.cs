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

namespace TaskManagementTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void begin_timer(object sender, EventArgs e)
        {
            while (true)
            {
                Thread popUp = new Thread((new ThreadStart(ShowMessage)));
                Thread.Sleep(60 * 1000); //1 minute
                popUp.Start();
            }
        }

        void ShowMessage()
        {
            MessageBox.Show("Hi");
        }
    }
}
