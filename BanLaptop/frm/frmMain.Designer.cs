
namespace BanLaptop.frm
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem0 = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaCungCapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonChiTietChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoHanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InBaoCaoToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTenDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.SanPhamToolStripMenuItem,
            this.LoaiSanPhamToolStripMenuItem,
            this.NhaCungCapToolStripMenuItem,
            this.KhachHangToolStripMenuItem,
            this.HoaDonToolStripMenuItem,
            this.HoaDonChiTietChiTiếtToolStripMenuItem,
            this.BaoHanhToolStripMenuItem,
            this.NhanVienToolStripMenuItem,
            this.ThanhVienToolStripMenuItem,
            this.TroGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinTaiKhoanToolStripMenuItem,
            this.DoiMatKhauToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.hethong;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // ThongTinTaiKhoanToolStripMenuItem
            // 
            this.ThongTinTaiKhoanToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.taikhoan;
            this.ThongTinTaiKhoanToolStripMenuItem.Name = "ThongTinTaiKhoanToolStripMenuItem";
            this.ThongTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ThongTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            this.ThongTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.ThongTinTaiKhoanToolStripMenuItem_Click);
            // 
            // DoiMatKhauToolStripMenuItem
            // 
            this.DoiMatKhauToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.doimatkhau;
            this.DoiMatKhauToolStripMenuItem.Name = "DoiMatKhauToolStripMenuItem";
            this.DoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DoiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.DoiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.DoiMatKhauToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.dangxuat;
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // SanPhamToolStripMenuItem
            // 
            this.SanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem});
            this.SanPhamToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.sanphan;
            this.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem";
            this.SanPhamToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.SanPhamToolStripMenuItem.Text = "Danh Mục Laptop";
            this.SanPhamToolStripMenuItem.Click += new System.EventHandler(this.SanPhamToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem
            // 
            this.InBaoCaoToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem.Name = "InBaoCaoToolStripMenuItem";
            this.InBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem_Click);
            // 
            // LoaiSanPhamToolStripMenuItem
            // 
            this.LoaiSanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem0});
            this.LoaiSanPhamToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.loaisanpham;
            this.LoaiSanPhamToolStripMenuItem.Name = "LoaiSanPhamToolStripMenuItem";
            this.LoaiSanPhamToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.LoaiSanPhamToolStripMenuItem.Text = "Loại laptop";
            this.LoaiSanPhamToolStripMenuItem.Click += new System.EventHandler(this.LoaiSanPhamToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem0
            // 
            this.InBaoCaoToolStripMenuItem0.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem0.Name = "InBaoCaoToolStripMenuItem0";
            this.InBaoCaoToolStripMenuItem0.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem0.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem0.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem0_Click);
            // 
            // NhaCungCapToolStripMenuItem
            // 
            this.NhaCungCapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem1});
            this.NhaCungCapToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.nhacungcap;
            this.NhaCungCapToolStripMenuItem.Name = "NhaCungCapToolStripMenuItem";
            this.NhaCungCapToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.NhaCungCapToolStripMenuItem.Text = "Nhà cung cấp";
            this.NhaCungCapToolStripMenuItem.Click += new System.EventHandler(this.NhaCungCapToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem1
            // 
            this.InBaoCaoToolStripMenuItem1.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem1.Name = "InBaoCaoToolStripMenuItem1";
            this.InBaoCaoToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem1.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem1.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem1_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem2});
            this.KhachHangToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.khachhang;
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.KhachHangToolStripMenuItem.Text = "Danh Mục Khách Hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem2
            // 
            this.InBaoCaoToolStripMenuItem2.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem2.Name = "InBaoCaoToolStripMenuItem2";
            this.InBaoCaoToolStripMenuItem2.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem2.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem2.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem2_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem3});
            this.HoaDonToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.donhang;
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.HoaDonToolStripMenuItem.Text = "Hóa đơn bán laptop";
            this.HoaDonToolStripMenuItem.Click += new System.EventHandler(this.HoaDonToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem3
            // 
            this.InBaoCaoToolStripMenuItem3.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem3.Name = "InBaoCaoToolStripMenuItem3";
            this.InBaoCaoToolStripMenuItem3.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem3.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem3.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem3_Click);
            // 
            // HoaDonChiTietChiTiếtToolStripMenuItem
            // 
            this.HoaDonChiTietChiTiếtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem4});
            this.HoaDonChiTietChiTiếtToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.donhangchitiet;
            this.HoaDonChiTietChiTiếtToolStripMenuItem.Name = "HoaDonChiTietChiTiếtToolStripMenuItem";
            this.HoaDonChiTietChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.HoaDonChiTietChiTiếtToolStripMenuItem.Text = "Hóa đơn chi tiết bán laptop";
            this.HoaDonChiTietChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.HoaDonChiTietChiTiếtToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem4
            // 
            this.InBaoCaoToolStripMenuItem4.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem4.Name = "InBaoCaoToolStripMenuItem4";
            this.InBaoCaoToolStripMenuItem4.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem4.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem4.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem4_Click);
            // 
            // BaoHanhToolStripMenuItem
            // 
            this.BaoHanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem5});
            this.BaoHanhToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.baohanh;
            this.BaoHanhToolStripMenuItem.Name = "BaoHanhToolStripMenuItem";
            this.BaoHanhToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.BaoHanhToolStripMenuItem.Text = "Bảo hành";
            this.BaoHanhToolStripMenuItem.Click += new System.EventHandler(this.BaoHanhToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem5
            // 
            this.InBaoCaoToolStripMenuItem5.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem5.Name = "InBaoCaoToolStripMenuItem5";
            this.InBaoCaoToolStripMenuItem5.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem5.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem5.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem5_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem6});
            this.NhanVienToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.nhanvien;
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.NhanVienToolStripMenuItem.Text = "Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem6
            // 
            this.InBaoCaoToolStripMenuItem6.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem6.Name = "InBaoCaoToolStripMenuItem6";
            this.InBaoCaoToolStripMenuItem6.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem6.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem6.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem6_Click);
            // 
            // ThanhVienToolStripMenuItem
            // 
            this.ThanhVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InBaoCaoToolStripMenuItem7});
            this.ThanhVienToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.thanhvien;
            this.ThanhVienToolStripMenuItem.Name = "ThanhVienToolStripMenuItem";
            this.ThanhVienToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ThanhVienToolStripMenuItem.Text = "Thành viên";
            this.ThanhVienToolStripMenuItem.Click += new System.EventHandler(this.ThanhVienToolStripMenuItem_Click);
            // 
            // InBaoCaoToolStripMenuItem7
            // 
            this.InBaoCaoToolStripMenuItem7.Image = global::BanLaptop.Properties.Resources.InBaoCao;
            this.InBaoCaoToolStripMenuItem7.Name = "InBaoCaoToolStripMenuItem7";
            this.InBaoCaoToolStripMenuItem7.Size = new System.Drawing.Size(162, 26);
            this.InBaoCaoToolStripMenuItem7.Text = "In báo cáo";
            this.InBaoCaoToolStripMenuItem7.Click += new System.EventHandler(this.InBaoCaoToolStripMenuItem7_Click);
            // 
            // TroGiupToolStripMenuItem
            // 
            this.TroGiupToolStripMenuItem.Image = global::BanLaptop.Properties.Resources.trogiup;
            this.TroGiupToolStripMenuItem.Name = "TroGiupToolStripMenuItem";
            this.TroGiupToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.TroGiupToolStripMenuItem.Text = "Trợ giúp?";
            this.TroGiupToolStripMenuItem.Click += new System.EventHandler(this.TroGiupToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 53);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1084, 610);
            this.tabControlMain.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTenDangNhap,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTenDangNhap
            // 
            this.toolStripStatusLabelTenDangNhap.Name = "toolStripStatusLabelTenDangNhap";
            this.toolStripStatusLabelTenDangNhap.Size = new System.Drawing.Size(205, 20);
            this.toolStripStatusLabelTenDangNhap.Text = "Nhân viên: Nguyễn Trường Vũ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabelThoiGian
            // 
            this.toolStripStatusLabelThoiGian.Name = "toolStripStatusLabelThoiGian";
            this.toolStripStatusLabelThoiGian.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 663);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "PHẦN MỀM QUẢN LÝ BÁN LAPTOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTenDangNhap;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhaCungCapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoaDonChiTietChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoHanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TroGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoaiSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem0;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem InBaoCaoToolStripMenuItem7;
    }
}