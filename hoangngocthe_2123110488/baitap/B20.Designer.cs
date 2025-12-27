namespace baitap
{
    partial class B20
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(600, 180);
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // Nhập liệu
            // 
            this.tbId.Location = new System.Drawing.Point(100, 210);
            this.tbName.Location = new System.Drawing.Point(100, 240);
            this.tbAge.Location = new System.Drawing.Point(100, 270);
            this.ckGender.Text = "Nam"; this.ckGender.Location = new System.Drawing.Point(100, 300);
            // 
            // Nút bấm
            // 
            this.btAddNew.Text = "Thêm"; this.btAddNew.Location = new System.Drawing.Point(320, 330);
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Text = "Xóa"; this.btDelete.Location = new System.Drawing.Point(420, 330);
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form Bai30
            // 
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvEmployee, this.tbId, this.tbName, this.tbAge, this.ckGender, this.btAddNew, this.btDelete });
            this.Text = "DataGridView Article 21";
            this.Load += new System.EventHandler(this.Bai21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete;
        private System.Windows.Forms.Label lblId, lblName, lblAge;
    }
}