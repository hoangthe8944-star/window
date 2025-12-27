namespace blockblast
{
    partial class menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStage1 = new System.Windows.Forms.Button();
            this.btnStage2 = new System.Windows.Forms.Button();
            this.btnStage3 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGameList = new System.Windows.Forms.Button();
            this.ctxGameMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 150);
            this.lblTitle.Text = "BLOCK\nBLAST";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnStage1, btnStage2, btnStage3 (Kích thước và vị trí)
            // 
            this.btnStage1.Location = new System.Drawing.Point(100, 220);
            this.btnStage1.Size = new System.Drawing.Size(300, 80);
            this.btnStage1.Name = "btnStage1";
            // 
            this.btnStage2.Location = new System.Drawing.Point(100, 320);
            this.btnStage2.Size = new System.Drawing.Size(300, 80);
            this.btnStage2.Name = "btnStage2";
            // 
            this.btnStage3.Location = new System.Drawing.Point(100, 420);
            this.btnStage3.Size = new System.Drawing.Size(300, 80);
            this.btnStage3.Name = "btnStage3";
            // 
            // btnGameList (Nút chọn game góc phải)
            // 
            this.btnGameList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameList.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnGameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameList.ForeColor = System.Drawing.Color.White;
            this.btnGameList.Location = new System.Drawing.Point(360, 20);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Size = new System.Drawing.Size(120, 35);
            this.btnGameList.Text = "🎮 Đổi Game ▼";
            this.btnGameList.UseVisualStyleBackColor = false;
            this.btnGameList.Click += new System.EventHandler(this.btnGameList_Click);
            // 
            // ctxGameMenu (Danh sách thả xuống)
            // 
            this.ctxGameMenu.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ctxGameMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctxGameMenu.Name = "ctxGameMenu";
            this.ctxGameMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // menu Form
            // 
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.btnGameList);
            this.Controls.Add(this.btnStage3);
            this.Controls.Add(this.btnStage2);
            this.Controls.Add(this.btnStage1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Hub";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStage1;
        private System.Windows.Forms.Button btnStage2;
        private System.Windows.Forms.Button btnStage3;
        private System.Windows.Forms.Button btnGameList;
        private System.Windows.Forms.ContextMenuStrip ctxGameMenu;
    }
}