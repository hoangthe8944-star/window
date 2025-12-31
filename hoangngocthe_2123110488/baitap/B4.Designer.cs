namespace baitap
{
    partial class B4
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
            // Bai23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "Bai4";
            // Quan trọng: Phải là Manual để có thể tự áp dụng tọa độ Location khi Load
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bai4 - Article 03";

            // Đăng ký các sự kiện
            this.Load += new System.EventHandler(this.B4_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.B4_FormClosing);

            this.ResumeLayout(false);
        }
    }
}