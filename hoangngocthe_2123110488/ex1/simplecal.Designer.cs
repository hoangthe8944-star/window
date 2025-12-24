namespace ex1
{
    partial class simplecal
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
            btnAdd = new Button();
            btnMultiply = new Button();
            btnExit = new Button();
            lblX = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            lblY = new Label();
            txtResult = new TextBox();
            lblResult = new Label();
            btnAdd.Click += btnAdd_Click;
            btnMultiply.Click += btnMultiply_Click;
            btnExit.Click += btnExit_Click;

            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(56, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Cộng";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(185, 284);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(91, 32);
            btnMultiply.TabIndex = 1;
            btnMultiply.Text = "Nhân";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;

            // 
            // btnExit
            // 
            btnExit.Location = new Point(370, 284);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(100, 71);
            lblX.Name = "lblX";
            lblX.Size = new Size(18, 20);
            lblX.TabIndex = 3;
            lblX.Text = "X";
            // 
            // txtX
            // 
            txtX.Location = new Point(146, 68);
            txtX.Name = "txtX";
            txtX.Size = new Size(257, 27);
            txtX.TabIndex = 4;
            // 
            // txtY
            // 
            txtY.Location = new Point(146, 122);
            txtY.Name = "txtY";
            txtY.Size = new Size(257, 27);
            txtY.TabIndex = 6;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(100, 122);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 20);
            lblY.TabIndex = 5;
            lblY.Text = "Y";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(146, 172);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(257, 27);
            txtResult.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(58, 172);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "Kết quả";
            // 
            // simplecal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 366);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(txtY);
            Controls.Add(lblY);
            Controls.Add(txtX);
            Controls.Add(lblX);
            Controls.Add(btnExit);
            Controls.Add(btnMultiply);
            Controls.Add(btnAdd);
            Name = "simplecal";
            Text = "simplecal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnMultiply;
        private Button btnExit;
        private Label lblX;
        private TextBox txtX;
        private TextBox txtY;
        private Label lblY;
        private TextBox txtResult;
        private Label lblResult;
    }
}