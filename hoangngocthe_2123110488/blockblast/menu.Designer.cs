namespace blockblast
{
    partial class menu
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
            btnStage1 = new Button();
            btnStage2 = new Button();
            btnStage3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            btnStage1.Location = new Point(191, 162);
            btnStage1.Name = "button1";
            btnStage1.Size = new Size(94, 29);
            btnStage1.TabIndex = 0;
            btnStage1.Text = "button1";
            btnStage1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // button2
            // 
            btnStage2.Location = new Point(353, 211);
            btnStage2.Name = "button2";
            btnStage2.Size = new Size(94, 29);
            btnStage2.TabIndex = 1;
            btnStage2.Text = "button2";
            btnStage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            btnStage3.Location = new Point(498, 149);
            btnStage3.Name = "button3";
            btnStage3.Size = new Size(94, 29);
            btnStage3.TabIndex = 2;
            btnStage3.Text = "button3";
            btnStage3.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStage3);
            Controls.Add(btnStage2);
            Controls.Add(btnStage1);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStage1;
        private Button btnStage2;
        private Button btnStage3;
    }
}