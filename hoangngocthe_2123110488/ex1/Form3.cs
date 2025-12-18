using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string TruongKhoa { get; set; }
        public string DienThoai { get; set; }
    }
    public partial class Form3 : Form
    {
        List<Khoa> dsKhoa = new List<Khoa>();

        public Form3()
        {
            InitializeComponent();
            SetupGrid();
            LoadData();
        }

        void SetupGrid()
        {
            dgvKhoa.AutoGenerateColumns = false;
            dgvKhoa.Columns.Clear();

            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Mã khoa",
                DataPropertyName = "MaKhoa",
                Width = 100
            });

            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên khoa",
                DataPropertyName = "TenKhoa",
                Width = 200
            });

            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Trưởng khoa",
                DataPropertyName = "TruongKhoa",
                Width = 150
            });

            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Điện thoại",
                DataPropertyName = "DienThoai",
                Width = 120
            });

            dgvKhoa.DataSource = dsKhoa;
        }

        void LoadData()
        {
            dsKhoa.Add(new Khoa()
            {
                MaKhoa = "CNTT",
                TenKhoa = "Công nghệ thông tin",
                TruongKhoa = "Nguyễn Văn A",
                DienThoai = "0901234567"
            });

            dgvKhoa.Refresh();
        }

        // THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            dsKhoa.Add(new Khoa()
            {
                MaKhoa = txtMaKhoa.Text,
                TenKhoa = txtTenKhoa.Text,
                TruongKhoa = txtTruongKhoa.Text,
                DienThoai = txtDienThoai.Text
            });

            dgvKhoa.Refresh();
            ClearText();
        }

        // SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            Khoa k = (Khoa)dgvKhoa.CurrentRow.DataBoundItem;
            k.TenKhoa = txtTenKhoa.Text;
            k.TruongKhoa = txtTruongKhoa.Text;
            k.DienThoai = txtDienThoai.Text;

            dgvKhoa.Refresh();
        }

        // XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            Khoa k = (Khoa)dgvKhoa.CurrentRow.DataBoundItem;
            dsKhoa.Remove(k);
            dgvKhoa.Refresh();
        }

        // CLICK DÒNG
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;

            Khoa k = (Khoa)dgvKhoa.CurrentRow.DataBoundItem;
            txtMaKhoa.Text = k.MaKhoa;
            txtTenKhoa.Text = k.TenKhoa;
            txtTruongKhoa.Text = k.TruongKhoa;
            txtDienThoai.Text = k.DienThoai;
        }

        // TÌM KIẾM
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = dsKhoa
                .Where(k => k.TenKhoa.ToLower().Contains(txtSearch.Text.ToLower()))
                .ToList();
        }

        void ClearText()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTruongKhoa.Clear();
            txtDienThoai.Clear();
        }
    }
}