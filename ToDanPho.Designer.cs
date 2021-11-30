
namespace QuanLyNhanKhau
{
    partial class ToDanPho
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
            this.dgrTDP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTenTDP = new System.Windows.Forms.TextBox();
            this.tbCSKV = new System.Windows.Forms.TextBox();
            this.tbToTruong = new System.Windows.Forms.TextBox();
            this.tbSdtTDP = new System.Windows.Forms.TextBox();
            this.tbMaTDP = new System.Windows.Forms.TextBox();
            this.tbMaP = new System.Windows.Forms.TextBox();
            this.tbMaTK = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.MaTDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtTDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổDânPhốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTDP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrTDP
            // 
            this.dgrTDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTDP,
            this.MaP,
            this.MaTK,
            this.TenTDP,
            this.CSKV,
            this.ToTruong,
            this.SdtTDP});
            this.dgrTDP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrTDP.Location = new System.Drawing.Point(0, 278);
            this.dgrTDP.Name = "dgrTDP";
            this.dgrTDP.Size = new System.Drawing.Size(800, 172);
            this.dgrTDP.TabIndex = 0;
            this.dgrTDP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTDP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TDP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã TK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên TDP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cảnh sát KV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổ Trưởng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sđt Tổ DP";
            // 
            // tbTenTDP
            // 
            this.tbTenTDP.Location = new System.Drawing.Point(501, 29);
            this.tbTenTDP.Name = "tbTenTDP";
            this.tbTenTDP.Size = new System.Drawing.Size(237, 20);
            this.tbTenTDP.TabIndex = 11;
            // 
            // tbCSKV
            // 
            this.tbCSKV.Location = new System.Drawing.Point(501, 64);
            this.tbCSKV.Name = "tbCSKV";
            this.tbCSKV.Size = new System.Drawing.Size(237, 20);
            this.tbCSKV.TabIndex = 12;
            // 
            // tbToTruong
            // 
            this.tbToTruong.Location = new System.Drawing.Point(501, 97);
            this.tbToTruong.Name = "tbToTruong";
            this.tbToTruong.Size = new System.Drawing.Size(237, 20);
            this.tbToTruong.TabIndex = 13;
            // 
            // tbSdtTDP
            // 
            this.tbSdtTDP.Location = new System.Drawing.Point(209, 139);
            this.tbSdtTDP.Name = "tbSdtTDP";
            this.tbSdtTDP.Size = new System.Drawing.Size(237, 20);
            this.tbSdtTDP.TabIndex = 14;
            // 
            // tbMaTDP
            // 
            this.tbMaTDP.Location = new System.Drawing.Point(209, 29);
            this.tbMaTDP.Name = "tbMaTDP";
            this.tbMaTDP.Size = new System.Drawing.Size(124, 20);
            this.tbMaTDP.TabIndex = 15;
            // 
            // tbMaP
            // 
            this.tbMaP.Location = new System.Drawing.Point(209, 64);
            this.tbMaP.Name = "tbMaP";
            this.tbMaP.Size = new System.Drawing.Size(124, 20);
            this.tbMaP.TabIndex = 16;
            // 
            // tbMaTK
            // 
            this.tbMaTK.Location = new System.Drawing.Point(209, 97);
            this.tbMaTK.Name = "tbMaTK";
            this.tbMaTK.Size = new System.Drawing.Size(124, 20);
            this.tbMaTK.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(111, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(258, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(423, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(595, 225);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // MaTDP
            // 
            this.MaTDP.DataPropertyName = "sMaTDP";
            this.MaTDP.HeaderText = "Mã TDP";
            this.MaTDP.Name = "MaTDP";
            // 
            // MaP
            // 
            this.MaP.DataPropertyName = "sMaP";
            this.MaP.HeaderText = "Mã Phường";
            this.MaP.Name = "MaP";
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "iMaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.Name = "MaTK";
            // 
            // TenTDP
            // 
            this.TenTDP.DataPropertyName = "sTenTDP";
            this.TenTDP.HeaderText = "Tên TDP";
            this.TenTDP.Name = "TenTDP";
            // 
            // CSKV
            // 
            this.CSKV.DataPropertyName = "sCSKV";
            this.CSKV.HeaderText = "Cảnh sát KV";
            this.CSKV.Name = "CSKV";
            // 
            // ToTruong
            // 
            this.ToTruong.DataPropertyName = "sToTruong";
            this.ToTruong.HeaderText = "Tổ Trưởng";
            this.ToTruong.Name = "ToTruong";
            // 
            // SdtTDP
            // 
            this.SdtTDP.DataPropertyName = "iSdtTDP";
            this.SdtTDP.HeaderText = "Sđt Tổ DP";
            this.SdtTDP.Name = "SdtTDP";
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
            this.menuStrip1.TabIndex = 23;
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
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quậnToolStripMenuItem,
            this.phườngToolStripMenuItem,
            this.tổDânPhốToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
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
            this.phườngToolStripMenuItem.Click += new System.EventHandler(this.phườngToolStripMenuItem_Click);
            // 
            // tổDânPhốToolStripMenuItem
            // 
            this.tổDânPhốToolStripMenuItem.Name = "tổDânPhốToolStripMenuItem";
            this.tổDânPhốToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tổDânPhốToolStripMenuItem.Text = "Tổ dân phố";
            // 
            // ToDanPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbMaTK);
            this.Controls.Add(this.tbMaP);
            this.Controls.Add(this.tbMaTDP);
            this.Controls.Add(this.tbSdtTDP);
            this.Controls.Add(this.tbToTruong);
            this.Controls.Add(this.tbCSKV);
            this.Controls.Add(this.tbTenTDP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrTDP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToDanPho";
            this.Text = "ToDanPho";
            this.Load += new System.EventHandler(this.ToDanPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTDP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrTDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTenTDP;
        private System.Windows.Forms.TextBox tbCSKV;
        private System.Windows.Forms.TextBox tbToTruong;
        private System.Windows.Forms.TextBox tbSdtTDP;
        private System.Windows.Forms.TextBox tbMaTDP;
        private System.Windows.Forms.TextBox tbMaP;
        private System.Windows.Forms.TextBox tbMaTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtTDP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổDânPhốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
    }
}