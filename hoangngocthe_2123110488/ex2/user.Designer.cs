using System.Windows.Forms;

namespace ex2
{
    partial class user
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
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panelContent = new Panel();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Location = new Point(727, 99);
            button8.Name = "button8";
            button8.Size = new Size(54, 29);
            button8.TabIndex = 15;
            button8.Text = "Tìm";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(687, 15);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 14;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(583, 15);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 13;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(483, 15);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 11;
            label1.Text = "Quản lí user";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(483, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 281);
            dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 78);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 16;
            label2.Text = "Nhập id user";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panelContent.BackColor = Color.SteelBlue;
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(textBox2);
            panelContent.Controls.Add(button8);
            panelContent.Location = new Point(2, 119);
            panelContent.Name = "panel1";
            panelContent.Size = new Size(797, 79);
            panelContent.TabIndex = 16;

            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            FormBorderStyle = FormBorderStyle.None;
            Name = "user";
            Text = "user";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panelContent;

    }
}