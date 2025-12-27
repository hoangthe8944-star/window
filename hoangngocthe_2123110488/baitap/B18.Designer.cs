namespace baitap
{
    partial class B18
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
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblFavorites = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt pleiku",
            "Em muốn sống bên anh trọn đời",
            "H\'Zen lên rẫy",
            "Còn thương nhau thì về buôn ma thuột",
            "Ly cà phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(22, 56);
            this.lbSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(224, 364);
            this.lbSong.TabIndex = 0;
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 20;
            this.lbFavorite.Location = new System.Drawing.Point(315, 56);
            this.lbFavorite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(314, 364);
            this.lbFavorite.TabIndex = 1;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(259, 175);
            this.btSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(45, 44);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(259, 238);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(45, 44);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "<";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(22, 25);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(138, 20);
            this.lblSongs.TabIndex = 4;
            this.lblSongs.Text = "Danh sách bài hát";
            // 
            // lblFavorites
            // 
            this.lblFavorites.AutoSize = true;
            this.lblFavorites.Location = new System.Drawing.Point(315, 25);
            this.lblFavorites.Name = "lblFavorites";
            this.lblFavorites.Size = new System.Drawing.Size(198, 20);
            this.lblFavorites.TabIndex = 5;
            this.lblFavorites.Text = "Danh sách bài hát ưa thích";
            // 
            // Bai26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 462);
            this.Controls.Add(this.lblFavorites);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai26";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Bai26_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblFavorites;
    }
}