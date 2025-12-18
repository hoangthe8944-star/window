namespace ex1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            label2 = new Label();
            txtTruongKhoa = new TextBox();
            label3 = new Label();
            txtDienThoai = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label5 = new Label();
            dgvKhoa = new DataGridView();
            txtSearch = new TextBox();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 75);
            flowLayoutPanel1.TabIndex = 0;
            //flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 118);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã khoa";
            //label1.Click += label1_Click;
            // 
            // textBox1
            // 
            txtMaKhoa.Location = new Point(118, 117);
            txtMaKhoa.Name = "textBox1";
            txtMaKhoa.Size = new Size(187, 27);
            txtMaKhoa.TabIndex = 2;
            // 
            // textBox2
            // 
            txtTenKhoa.Location = new Point(118, 160);
            txtTenKhoa.Name = "textBox2";
            txtTenKhoa.Size = new Size(187, 27);
            txtTenKhoa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 161);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên khoa";
            // 
            // textBox3
            // 
            txtTruongKhoa.Location = new Point(118, 245);
            txtTruongKhoa.Name = "textBox3";
            txtTruongKhoa.Size = new Size(187, 27);
            txtTruongKhoa.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 248);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "Sdt";
            // 
            // textBox4
            // 
            txtDienThoai.Location = new Point(118, 202);
            txtDienThoai.Name = "textBox4";
            txtDienThoai.Size = new Size(187, 27);
            txtDienThoai.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 205);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 5;
            label4.Text = "Trưởng khoa";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dgvKhoa);
            panel1.Location = new Point(387, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 354);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(3, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 50);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            btnThem.Location = new Point(9, 11);
            btnThem.Name = "button1";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            btnSua.Location = new Point(136, 11);
            btnSua.Name = "button2";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            btnXoa.Location = new Point(261, 11);
            btnXoa.Name = "button3";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(302, 60);
            label5.TabIndex = 0;
            label5.Text = "Quản lý khoa";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(3, 56);
            dgvKhoa.Name = "dataGridView1";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(404, 295);
            dgvKhoa.TabIndex = 0;
            // 
            // textBox5
            // 
            txtSearch.Location = new Point(14, 14);
            txtSearch.Name = "textBox5";
            txtSearch.Size = new Size(301, 27);
            txtSearch.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(321, 14);
            button4.Name = "button4";
            button4.Size = new Size(80, 29);
            button4.TabIndex = 2;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtTruongKhoa);
            Controls.Add(label3);
            Controls.Add(txtDienThoai);
            Controls.Add(label4);
            Controls.Add(txtTenKhoa);
            Controls.Add(label2);
            Controls.Add(txtMaKhoa);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form3";
            Text = "Form3";
            //Load += Form3_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Label label2;
        private TextBox txtTruongKhoa;
        private Label label3;
        private TextBox txtDienThoai;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button button4;
        private TextBox txtSearch;
        private DataGridView dgvKhoa;
    }
}