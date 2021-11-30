
namespace QuanLyNhanKhau
{
    partial class Quan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổDânPhốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgrQuan = new System.Windows.Forms.DataGridView();
            this.MaQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaQuan = new System.Windows.Forms.TextBox();
            this.tbSdtQ = new System.Windows.Forms.TextBox();
            this.tbTenQ = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quảnLýToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.thêmTàiKhoảnToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Tài khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
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
            this.quậnToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.quậnToolStripMenuItem.Text = "Quận";
            // 
            // phườngToolStripMenuItem
            // 
            this.phườngToolStripMenuItem.Name = "phườngToolStripMenuItem";
            this.phườngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.phườngToolStripMenuItem.Text = "Phường";
            this.phườngToolStripMenuItem.Click += new System.EventHandler(this.phườngToolStripMenuItem_Click);
            // 
            // tổDânPhốToolStripMenuItem
            // 
            this.tổDânPhốToolStripMenuItem.Name = "tổDânPhốToolStripMenuItem";
            this.tổDânPhốToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tổDânPhốToolStripMenuItem.Text = "Tổ dân phố";
            this.tổDânPhốToolStripMenuItem.Click += new System.EventHandler(this.tổDânPhốToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // dgrQuan
            // 
            this.dgrQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuan,
            this.TenQuan,
            this.SdtQuan});
            this.dgrQuan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrQuan.Location = new System.Drawing.Point(0, 276);
            this.dgrQuan.Name = "dgrQuan";
            this.dgrQuan.Size = new System.Drawing.Size(800, 174);
            this.dgrQuan.TabIndex = 1;
            this.dgrQuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQuan_CellContentClick_1);
            // 
            // MaQuan
            // 
            this.MaQuan.DataPropertyName = "sMaQuan";
            this.MaQuan.HeaderText = "Mã Quận";
            this.MaQuan.Name = "MaQuan";
            // 
            // TenQuan
            // 
            this.TenQuan.DataPropertyName = "sTenQ";
            this.TenQuan.HeaderText = "Tên Quận";
            this.TenQuan.Name = "TenQuan";
            // 
            // SdtQuan
            // 
            this.SdtQuan.DataPropertyName = "iSdtQ";
            this.SdtQuan.HeaderText = "Sđt Quận";
            this.SdtQuan.Name = "SdtQuan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Quận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Quận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sđt Quận";
            // 
            // tbMaQuan
            // 
            this.tbMaQuan.Location = new System.Drawing.Point(231, 54);
            this.tbMaQuan.Name = "tbMaQuan";
            this.tbMaQuan.Size = new System.Drawing.Size(267, 20);
            this.tbMaQuan.TabIndex = 6;
            // 
            // tbSdtQ
            // 
            this.tbSdtQ.Location = new System.Drawing.Point(231, 141);
            this.tbSdtQ.Name = "tbSdtQ";
            this.tbSdtQ.Size = new System.Drawing.Size(267, 20);
            this.tbSdtQ.TabIndex = 7;
            // 
            // tbTenQ
            // 
            this.tbTenQ.Location = new System.Drawing.Point(231, 98);
            this.tbTenQ.Name = "tbTenQ";
            this.tbTenQ.Size = new System.Drawing.Size(267, 20);
            this.tbTenQ.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(249, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(410, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(578, 224);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // Quan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTenQ);
            this.Controls.Add(this.tbSdtQ);
            this.Controls.Add(this.tbMaQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrQuan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quan";
            this.Text = "Quan";
            this.Load += new System.EventHandler(this.Quan_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgrQuan;
        private System.Windows.Forms.ToolStripMenuItem quậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổDânPhốToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaQuan;
        private System.Windows.Forms.TextBox tbSdtQ;
        private System.Windows.Forms.TextBox tbTenQ;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtQuan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
    }
}