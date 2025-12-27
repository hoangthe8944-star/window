namespace baitap
{
    partial class B22
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false; // Không cho tự thêm dòng trống
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            this.dgvEmployee.Size = new System.Drawing.Size(600, 200);
            this.dgvEmployee.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id"; // KHÓA NGOẠI: Khớp với thuộc tính Id của Employee
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.Name = "colId";
            this.colId.Width = 100;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name"; // Khớp với Name của Employee
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age"; // Khớp với Age của Employee
            this.colAge.HeaderText = "Tuổi";
            this.colAge.Name = "colAge";
            this.colAge.Width = 80;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender"; // Khớp với Gender của Employee
            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.Name = "colGender";
            this.colGender.Width = 100;
            // 
            // Nhãn và Ô nhập liệu
            // 
            this.lblId.Text = "Mã"; this.lblId.Location = new System.Drawing.Point(30, 230);
            this.tbId.Location = new System.Drawing.Point(120, 230); this.tbId.Size = new System.Drawing.Size(150, 22);

            this.lblName.Text = "Tên"; this.lblName.Location = new System.Drawing.Point(30, 260);
            this.tbName.Location = new System.Drawing.Point(120, 260); this.tbName.Size = new System.Drawing.Size(300, 22);

            this.lblAge.Text = "Tuổi"; this.lblAge.Location = new System.Drawing.Point(30, 290);
            this.tbAge.Location = new System.Drawing.Point(120, 290); this.tbAge.Size = new System.Drawing.Size(150, 22);

            this.ckGender.Text = "Nam"; this.ckGender.Location = new System.Drawing.Point(120, 320);
            // 
            // Các nút bấm
            // 
            this.btAddNew.Text = "Thêm"; this.btAddNew.Location = new System.Drawing.Point(300, 350);
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Text = "Xóa"; this.btDelete.Location = new System.Drawing.Point(400, 350);
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btExit.Text = "Thoát"; this.btExit.Location = new System.Drawing.Point(500, 350);
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Bai29
            // 
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.dgvEmployee, this.lblId, this.tbId, this.lblName, this.tbName,
            this.lblAge, this.tbAge, this.ckGender, this.btAddNew, this.btDelete, this.btExit});
            this.Text = "Bài 22 - BindingSource";
            this.Load += new System.EventHandler(this.Bai29_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
        private System.Windows.Forms.Label lblId, lblName, lblAge;
    }
}