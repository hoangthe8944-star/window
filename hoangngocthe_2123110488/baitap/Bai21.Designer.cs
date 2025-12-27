namespace baitap
{
    partial class Bai21
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
            this.Name = "Bai21";
            this.Text = "Bai21 - XML Serialization";

            // ĐĂNG KÝ SỰ KIỆN Ở ĐÂY
            this.Load += new System.EventHandler(this.Bai21_Load);
            this.ResizeEnd += new System.EventHandler(this.Bai21_ResizeEnd);

            this.ResumeLayout(false);
        }
    }
}