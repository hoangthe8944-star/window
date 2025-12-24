namespace ex2
{
    partial class album
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContent = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(button8);
            panelContent.Controls.Add(button7);
            panelContent.Controls.Add(button6);
            panelContent.Controls.Add(button5);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(textBox2);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 450);
            panelContent.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(728, 67);
            button8.Name = "button8";
            button8.Size = new Size(54, 29);
            button8.TabIndex = 8;
            button8.Text = "Tìm";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(688, 26);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(584, 26);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(484, 26);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(212, 41);
            label1.TabIndex = 4;
            label1.Text = "Quản lí album";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 345);
            dataGridView1.TabIndex = 2;
            // 
            // album
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "album";
            Text = "Form1";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}
