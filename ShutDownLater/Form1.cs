using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutDownLater
{
    public partial class FormMain : Form
    {
        DateTime mShutdownTime;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            mShutdownTime = DateTime.Now.AddHours(1);
            labelInfo.Visible = true;
            labelInfo.Text = "";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now < mShutdownTime)
            {
                TimeSpan ts = mShutdownTime - DateTime.Now;
                labelInfo.Text = "" + ts.Minutes + " minutes " + ts.Seconds + " seconds ";
            }

            else
            {
                Close();
                Process.Start("shutdown.exe", "-h");
            }
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
