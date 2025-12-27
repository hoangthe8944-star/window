namespace baitap
{
    partial class Bai22
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
            this.Name = "Bai22";
            this.Text = "Bai22 - Restore Size from XML";

            // Đăng ký sự kiện
            this.Load += new System.EventHandler(this.Bai22_Load);
            this.ResizeEnd += new System.EventHandler(this.Bai22_ResizeEnd);

            this.ResumeLayout(false);
        }
    }
}