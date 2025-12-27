using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;


namespace baitap
{
    public partial class B19 : Form
    {
        // Danh sách lưu trữ nhân viên để làm nguồn cho GridView
        List<Employee> listEmp = new List<Employee>();

        public B19()
        {
            InitializeComponent();
        }

        // 1. Xử lý chọn ảnh (Article 19)
        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.ImageLocation = dlg.FileName; // Hiển thị ảnh lên PictureBox
            }
        }

        // 2. Nút Thêm nhân viên vào bảng
        private void btAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Id = txtID.Text;
            emp.Name = txtName.Text;
            emp.ImagePath = pbImage.ImageLocation;

            listEmp.Add(emp);

            // Cập nhật lại nguồn dữ liệu cho DataGridView
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = listEmp;

            // Đặt tên cột hiển thị cho đẹp
            dgvEmployee.Columns["Id"].HeaderText = "Mã nhân viên";
            dgvEmployee.Columns["Name"].HeaderText = "Tên nhân viên";
            dgvEmployee.Columns["ImagePath"].Visible = false; // Ẩn cột đường dẫn ảnh
        }

        // 3. Khi click vào một dòng trong bảng, hiển thị lại thông tin và ảnh (RowEnter)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                txtID.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                pbImage.ImageLocation = row.Cells["ImagePath"].Value.ToString();
            }
        }
    }
}