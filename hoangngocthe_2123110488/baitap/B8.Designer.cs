namespace baitap
{
    partial class B8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntcong = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(191, 165);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(215, 26);
            this.txtY.TabIndex = 7;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(191, 99);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(215, 26);
            this.txtX.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số X";
            // 
            // TxtKq
            // 
            this.TxtKq.Location = new System.Drawing.Point(191, 231);
            this.TxtKq.Name = "TxtKq";
            this.TxtKq.Size = new System.Drawing.Size(215, 26);
            this.TxtKq.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // bntcong
            // 
            this.bntcong.Location = new System.Drawing.Point(127, 312);
            this.bntcong.Name = "bntcong";
            this.bntcong.Size = new System.Drawing.Size(128, 54);
            this.bntcong.TabIndex = 10;
            this.bntcong.Text = "Cộng";
            this.bntcong.UseVisualStyleBackColor = true;
            this.bntcong.Click += new System.EventHandler(this.bntcong_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(295, 312);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(128, 54);
            this.btnnhan.TabIndex = 11;
            this.btnnhan.Text = "Nhân";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(444, 312);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 54);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.bntcong);
            this.Controls.Add(this.TxtKq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntcong;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnexit;
    }
}