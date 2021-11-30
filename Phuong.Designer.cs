
namespace QuanLyNhanKhau
{
    partial class Phuong
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
            this.dgrPhuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaP = new System.Windows.Forms.TextBox();
            this.tbMaQuan = new System.Windows.Forms.TextBox();
            this.tbTenP = new System.Windows.Forms.TextBox();
            this.tbSdtP = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.MaPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổDânPhốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrPhuong
            // 
            this.dgrPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhuong,
            this.MaQuan,
            this.TenPhuong,
            this.SdtP});
            this.dgrPhuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrPhuong.Location = new System.Drawing.Point(0, 269);
            this.dgrPhuong.Name = "dgrPhuong";
            this.dgrPhuong.Size = new System.Drawing.Size(800, 181);
            this.dgrPhuong.TabIndex = 0;
            this.dgrPhuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrPhuong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Quận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phường";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sđt Phường";
            // 
            // tbMaP
            // 
            this.tbMaP.Location = new System.Drawing.Point(218, 37);
            this.tbMaP.Name = "tbMaP";
            this.tbMaP.Size = new System.Drawing.Size(124, 20);
            this.tbMaP.TabIndex = 9;
            this.tbMaP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbMaQuan
            // 
            this.tbMaQuan.Location = new System.Drawing.Point(218, 74);
            this.tbMaQuan.Name = "tbMaQuan";
            this.tbMaQuan.Size = new System.Drawing.Size(124, 20);
            this.tbMaQuan.TabIndex = 10;
            // 
            // tbTenP
            // 
            this.tbTenP.Location = new System.Drawing.Point(558, 37);
            this.tbTenP.Name = "tbTenP";
            this.tbTenP.Size = new System.Drawing.Size(124, 20);
            this.tbTenP.TabIndex = 11;
            this.tbTenP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbSdtP
            // 
            this.tbSdtP.Location = new System.Drawing.Point(558, 88);
            this.tbSdtP.Name = "tbSdtP";
            this.tbSdtP.Size = new System.Drawing.Size(124, 20);
            this.tbSdtP.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(286, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(464, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(619, 208);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // MaPhuong
            // 
            this.MaPhuong.DataPropertyName = "sMaP";
            this.MaPhuong.HeaderText = "Mã Phường";
            this.MaPhuong.Name = "MaPhuong";
            // 
            // MaQuan
            // 
            this.MaQuan.DataPropertyName = "sMaQuan";
            this.MaQuan.HeaderText = "Mã Quận";
            this.MaQuan.Name = "MaQuan";
            // 
            // TenPhuong
            // 
            this.TenPhuong.DataPropertyName = "sTenP";
            this.TenPhuong.HeaderText = "Tên Phường";
            this.TenPhuong.Name = "TenPhuong";
            // 
            // SdtP
            // 
            this.SdtP.DataPropertyName = "iSdtP";
            this.SdtP.HeaderText = "Sđt Phường";
            this.SdtP.Name = "SdtP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.thêmTàiKhoảnToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm tài khoản";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quậnToolStripMenuItem,
            this.phườngToolStripMenuItem,
            this.tổDânPhốToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quậnToolStripMenuItem
            // 
            this.quậnToolStripMenuItem.Name = "quậnToolStripMenuItem";
            this.quậnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quậnToolStripMenuItem.Text = "Quận";
            this.quậnToolStripMenuItem.Click += new System.EventHandler(this.quậnToolStripMenuItem_Click);
            // 
            // phườngToolStripMenuItem
            // 
            this.phườngToolStripMenuItem.Name = "phườngToolStripMenuItem";
            this.phườngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phườngToolStripMenuItem.Text = "Phường";
            // 
            // tổDânPhốToolStripMenuItem
            // 
            this.tổDânPhốToolStripMenuItem.Name = "tổDânPhốToolStripMenuItem";
            this.tổDânPhốToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tổDânPhốToolStripMenuItem.Text = "Tổ dân phố";
            this.tổDânPhốToolStripMenuItem.Click += new System.EventHandler(this.tổDânPhốToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // Phuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbSdtP);
            this.Controls.Add(this.tbTenP);
            this.Controls.Add(this.tbMaQuan);
            this.Controls.Add(this.tbMaP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrPhuong);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Phuong";
            this.Text = "Phuong";
            this.Load += new System.EventHandler(this.Phuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPhuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPhuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaP;
        private System.Windows.Forms.TextBox tbMaQuan;
        private System.Windows.Forms.TextBox tbTenP;
        private System.Windows.Forms.TextBox tbSdtP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổDânPhốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
    }
}