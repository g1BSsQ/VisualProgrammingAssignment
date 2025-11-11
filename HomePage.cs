using CoffeeHouseABC.Models;
using CoffeeHouseABC.User_Control;
using CoffeeHouseABC.Utils;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeHouseABC
{
    public partial class HomePage : Form
    {
        private bool isCollapsed = false;

        // 🔹 Cho phép null để tránh CS8618
        private UC_Menu? _ucMenu;
        

        private List<ChiTietDonHang> _gioHang = new();
        private List<string> _tenSP = new();

        public HomePage()
        {
            InitializeComponent();

        }

        // 🔹 Khi cần chuyển sang tab "Đơn hàng"
        public void ChuyenSangDonHang()
        {
            btnDonHang.PerformClick();
        }

        // 🔹 Cập nhật giỏ hàng (từ UC_Menu)
        public void CapNhatGioHang(List<ChiTietDonHang> ds, List<string> tenSP)
        {
            _gioHang = ds;
            _tenSP = tenSP;

            LoadUserControl(new UC_Order(_gioHang, _tenSP));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.BringToFront();

            // 🔹 Khởi tạo menu một lần duy nhất
            _ucMenu = new UC_Menu();
            LoadUserControl(_ucMenu);

        }

        // 🔹 Hàm nạp UserControl chung
        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            // Nếu menu chưa khởi tạo thì tạo mới
            if (_ucMenu == null)
                _ucMenu = new UC_Menu();

            LoadUserControl(_ucMenu);
        }

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_PurchaseHistory());

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0)
            {
                LoadUserControl(new UC_Order());
            }
            else
            {
                LoadUserControl(new UC_Order(_gioHang, _tenSP));
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Estimate());
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Account());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();

                Login.Login loginForm = new Login.Login();
                loginForm.Show();
                this.Close();
            }
        }

        // 🔹 Ẩn / hiện menu trái
        private void ToggleMenu()
        {
            if (!isCollapsed)
            {
                guna2Panel3.Width = 60;
                CollapseAllButtons();
                isCollapsed = true;
            }
            else
            {
                guna2Panel3.Width = 322;
                ExpandAllButtons();
                isCollapsed = false;
            }

            panelContainer.Dock = DockStyle.Fill;
            panelContainer.BringToFront();
        }

        private void CollapseAllButtons()
        {
            foreach (var ctrl in guna2Panel3.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.Text = "";
                    btn.CustomImages.ImageOffset = new Point(0, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);
                    btn.TextAlign = HorizontalAlignment.Center;
                    btn.TextOffset = new Point(0, 0);
                }
            }
        }

        private void ExpandAllButtons()
        {
            btnDanhMuc.Text = "Danh mục";
            btnThucDon.Text = "Thực đơn";
            btnDonHang.Text = "Đơn hàng";
            btnLichSuMuaHang.Text = "Lịch sử mua hàng";
            btnDanhGia.Text = "Đánh giá";
            btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            btnDangXuat.Text = "Đăng xuất";

            foreach (var ctrl in guna2Panel3.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.CustomImages.ImageOffset = new Point(10, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.TextOffset = new Point(45, 0);
                }
            }
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                SessionManager.Logout();

                Login.Login loginForm = new Login.Login();
                loginForm.Show();
                this.Close();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  // Đảm bảo thoát hoàn toàn chương trình
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
