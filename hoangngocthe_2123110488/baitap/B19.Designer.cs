namespace baitap
{
    partial class B19
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // label1
            this.label1.Text = "Mã nhân viên";
            this.label1.Location = new System.Drawing.Point(20, 20);
            // label2
            this.label2.Text = "Tên nhân viên";
            this.label2.Location = new System.Drawing.Point(20, 50);
            // label3
            this.label3.Text = "Ảnh 3 x 4";
            this.label3.Location = new System.Drawing.Point(20, 80);
            // txtID
            this.txtID.Location = new System.Drawing.Point(120, 20);
            this.txtID.Size = new System.Drawing.Size(150, 20);
            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 50);
            this.txtName.Size = new System.Drawing.Size(250, 20);
            // pbImage
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(120, 80);
            this.pbImage.Size = new System.Drawing.Size(100, 120);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // btFile
            this.btFile.Text = "Chọn ảnh...";
            this.btFile.Location = new System.Drawing.Point(230, 80);
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // btAdd
            this.btAdd.Text = "Thêm vào bảng";
            this.btAdd.Location = new System.Drawing.Point(230, 115);
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // dgvEmployee (Bảng hiển thị)
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(20, 220);
            this.dgvEmployee.Size = new System.Drawing.Size(540, 180);
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // Bai27 Form
            this.ClientSize = new System.Drawing.Size(580, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.label1, this.label2, this.label3, this.txtID, this.txtName,
                this.pbImage, this.btFile, this.btAdd, this.dgvEmployee });
            this.Text = "Quản lý nhân sự - Bai27";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox txtID, txtName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile, btAdd;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}