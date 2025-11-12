namespace CoffeeHouseABC.User_Control
{
    partial class UC_Menu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnDatHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowPanel = new FlowLayoutPanel();
            btnDatHang = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Margin = new Padding(0);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(50, 15, 50, 15);
            flowPanel.Size = new Size(1580, 754);
            flowPanel.TabIndex = 0;
            // 
            // btnDatHang
            // 
            btnDatHang.BackColor = Color.DodgerBlue;
            btnDatHang.Dock = DockStyle.Right;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDatHang.ForeColor = Color.White;
            btnDatHang.Location = new Point(1279, 0);
            btnDatHang.Margin = new Padding(0);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(301, 72);
            btnDatHang.TabIndex = 1;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = false;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = btnDatHang;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = flowPanel;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnDatHang);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 682);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1580, 72);
            guna2Panel1.TabIndex = 0;
            // 
            // UC_Menu
            // 
            
            Controls.Add(flowPanel);
            Controls.Add(guna2Panel1);
            Name = "UC_Menu";
            Size = new Size(1580, 754);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
