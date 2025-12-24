using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void OpenChildForm(Form childForm)
        {
            panelContent.Controls.Clear();   // ❗ panel hiển thị nội dung

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            childForm.Show();
        }
        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new album());
        }
        private void button2_Click_2(object sender, EventArgs e)
        {

            OpenChildForm(new artist());
        }
        private void button3_Click_3(object sender, EventArgs e)
        {

            OpenChildForm(new song());
        }
        private void button4_Click_4(object sender, EventArgs e)
        {

            OpenChildForm(new user());
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panelContent.Dock = DockStyle.Fill;

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint_1(object sender, PaintEventArgs e)
        {
            panelSidebar.Dock = DockStyle.Left;
        }
    }
}
