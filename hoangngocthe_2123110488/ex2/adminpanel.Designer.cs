namespace ex2
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            panelSidebar = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button1 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button2 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button3 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button4 = new Button();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.MenuHighlight;
            panelSidebar.Controls.Add(pictureBox2);
            panelSidebar.Controls.Add(flowLayoutPanel3);
            panelSidebar.Controls.Add(flowLayoutPanel5);
            panelSidebar.Controls.Add(flowLayoutPanel4);
            panelSidebar.Controls.Add(flowLayoutPanel2);
            panelSidebar.Location = new Point(1, 1);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(252, 905);
            panelSidebar.TabIndex = 1;
            panelSidebar.Paint += panelSidebar_Paint_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Location = new Point(3, 161);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(249, 67);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(246, 64);
            button1.TabIndex = 0;
            button1.Text = "albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel5.Controls.Add(button2);
            flowLayoutPanel5.Location = new Point(3, 234);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(249, 75);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(246, 64);
            button2.TabIndex = 1;
            button2.Text = "artist";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;

            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Location = new Point(3, 315);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(249, 75);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(246, 64);
            button3.TabIndex = 1;
            button3.Text = "song";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Location = new Point(3, 396);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(249, 67);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(246, 64);
            button4.TabIndex = 1;
            button4.Text = "user";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_4;

            // 
            // panelContent
            // 
            panelContent.Location = new Point(259, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(720, 511);
            panelContent.TabIndex = 2;
            panelContent.Paint += panel1_Paint_1;
            // 
            // adminpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 511);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "adminpanel";
            Text = "adminpanel";
            Load += adminpanel_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel panelSidebar;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelContent;
    }
}