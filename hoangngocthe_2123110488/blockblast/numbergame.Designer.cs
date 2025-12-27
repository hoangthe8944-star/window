namespace ex1
{
    partial class numbergame
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
            components = new System.ComponentModel.Container();
            pnlGameArea = new Panel();
            gameTimer = new System.Windows.Forms.Timer(components);
            gameTimer.Interval = 1000;
            lblTimer = new Label();
            btnStart = new Button();
            pnlGameArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGameArea
            // 
            pnlGameArea.Controls.Add(btnStart);
            pnlGameArea.Controls.Add(lblTimer);
            pnlGameArea.Dock = DockStyle.Fill;
            pnlGameArea.Location = new Point(0, 0);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(798, 450);
            pnlGameArea.TabIndex = 0;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTimer.Location = new Point(334, 9);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(114, 25);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "Thời gian: 60";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(345, 201);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(pnlGameArea);
            Name = "Form2";
            Text = "  ";
            pnlGameArea.ResumeLayout(false);
            pnlGameArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGameArea;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnStart;
        private Label lblTimer;
    }
}