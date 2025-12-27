namespace baitap
{
    partial class Bai23
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
            this.Name = "Bai23";
            // Quan trọng: Phải là Manual để có thể tự áp dụng tọa độ Location khi Load
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bai23 - Article 03";

            // Đăng ký các sự kiện
            this.Load += new System.EventHandler(this.Bai23_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai23_FormClosing);

            this.ResumeLayout(false);
        }
    }
}