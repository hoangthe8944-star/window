using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap
{
    public partial class B23 : Form
    {
        int step = 10; // mỗi lần di chuyển 10px

        public B23()
        {
            InitializeComponent();
        }

        // Chọn ảnh từ thư viện
        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.jpg;*.png;*.bmp;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Di chuyển sang trái
        private void btLeft_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= step;

            if (pictureBox1.Left < 0)
                pictureBox1.Left = 0;
        }

        // Di chuyển sang phải
        private void btRight_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += step;

            if (pictureBox1.Right > this.ClientSize.Width)
                pictureBox1.Left = this.ClientSize.Width - pictureBox1.Width;
        }
    }
}
