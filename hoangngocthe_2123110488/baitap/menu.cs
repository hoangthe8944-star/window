using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace baitap
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            // Gọi hàm này để tự động gán sự kiện cho 30 nút
            RegisterButtonEvents();
        }

        private void RegisterButtonEvents()
        {
            // Duyệt qua tất cả các Control trên Form
            // Tìm những Control là Button và có tên bắt đầu bằng chữ "b" (b1, b2, b3...)
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("b"))
                {
                    // Gán tất cả các nút vào chung một hàm xử lý "SharedButton_Click"
                    btn.Click += SharedButton_Click;
                }
            }
        }

        private void SharedButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Lấy số từ tên button (ví dụ: b1 -> lấy số 1, b25 -> lấy số 25)
            string buttonNumber = clickedButton.Name.Substring(1);

            // Tạo tên Form tương ứng (ví dụ: Bai1, Bai25)
            // Lưu ý: "baitap" là namespace của bạn, nếu bạn đổi namespace hãy sửa ở đây
            string formName = "baitap.B" + buttonNumber;

            try
            {
                // Dùng Reflection để tìm Class Form theo tên chuỗi
                Type formType = Assembly.GetExecutingAssembly().GetType(formName);

                if (formType != null)
                {
                    // Khởi tạo Form và hiển thị
                    Form f = (Form)Activator.CreateInstance(formType);
                    f.Show();

                    // Nếu muốn ẩn menu khi mở bài tập, hãy dùng:
                    // this.Hide();
                    // f.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file: " + formName + ".cs. Hãy chắc chắn bạn đã tạo Form này!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở bài tập: " + ex.Message);
            }
        }
    }
}