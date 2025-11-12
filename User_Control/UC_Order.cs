using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;
using CoffeeHouseABC.Utils;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Order : UserControl
    {
        private List<ChiTietDonHang> _ds = new();
        private List<string> _tenSP = new();

        // Constructor rỗng (dùng khi mở Đơn hàng mà chưa chọn gì)
        public UC_Order()
        {
            InitializeComponent();
            HienThiTrangThaiTrong();
        }

        //  Constructor có dữ liệu
        public UC_Order(List<ChiTietDonHang> ds, List<string> tenSP)
        {
            InitializeComponent();
            _ds = ds;
            _tenSP = tenSP;

            LoadOrder();
        }

        //  Khi chưa có đơn hàng
        private void HienThiTrangThaiTrong()
        {
            panelList.Controls.Clear();

            Label lbl = new Label
            {
                Text = "Bạn chưa chọn sản phẩm nào...",
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            panelList.Controls.Add(lbl);

            lblTongTien.Text = "Tổng: 0 VNĐ";
        }

        // load danh sách đơn hàng
        private void LoadOrder()
        {
            panelList.Controls.Clear();

            if (_ds == null || _ds.Count == 0)
            {
                HienThiTrangThaiTrong();
                return;
            }

            for (int i = 0; i < _ds.Count; i++)
            {
                var item = new UC_ItemOrder();
                item.SetData(_ds[i], _tenSP[i]);
                panelList.Controls.Add(item);
            }

            decimal tong = _ds.Sum(x => x.DonGiaBan * x.SoLuong);
            lblTongTien.Text = $"Tổng: {tong:N0} VNĐ";
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (_ds == null || _ds.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng!");
                return;
            }

            // Kiểm tra xem người dùng đã đăng nhập chưa
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi đặt hàng.");
                return;
            }

            try
            {
                DatabaseService db = new DatabaseService();
                int maKH = SessionManager.CurrentUser.MaKH;

                decimal tongTien = _ds.Sum(x => x.DonGiaBan * x.SoLuong);

                int maHD = db.TaoDonHang(maKH, tongTien, "Chưa thanh toán", _ds);

                MessageBox.Show($"Đặt hàng thành công! Mã đơn hàng: {maHD}");

                // Thay vì tạo UC_PurchaseHistory mới, tìm control có sẵn và reload dữ liệu
                var parent = this.Parent;
                if (parent != null)
                {
                    UC_PurchaseHistory historyUC = null;
                    
                    // Tìm UC_PurchaseHistory trong danh sách control cha
                    foreach (Control ctrl in parent.Controls)
                    {
                        if (ctrl is UC_PurchaseHistory uc)
                        {
                            historyUC = uc;
                            break;
                        }
                    }

                    if (historyUC == null)
                    {
                        // Nếu chưa có thì tạo mới (lần đầu tiên)
                        historyUC = new UC_PurchaseHistory();
                        historyUC.Dock = DockStyle.Fill;
                    }

                    // Gọi load lại dữ liệu
                    historyUC.LoadPurchaseHistory();

                    // Hiển thị UC_PurchaseHistory
                    parent.Controls.Clear();
                    parent.Controls.Add(historyUC);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy container để hiển thị lịch sử mua hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu đơn hàng: " + ex.Message);
            }
        }

        
    }
}
