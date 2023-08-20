using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanLaptop.dao;
using BanLaptop.models;


namespace BanLaptop.frm
{
    public partial class frmMain : Form
    {
        //Khai báo tài khoản người dùng đăng nhập
        public static ThanhVien thanhvien = null;
        public static TabControl tabControl = null;// static Thông qua tên lớp
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)
            {
                 //Mở form đăng nhập lên
                Form frm = new frmDangNhap();
            frm.ShowDialog();
            }
            toolStripStatusLabelTenDangNhap.Text = thanhvien.HoTen;

            //load hình ảnh
            tabControlMain.ImageList = LoadImageList();

            //Gán giá trị cho
            tabControl = tabControlMain;
        }
        private ImageList LoadImageList()
        {
            ImageList iconsList = new ImageList();
            iconsList.TransparentColor = Color.Blue;
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(25, 25);
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\hethong.png")); //0
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\sanphan.jpg")); //1
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\nhacungcap.png")); //2
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\khachhang.png")); //3
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\donhang.png")); //4
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\donhangchitiet.png")); //5
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\baohanh.png")); //6
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\nhanvien.png")); //7
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\thanhvien.jfif")); //8
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\trogiup.jfif")); //9
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\doimatkhau.png")); //10
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\taikhoan.jfif")); //11
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\loaisanpham.png")); //12
            iconsList.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\InBaoCao.jfif")); //13
            return iconsList;
        }
        //Hàm kiểm tra TabPage
        private bool ExistTabPage(TabControl control, string tabPageName)
        {
            bool check = false;
            for (int i = 0; i < control.TabPages.Count; i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Danh Mục Laptop";
            tab.Name = "tbSanPham";
            tab.ImageIndex = 1;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmSanPham();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbSanPham"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbSanPham"];
        }
        private void NhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Nhà Cung Cấp";
            tab.Name = "tbNhaCungCap";
            tab.ImageIndex = 2;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmNhaCC();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbNhaCungCap"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbNhaCungCap"];
        }
        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Danh Mục Khách Hàng";
            tab.Name = "tbKhach";
            tab.ImageIndex = 3;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmKhach();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbKhach"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbKhach"];
        }
        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Hóa Đơn Bán Laptop ";
            tab.Name = "tbHoaDon";
            tab.ImageIndex = 4;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmHoaDon();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbHoaDon"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbHoaDon"];
        }
        private void HoaDonChiTietChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Hóa Đơn Chi Tiết Bán Laptop";
            tab.Name = "tbHoaDonChiTiet";
            tab.ImageIndex = 5;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmChiTietHD();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbHoaDonChiTiet"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbHoaDonChiTiet"];
        }
        private void BaoHanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Bảo Hành";
            tab.Name = "tbBaoHanh";
            tab.ImageIndex = 6;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmBaoHanh();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbBaoHanh"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBaoHanh"];
        }
        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Nhân Viên";
            tab.Name = "tbNhanVien";
            tab.ImageIndex = 7;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmNhanVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbNhanVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbNhanVien"];
        }
        private void ThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Thành Viên";
            tab.Name = "tbThanhVien";
            tab.ImageIndex = 8;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmThanhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbThanhVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbThanhVien"];
        }
        private void TroGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Trợ Giúp?";
            tab.Name = "tbTroGiup";
            tab.ImageIndex = 9;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmTroGiup();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbTroGiup"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbTroGiup"];
        }
        private void ThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Thông Tin Thành Viên";
            tab.Name = "tbThongTinThanhVien";
            tab.ImageIndex = 11;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmThongTinTV();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbThongTinThanhVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbThongTinThanhVien"];
        }
        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Đổi Mật Khẩu";
            tab.Name = "tbDoiMatKhau";
            tab.ImageIndex = 10;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmDoiMatKhau();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbDoiMatKhau"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbDoiMatKhau"];
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frmMain.thanhvien = null;
            frmMain.ActiveForm.Hide();
            frm.ShowDialog();
        }
        private void LoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "Loại laptop";
            tab.Name = "tbLoaiSP";
            tab.ImageIndex = 12;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmLoaiSP();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbLoaiSP"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbLoaiSP"];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelThoiGian.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void InBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoSP();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem0_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoLSP();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoNCC();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoK();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoHD();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoCTHD();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoBH();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoNV();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
        private void InBaoCaoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //Tạo tabpage
            TabPage tab = new TabPage();
            tab.Text = "In Báo Cáo";
            tab.Name = "tbInBaoCao";
            tab.ImageIndex = 13;
            //Tạo form và add vào tabpage tên tab
            Form frm = new frmInBaoCaoTV();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            //kiểm tra tab đã tồn tại hay chưa, nếu chưa add tab và TabControl
            if (!ExistTabPage(tabControlMain, "tbInBaoCao"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbInBaoCao"];
        }
    }
}
