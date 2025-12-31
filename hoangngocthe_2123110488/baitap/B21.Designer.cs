namespace baitap
{
    partial class B21
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewCheckBoxColumn();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            btExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeight = 29;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colAge, colGender });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(560, 200);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // colId
            // 
            colId.HeaderText = "Mã nhân viên";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Tên nhân viên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colAge
            // 
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            colAge.Width = 125;
            // 
            // colGender
            // 
            colGender.HeaderText = "Nam";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.Width = 125;
            // 
            // tbId
            // 
            tbId.Location = new Point(100, 230);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 27);
            tbId.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(100, 260);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 27);
            tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(100, 290);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 27);
            tbAge.TabIndex = 3;
            // 
            // ckGender
            // 
            ckGender.Location = new Point(100, 320);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(104, 24);
            ckGender.TabIndex = 4;
            ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(300, 350);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(75, 27);
            btAddNew.TabIndex = 5;
            btAddNew.Text = "Thêm";
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(390, 350);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 27);
            btDelete.TabIndex = 6;
            btDelete.Text = "Xóa";
            btDelete.Click += btDelete_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(480, 350);
            btExit.Name = "btExit";
            btExit.Size = new Size(75, 27);
            btExit.TabIndex = 7;
            btExit.Text = "Thoát";
            btExit.Click += btExit_Click;
            // 
            // B21
            // 
            ClientSize = new Size(584, 400);
            Controls.Add(dgvEmployee);
            Controls.Add(tbId);
            Controls.Add(tbName);
            Controls.Add(tbAge);
            Controls.Add(ckGender);
            Controls.Add(btAddNew);
            Controls.Add(btDelete);
            Controls.Add(btExit);
            Name = "B21";
            Text = "Bài 20 - Manual";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
    }
}