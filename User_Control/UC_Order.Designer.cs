namespace CoffeeHouseABC.User_Control
{
    partial class UC_Order
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelList;
        private Label lblTongTien;
        private Button btnThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelList = new FlowLayoutPanel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.AutoScroll = true;
            panelList.BackColor = Color.White;
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(0, 0);
            panelList.Margin = new Padding(0);
            panelList.Name = "panelList";
            panelList.Padding = new Padding(50, 15, 50, 15);
            panelList.Size = new Size(1580, 754);
            panelList.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.White;
            lblTongTien.Dock = DockStyle.Left;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.Location = new Point(0, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(344, 84);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng: 0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(70, 183, 91);
            btnThanhToan.Dock = DockStyle.Right;
            btnThanhToan.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1292, 0);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(288, 84);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += BtnThanhToan_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = btnThanhToan;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblTongTien);
            guna2Panel1.Controls.Add(btnThanhToan);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 670);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1580, 84);
            guna2Panel1.TabIndex = 1;
            // 
            // UC_Order
            // 
            BackColor = Color.White;
            
            Controls.Add(panelList);
            Controls.Add(guna2Panel1);
            Name = "UC_Order";
            Size = new Size(1580, 754);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
