namespace baitap
{
    partial class B3
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
            // Bai22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Bai3";
            this.Text = "Bai3 - Restore Size from XML";

            // Đăng ký sự kiện
            this.Load += new System.EventHandler(this.B3_Load);
            this.ResizeEnd += new System.EventHandler(this.B3_ResizeEnd);

            this.ResumeLayout(false);
        }
    }
}