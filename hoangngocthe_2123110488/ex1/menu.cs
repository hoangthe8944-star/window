using System;
using System.Windows.Forms;

namespace ex1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        // Button 1 → mở Form1
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        // Button 2 → mở Form2
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            simplecal f3 = new simplecal();
            f3.Show();
        }


    }
}
