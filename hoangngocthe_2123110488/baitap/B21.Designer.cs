namespace baitap
{
    partial class B21
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // DataGridView
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colName, this.colAge, this.colGender });
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Size = new System.Drawing.Size(560, 200);
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // Cột
            this.colId.HeaderText = "Mã nhân viên"; this.colName.HeaderText = "Tên nhân viên"; this.colAge.HeaderText = "Tuổi"; this.colGender.HeaderText = "Nam";
            // Nhập liệu
            this.tbId.Location = new System.Drawing.Point(100, 230);
            this.tbName.Location = new System.Drawing.Point(100, 260);
            this.tbAge.Location = new System.Drawing.Point(100, 290);
            this.ckGender.Location = new System.Drawing.Point(100, 320); this.ckGender.Text = "Nam";
            // Nút bấm
            this.btAddNew.Text = "Thêm"; this.btAddNew.Location = new System.Drawing.Point(300, 350); this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            this.btDelete.Text = "Xóa"; this.btDelete.Location = new System.Drawing.Point(390, 350); this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            this.btExit.Text = "Thoát"; this.btExit.Location = new System.Drawing.Point(480, 350); this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // Form
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvEmployee, this.tbId, this.tbName, this.tbAge, this.ckGender, this.btAddNew, this.btDelete, this.btExit });
            this.Text = "Bài 20 - Manual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
    }
}