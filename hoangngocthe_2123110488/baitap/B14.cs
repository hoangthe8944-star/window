using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baitap
{
    public partial class B14 : Form
    {
        public B14()
        {
            InitializeComponent();
        }

        // Xử lý khi nhấn nút Tính tiền
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // Xác định giới tính
            if (rbMale.Checked == true)
                msg += "Ông ";

            if (rbFemale.Checked == true)
                msg += "Bà ";

            // Xử lý giảm giá
            if (ckDiscount.Checked == true)
            {
                // Lấy giá trị từ ô textbox tbDiscount thay vì gán cứng bằng 5 để giống hình ảnh UI
                if (!int.TryParse(tbDiscount.Text, out disc)) disc = 0;
            }
            else
            {
                disc = 0; // Nếu không check thì giảm 0%
            }

            // Xuất kết quả ra tbResult
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Xử lý khi trạng thái Checkbox thay đổi
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        // Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}