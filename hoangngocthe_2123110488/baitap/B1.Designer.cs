namespace baitap
{
    partial class B1
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
            // Bai21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Bai1";
            this.Text = "Bai1 - XML Serialization";

            // ĐĂNG KÝ SỰ KIỆN Ở ĐÂY
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResizeEnd += new System.EventHandler(this.Bai1_ResizeEnd);

            this.ResumeLayout(false);
        }
    }
}