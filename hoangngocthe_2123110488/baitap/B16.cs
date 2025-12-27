using System;
using System.Windows.Forms;
namespace baitap
{
    public partial class B16 : Form
    {
        // Biến dùng để đếm số thứ tự sinh viên khi thêm mới
        private int studentCount = 0;

        public B16()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện nút "Thêm"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo");
                return;
            }

            studentCount++; // Tăng số thứ tự

            // Lấy giới tính
            string gender = rbMale.Checked ? "Nam" : "Nữ";

            // Định dạng chuỗi thông tin theo mẫu trong ảnh
            string info = $"{studentCount}.{txtName.Text}\r\n" +
                          $" -Giới tính: {gender}\r\n" +
                          $" -Ngày Sinh:{dtpBirthDate.Value.ToString("dd/MM/yyyy")}\r\n" +
                          $" -Khoa: {cboFaculty.Text}\r\n";

            // Thêm vào ô trạng thái (Multiline TextBox)
            txtStatus.AppendText(info);

            // Xóa tên sau khi thêm để nhập người tiếp theo (tùy chọn)
            // txtName.Clear();
        }

        // Xử lý sự kiện nút "Thoát"
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}