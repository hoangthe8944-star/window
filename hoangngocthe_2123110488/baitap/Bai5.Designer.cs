namespace baitap
{ 
    partial class Bai5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

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
            this.btAddNew = new Button();
            this.btDelete = new Button();
            this.btExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colAge, colGender });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.Size = new Size(560, 150);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // colId
            // 
            colId.HeaderText = "Mã nhân viên";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Tên nhân viên";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.Width = 200;
            // 
            // colAge
            // 
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 8;
            colAge.Name = "colAge";
            colAge.Width = 80;
            // 
            // colGender
            // 
            colGender.HeaderText = "Nam";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.Width = 50;
            // 
            // tbId
            // 
            tbId.Location = new Point(65, 180);
            tbId.Name = "tbId";
            tbId.Size = new Size(130, 27);
            tbId.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(65, 212);
            tbName.Name = "tbName";
            tbName.Size = new Size(130, 27);
            tbName.TabIndex = 4;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(65, 258);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(130, 27);
            tbAge.TabIndex = 5;
            // 
            // ckGender
            // 
            ckGender.Location = new Point(50, 287);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(104, 24);
            ckGender.TabIndex = 6;
            ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new Point(300, 320);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new Size(75, 29);
            this.btAddNew.TabIndex = 7;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += this.btAddNew_Click;
            // 
            // btDelete
            // 
            this.btDelete.Location = new Point(390, 320);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new Size(75, 29);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += this.btDelete_Click;
            // 
            // btExit
            // 
            this.btExit.Location = new Point(480, 320);
            this.btExit.Name = "btExit";
            this.btExit.Size = new Size(75, 29);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Thoát";
            //this.btExit.Click += this.btExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 186);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 215);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 12;
            label3.Text = "Tuổi";
            // 
            // Bai5
            // 
            ClientSize = new Size(584, 361);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Controls.Add(tbId);
            Controls.Add(tbName);
            Controls.Add(tbAge);
            Controls.Add(ckGender);
            Controls.Add(this.btAddNew);
            Controls.Add(this.btDelete);
            Controls.Add(this.btExit);
            Name = "Bai5";
            Text = "Quản lý nhân sự - Bai5";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;

    }
}