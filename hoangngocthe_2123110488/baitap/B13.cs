using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class B13 : Form
    {
        public B13()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi Form vừa mở lên
        private void Bai12_Load(object sender, EventArgs e)
        {
            // Tự động chọn mục thứ 3 (Index = 2 vì bắt đầu từ 0)
            if (cb_Faculty.Items.Count > 2)
            {
                cb_Faculty.SelectedIndex = 2;
            }
        }

        // Sự kiện xảy ra mỗi khi bạn thay đổi lựa chọn trong ComboBox
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        // Sự kiện khi nhấn nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedItem != null)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
            }
        }

        // Sự kiện nút Clear (Xóa nội dung hiển thị)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            cb_Faculty.SelectedIndex = -1; // Bỏ chọn ComboBox
        }
    }
}