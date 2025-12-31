using baitap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baitap
{
    public partial class Bai5 : Form
    {
        // Danh sách lưu trữ nhân viên (Slide 147)
        List<Employee> lst = new List<Employee>();

        public Bai5()
        {
            InitializeComponent();
        }

        // Chọn ảnh cho nhân viên (Slide 139)
        //private void btFile_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Title = "Open Image";
        //    dlg.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        pbImage.ImageLocation = dlg.FileName;
        //        pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}

        // Thêm nhân viên mới (Slide 147)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;

            lst.Add(em); // Thêm vào list

            // Thêm trực tiếp vào DataGridView (Slide 142)
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
        }

        // Xóa nhân viên đang chọn (Slide 143)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                lst.RemoveAt(idx); // Xóa trong list
                dgvEmployee.Rows.RemoveAt(idx); // Xóa trên bảng
            }
        }

        // Khi click vào một dòng trên bảng, hiển thị ngược lại lên Textbox (Slide 143)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvEmployee.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                ckGender.Checked = (bool)dgvEmployee.Rows[idx].Cells[3].Value;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}