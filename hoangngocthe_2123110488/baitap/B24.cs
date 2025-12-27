using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace baitap
{
    public partial class B24 : Form
    {
        // Biến lưu trữ số giây đã trôi qua (theo đúng slide)
        int second = 0;

        public B24()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000; 
            tmStopwatch.Start();         
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();          
        }


        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;


            lblDisplay.Text = second.ToString();


        }
    }
}