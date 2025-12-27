using System;
using System.Collections;
using System.Windows.Forms;

namespace baitap
{
    public partial class B12 : Form
    {
        public B12()
        {
            InitializeComponent();
        }

        // Hàm giả lập lấy dữ liệu (Hình 2)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; // Hình gốc ghi K02, mình sửa thành K03 cho logic
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // Sự kiện khi Form khởi động (Hình 3)
        private void Bai9_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        // Sự kiện khi thay đổi lựa chọn trên ComboBox (Hình 3)
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Chỉ thực hiện khi DataSource đã được gán
            if (cb_Faculty.DataSource != null)
            {
                cb_Faculty.ValueMember = "Id";
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        // Sự kiện khi nhấn nút OK (Hình 3)
        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }

        // Sự kiện nút Clear (Tự thêm để hoàn thiện giao diện)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            if (cb_Faculty.Items.Count > 0)
                cb_Faculty.SelectedIndex = 0;
        }
    }
}