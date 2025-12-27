using System;
using System.Windows.Forms;
namespace baitap
{
    public partial class Bai20 : Form
    {
        public Bai20()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi người dùng kết thúc việc thay đổi kích thước form
        private void Bai20_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }

        // Sự kiện xảy ra khi form bắt đầu được load lên
        private void Bai20_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }
    }
}