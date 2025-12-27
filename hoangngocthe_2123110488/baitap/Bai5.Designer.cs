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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.Size = new System.Drawing.Size(560, 150);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // colId
            // 
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Tuổi";
            this.colAge.MinimumWidth = 8;
            this.colAge.Name = "colAge";
            this.colAge.Width = 80;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Nam";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.Width = 50;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(65, 180);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(130, 26);
            this.tbId.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(65, 212);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 26);
            this.tbName.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(65, 258);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(130, 26);
            this.tbAge.TabIndex = 5;
            // 
            // ckGender
            // 
            this.ckGender.Location = new System.Drawing.Point(50, 287);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(104, 24);
            this.ckGender.TabIndex = 6;
            this.ckGender.Text = "Nam";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(218, 180);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 120);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(343, 222);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 35);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "Chọn ảnh ...";
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(300, 320);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 29);
            this.btAddNew.TabIndex = 7;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(390, 320);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 29);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(480, 320);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tuổi";
            // 
            // Bai5
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            this.Name = "Bai5";
            this.Text = "Quản lý nhân sự - Bai5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile, btAddNew, btDelete, btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}