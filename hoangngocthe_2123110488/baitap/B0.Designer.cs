namespace baitap
{
    partial class B0
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
            this.SuspendLayout();
            // 
            // Bai20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253); // Kích thước mặc định ban đầu
            this.Name = "Bai20";
            this.Text = "Bai20";

            // QUAN TRỌNG: Đây là đoạn code kết nối sự kiện từ giao diện vào code xử lý
            this.Load += new System.EventHandler(this.Bai20_Load);
            this.ResizeEnd += new System.EventHandler(this.Bai20_ResizeEnd);

            this.ResumeLayout(false);
        }
    }
}