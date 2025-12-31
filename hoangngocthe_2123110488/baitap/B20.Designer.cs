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
            dgvEmployee = new DataGridView();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            lblId = new Label();
            lblName = new Label();
            lblAge = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(600, 180);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // tbId
            // 
            tbId.Location = new Point(100, 210);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 27);
            tbId.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(100, 240);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 27);
            tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(100, 270);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 27);
            tbAge.TabIndex = 3;
            // 
            // ckGender
            // 
            ckGender.Location = new Point(100, 300);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(104, 24);
            ckGender.TabIndex = 4;
            ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(320, 330);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(75, 25);
            btAddNew.TabIndex = 5;
            btAddNew.Text = "Thêm";
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(420, 330);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 25);
            btDelete.TabIndex = 6;
            btDelete.Text = "Xóa";
            btDelete.Click += btDelete_Click;
            // 
            // lblId
            // 
            lblId.Location = new Point(0, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(0, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 0;
            // 
            // B20
            // 
            ClientSize = new Size(624, 380);
            Controls.Add(dgvEmployee);
            Controls.Add(tbId);
            Controls.Add(tbName);
            Controls.Add(tbAge);
            Controls.Add(ckGender);
            Controls.Add(btAddNew);
            Controls.Add(btDelete);
            Name = "B20";
            Text = "DataGridView Article 21";
            Load += Bai21_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete;
        private System.Windows.Forms.Label lblId, lblName, lblAge;
    }
}