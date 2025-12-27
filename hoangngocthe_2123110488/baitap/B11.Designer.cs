namespace baitap
{
    partial class B11
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btMS = new System.Windows.Forms.Button();
            this.btMPlus = new System.Windows.Forms.Button();
            this.btMMinus = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btNegate = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btReciprocal = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(320, 41);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btMC (Hàng Memory)
            // 
            this.btMC.Location = new System.Drawing.Point(12, 75);
            this.btMC.Size = new System.Drawing.Size(60, 50);
            this.btMC.Text = "MC";
            this.btMC.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMR
            // 
            this.btMR.Location = new System.Drawing.Point(77, 75);
            this.btMR.Size = new System.Drawing.Size(60, 50);
            this.btMR.Text = "MR";
            this.btMR.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMS
            // 
            this.btMS.Location = new System.Drawing.Point(142, 75);
            this.btMS.Size = new System.Drawing.Size(60, 50);
            this.btMS.Text = "MS";
            this.btMS.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMPlus
            // 
            this.btMPlus.Location = new System.Drawing.Point(207, 75);
            this.btMPlus.Size = new System.Drawing.Size(60, 50);
            this.btMPlus.Text = "M+";
            this.btMPlus.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMMinus
            // 
            this.btMMinus.Location = new System.Drawing.Point(272, 75);
            this.btMMinus.Size = new System.Drawing.Size(60, 50);
            this.btMMinus.Text = "M-";
            this.btMMinus.Click += new System.EventHandler(this.Button_Click);
            // 
            // btBackspace (Hàng 1)
            // 
            this.btBackspace.Location = new System.Drawing.Point(12, 130);
            this.btBackspace.Size = new System.Drawing.Size(60, 50);
            this.btBackspace.Text = "←";
            this.btBackspace.Click += new System.EventHandler(this.Button_Click);
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(77, 130);
            this.btCE.Size = new System.Drawing.Size(60, 50);
            this.btCE.Text = "CE";
            this.btCE.Click += new System.EventHandler(this.Button_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(142, 130);
            this.btC.Size = new System.Drawing.Size(60, 50);
            this.btC.Text = "C";
            this.btC.Click += new System.EventHandler(this.Button_Click);
            // 
            // btNegate
            // 
            this.btNegate.Location = new System.Drawing.Point(207, 130);
            this.btNegate.Size = new System.Drawing.Size(60, 50);
            this.btNegate.Text = "±";
            this.btNegate.Click += new System.EventHandler(this.Button_Click);
            // 
            // btSqrt
            // 
            this.btSqrt.Location = new System.Drawing.Point(272, 130);
            this.btSqrt.Size = new System.Drawing.Size(60, 50);
            this.btSqrt.Text = "√";
            this.btSqrt.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt7 (Hàng 2)
            // 
            this.bt7.Location = new System.Drawing.Point(12, 185);
            this.bt7.Size = new System.Drawing.Size(60, 50);
            this.bt7.Text = "7";
            this.bt7.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(77, 185);
            this.bt8.Size = new System.Drawing.Size(60, 50);
            this.bt8.Text = "8";
            this.bt8.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(142, 185);
            this.bt9.Size = new System.Drawing.Size(60, 50);
            this.bt9.Text = "9";
            this.bt9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(207, 185);
            this.btDivide.Size = new System.Drawing.Size(60, 50);
            this.btDivide.Text = "/";
            this.btDivide.Click += new System.EventHandler(this.Button_Click);
            // 
            // btPercent
            // 
            this.btPercent.Location = new System.Drawing.Point(272, 185);
            this.btPercent.Size = new System.Drawing.Size(60, 50);
            this.btPercent.Text = "%";
            this.btPercent.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt4 (Hàng 3)
            // 
            this.bt4.Location = new System.Drawing.Point(12, 240);
            this.bt4.Size = new System.Drawing.Size(60, 50);
            this.bt4.Text = "4";
            this.bt4.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(77, 240);
            this.bt5.Size = new System.Drawing.Size(60, 50);
            this.bt5.Text = "5";
            this.bt5.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(142, 240);
            this.bt6.Size = new System.Drawing.Size(60, 50);
            this.bt6.Text = "6";
            this.bt6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(207, 240);
            this.btMul.Size = new System.Drawing.Size(60, 50);
            this.btMul.Text = "*";
            this.btMul.Click += new System.EventHandler(this.Button_Click);
            // 
            // btReciprocal
            // 
            this.btReciprocal.Location = new System.Drawing.Point(272, 240);
            this.btReciprocal.Size = new System.Drawing.Size(60, 50);
            this.btReciprocal.Text = "1/x";
            this.btReciprocal.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt1 (Hàng 4)
            // 
            this.bt1.Location = new System.Drawing.Point(12, 295);
            this.bt1.Size = new System.Drawing.Size(60, 50);
            this.bt1.Text = "1";
            this.bt1.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(77, 295);
            this.bt2.Size = new System.Drawing.Size(60, 50);
            this.bt2.Text = "2";
            this.bt2.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(142, 295);
            this.bt3.Size = new System.Drawing.Size(60, 50);
            this.bt3.Text = "3";
            this.bt3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(207, 295);
            this.btMinus.Size = new System.Drawing.Size(60, 50);
            this.btMinus.Text = "-";
            this.btMinus.Click += new System.EventHandler(this.Button_Click);
            // 
            // btEquals (Nút bằng cao gấp đôi)
            // 
            this.btEquals.Location = new System.Drawing.Point(272, 295);
            this.btEquals.Size = new System.Drawing.Size(60, 105);
            this.btEquals.Text = "=";
            this.btEquals.Click += new System.EventHandler(this.Button_Click);
            // 
            // bt0 (Nút 0 rộng gấp đôi)
            // 
            this.bt0.Location = new System.Drawing.Point(12, 350);
            this.bt0.Size = new System.Drawing.Size(125, 50);
            this.bt0.Text = "0";
            this.bt0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(142, 350);
            this.btDot.Size = new System.Drawing.Size(60, 50);
            this.btDot.Text = ".";
            this.btDot.Click += new System.EventHandler(this.Button_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(207, 350);
            this.btPlus.Size = new System.Drawing.Size(60, 50);
            this.btPlus.Text = "+";
            this.btPlus.Click += new System.EventHandler(this.Button_Click);
            // 
            // Bai8
            // 
            this.ClientSize = new System.Drawing.Size(345, 415);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btMC); this.Controls.Add(this.btMR); this.Controls.Add(this.btMS); this.Controls.Add(this.btMPlus); this.Controls.Add(this.btMMinus);
            this.Controls.Add(this.btBackspace); this.Controls.Add(this.btCE); this.Controls.Add(this.btC); this.Controls.Add(this.btNegate); this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.bt7); this.Controls.Add(this.bt8); this.Controls.Add(this.bt9); this.Controls.Add(this.btDivide); this.Controls.Add(this.btPercent);
            this.Controls.Add(this.bt4); this.Controls.Add(this.bt5); this.Controls.Add(this.bt6); this.Controls.Add(this.btMul); this.Controls.Add(this.btReciprocal);
            this.Controls.Add(this.bt1); this.Controls.Add(this.bt2); this.Controls.Add(this.bt3); this.Controls.Add(this.btMinus); this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt0); this.Controls.Add(this.btDot); this.Controls.Add(this.btPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Bai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, btDot;
        private System.Windows.Forms.Button btPlus, btMinus, btMul, btDivide, btEquals;
        private System.Windows.Forms.Button btSqrt, btPercent, btReciprocal, btNegate, btBackspace;
        private System.Windows.Forms.Button btC, btCE, btMC, btMR, btMS, btMPlus, btMMinus;
    }
}