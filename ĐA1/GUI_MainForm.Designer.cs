namespace ĐA1
{
    partial class GUI_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menutransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnDsnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btnbaocao = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaphang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhacc = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLkho = new Guna.UI2.WinForms.Guna2Button();
            this.btnDSSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanpham = new Guna.UI2.WinForms.Guna2Button();
            this.MenuSanpham = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnTongquan = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnDonhang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDonhang = new Guna.UI2.WinForms.Guna2Button();
            this.btndonbanhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhuyenmai = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnqlchucvu = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblten = new System.Windows.Forms.Label();
            this.lblTenquyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaikhoan = new Guna.UI2.WinForms.Guna2Button();
            this.lblFuncName = new System.Windows.Forms.Label();
            this.pnNoidung = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnLogout = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuSanpham.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnDonhang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 801);
            this.panel2.TabIndex = 3;
            // 
            // Menutransition
            // 
            this.Menutransition.Interval = 1;
            this.Menutransition.Tick += new System.EventHandler(this.Menutransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // btnDsnhanvien
            // 
            this.btnDsnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnDsnhanvien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDsnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDsnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDsnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDsnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDsnhanvien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDsnhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDsnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnDsnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnDsnhanvien.Image")));
            this.btnDsnhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDsnhanvien.Location = new System.Drawing.Point(3, 507);
            this.btnDsnhanvien.Name = "btnDsnhanvien";
            this.btnDsnhanvien.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDsnhanvien.Size = new System.Drawing.Size(218, 47);
            this.btnDsnhanvien.TabIndex = 2;
            this.btnDsnhanvien.Text = "Danh sách nhân viên";
            this.btnDsnhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDsnhanvien.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnDsnhanvien.Click += new System.EventHandler(this.btnCauhinh_Click);
            this.btnDsnhanvien.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btnbaocao
            // 
            this.btnbaocao.BackColor = System.Drawing.Color.Transparent;
            this.btnbaocao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnbaocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbaocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbaocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbaocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbaocao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnbaocao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnbaocao.ForeColor = System.Drawing.Color.White;
            this.btnbaocao.Image = ((System.Drawing.Image)(resources.GetObject("btnbaocao.Image")));
            this.btnbaocao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbaocao.Location = new System.Drawing.Point(0, 410);
            this.btnbaocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnbaocao.Size = new System.Drawing.Size(221, 47);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "Báo cáo";
            this.btnbaocao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbaocao.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            this.btnbaocao.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachhang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnKhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachhang.Location = new System.Drawing.Point(3, 313);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(221, 47);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachhang.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            this.btnKhachhang.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhaphang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnNhaphang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaphang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaphang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaphang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhaphang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnNhaphang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhaphang.ForeColor = System.Drawing.Color.White;
            this.btnNhaphang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhaphang.Location = new System.Drawing.Point(0, 141);
            this.btnNhaphang.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNhaphang.Size = new System.Drawing.Size(221, 47);
            this.btnNhaphang.TabIndex = 2;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhaphang.TextOffset = new System.Drawing.Point(15, 0);
            this.btnNhaphang.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnNhacc
            // 
            this.btnNhacc.BackColor = System.Drawing.Color.Transparent;
            this.btnNhacc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnNhacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhacc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnNhacc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhacc.ForeColor = System.Drawing.Color.White;
            this.btnNhacc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhacc.Location = new System.Drawing.Point(0, 188);
            this.btnNhacc.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhacc.Name = "btnNhacc";
            this.btnNhacc.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNhacc.Size = new System.Drawing.Size(221, 47);
            this.btnNhacc.TabIndex = 2;
            this.btnNhacc.Text = "Nhà cung cấp";
            this.btnNhacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhacc.TextOffset = new System.Drawing.Point(15, 0);
            this.btnNhacc.Click += new System.EventHandler(this.btnNhacc_Click);
            this.btnNhacc.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnQLkho
            // 
            this.btnQLkho.BackColor = System.Drawing.Color.Transparent;
            this.btnQLkho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnQLkho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLkho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLkho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLkho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLkho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnQLkho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLkho.ForeColor = System.Drawing.Color.White;
            this.btnQLkho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLkho.Location = new System.Drawing.Point(0, 94);
            this.btnQLkho.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLkho.Name = "btnQLkho";
            this.btnQLkho.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQLkho.Size = new System.Drawing.Size(221, 47);
            this.btnQLkho.TabIndex = 2;
            this.btnQLkho.Text = "Quản lý kho";
            this.btnQLkho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLkho.TextOffset = new System.Drawing.Point(15, 0);
            this.btnQLkho.Click += new System.EventHandler(this.btnQLkho_Click);
            this.btnQLkho.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnDSSP
            // 
            this.btnDSSP.BackColor = System.Drawing.Color.Transparent;
            this.btnDSSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDSSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDSSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDSSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDSSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDSSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDSSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDSSP.ForeColor = System.Drawing.Color.White;
            this.btnDSSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDSSP.Location = new System.Drawing.Point(0, 47);
            this.btnDSSP.Margin = new System.Windows.Forms.Padding(0);
            this.btnDSSP.Name = "btnDSSP";
            this.btnDSSP.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDSSP.Size = new System.Drawing.Size(221, 47);
            this.btnDSSP.TabIndex = 2;
            this.btnDSSP.Text = "Danh sách sản phẩm";
            this.btnDSSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDSSP.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDSSP.Click += new System.EventHandler(this.btnDSSP_Click);
            this.btnDSSP.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnSanpham
            // 
            this.btnSanpham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanpham.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnSanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanpham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnSanpham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSanpham.ForeColor = System.Drawing.Color.White;
            this.btnSanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanpham.Image")));
            this.btnSanpham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanpham.Location = new System.Drawing.Point(0, 0);
            this.btnSanpham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSanpham.Size = new System.Drawing.Size(221, 47);
            this.btnSanpham.TabIndex = 2;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanpham.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            this.btnSanpham.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // MenuSanpham
            // 
            this.MenuSanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.MenuSanpham.Controls.Add(this.btnSanpham);
            this.MenuSanpham.Controls.Add(this.btnDSSP);
            this.MenuSanpham.Controls.Add(this.btnQLkho);
            this.MenuSanpham.Controls.Add(this.btnNhaphang);
            this.MenuSanpham.Controls.Add(this.btnNhacc);
            this.MenuSanpham.Controls.Add(this.btnLoaiSP);
            this.MenuSanpham.Location = new System.Drawing.Point(3, 260);
            this.MenuSanpham.Name = "MenuSanpham";
            this.MenuSanpham.Size = new System.Drawing.Size(221, 47);
            this.MenuSanpham.TabIndex = 4;
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.btnLoaiSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnLoaiSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoaiSP.Location = new System.Drawing.Point(0, 235);
            this.btnLoaiSP.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLoaiSP.Size = new System.Drawing.Size(221, 47);
            this.btnLoaiSP.TabIndex = 2;
            this.btnLoaiSP.Text = "Loại sản phẩm";
            this.btnLoaiSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoaiSP.TextOffset = new System.Drawing.Point(15, 0);
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            this.btnLoaiSP.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnTongquan
            // 
            this.btnTongquan.BackColor = System.Drawing.Color.Transparent;
            this.btnTongquan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnTongquan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTongquan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTongquan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTongquan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTongquan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnTongquan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTongquan.ForeColor = System.Drawing.Color.White;
            this.btnTongquan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongquan.Image")));
            this.btnTongquan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTongquan.Location = new System.Drawing.Point(0, 157);
            this.btnTongquan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTongquan.Name = "btnTongquan";
            this.btnTongquan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTongquan.Size = new System.Drawing.Size(221, 47);
            this.btnTongquan.TabIndex = 2;
            this.btnTongquan.Text = "Tổng quan";
            this.btnTongquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTongquan.Click += new System.EventHandler(this.btnTongquan_Click);
            this.btnTongquan.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 110);
            this.lblName.Margin = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "QHuy Store";
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.btnTongquan);
            this.sidebar.Controls.Add(this.pnDonhang);
            this.sidebar.Controls.Add(this.MenuSanpham);
            this.sidebar.Controls.Add(this.btnKhachhang);
            this.sidebar.Controls.Add(this.btnKhuyenmai);
            this.sidebar.Controls.Add(this.btnbaocao);
            this.sidebar.Controls.Add(this.btnBanhang);
            this.sidebar.Controls.Add(this.btnDsnhanvien);
            this.sidebar.Controls.Add(this.btnqlchucvu);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidebar.Size = new System.Drawing.Size(221, 752);
            this.sidebar.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 157);
            this.panel3.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(60, 9);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(101, 101);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pnDonhang
            // 
            this.pnDonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnDonhang.Controls.Add(this.btnDonhang);
            this.pnDonhang.Controls.Add(this.btndonbanhang);
            this.pnDonhang.Controls.Add(this.btnDonnhap);
            this.pnDonhang.Location = new System.Drawing.Point(3, 207);
            this.pnDonhang.Name = "pnDonhang";
            this.pnDonhang.Size = new System.Drawing.Size(221, 47);
            this.pnDonhang.TabIndex = 4;
            // 
            // btnDonhang
            // 
            this.btnDonhang.BackColor = System.Drawing.Color.Transparent;
            this.btnDonhang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDonhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDonhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDonhang.ForeColor = System.Drawing.Color.White;
            this.btnDonhang.Image = ((System.Drawing.Image)(resources.GetObject("btnDonhang.Image")));
            this.btnDonhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonhang.Location = new System.Drawing.Point(0, 0);
            this.btnDonhang.Margin = new System.Windows.Forms.Padding(0);
            this.btnDonhang.Name = "btnDonhang";
            this.btnDonhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDonhang.Size = new System.Drawing.Size(218, 47);
            this.btnDonhang.TabIndex = 2;
            this.btnDonhang.Text = "Đơn hàng";
            this.btnDonhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonhang.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnDonhang.Click += new System.EventHandler(this.btnDonhang_Click);
            this.btnDonhang.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btndonbanhang
            // 
            this.btndonbanhang.BackColor = System.Drawing.Color.Transparent;
            this.btndonbanhang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btndonbanhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndonbanhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndonbanhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndonbanhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndonbanhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btndonbanhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btndonbanhang.ForeColor = System.Drawing.Color.White;
            this.btndonbanhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndonbanhang.Location = new System.Drawing.Point(0, 47);
            this.btndonbanhang.Margin = new System.Windows.Forms.Padding(0);
            this.btndonbanhang.Name = "btndonbanhang";
            this.btndonbanhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btndonbanhang.Size = new System.Drawing.Size(221, 47);
            this.btndonbanhang.TabIndex = 2;
            this.btndonbanhang.Text = "Đơn bán hàng";
            this.btndonbanhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndonbanhang.TextOffset = new System.Drawing.Point(15, 0);
            this.btndonbanhang.Click += new System.EventHandler(this.btndonbanhang_Click);
            this.btndonbanhang.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnDonnhap
            // 
            this.btnDonnhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDonnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDonnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDonnhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDonnhap.ForeColor = System.Drawing.Color.White;
            this.btnDonnhap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonnhap.Location = new System.Drawing.Point(0, 94);
            this.btnDonnhap.Margin = new System.Windows.Forms.Padding(0);
            this.btnDonnhap.Name = "btnDonnhap";
            this.btnDonnhap.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDonnhap.Size = new System.Drawing.Size(221, 47);
            this.btnDonnhap.TabIndex = 2;
            this.btnDonnhap.Text = "Đơn nhập hàng";
            this.btnDonnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonnhap.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDonnhap.Click += new System.EventHandler(this.btnDonnhap_Click);
            this.btnDonnhap.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // btnKhuyenmai
            // 
            this.btnKhuyenmai.BackColor = System.Drawing.Color.Transparent;
            this.btnKhuyenmai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnKhuyenmai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhuyenmai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhuyenmai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhuyenmai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhuyenmai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnKhuyenmai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhuyenmai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenmai.Image = ((System.Drawing.Image)(resources.GetObject("btnKhuyenmai.Image")));
            this.btnKhuyenmai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhuyenmai.Location = new System.Drawing.Point(0, 363);
            this.btnKhuyenmai.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhuyenmai.Name = "btnKhuyenmai";
            this.btnKhuyenmai.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKhuyenmai.Size = new System.Drawing.Size(221, 47);
            this.btnKhuyenmai.TabIndex = 2;
            this.btnKhuyenmai.Text = "Khuyến mãi";
            this.btnKhuyenmai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhuyenmai.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnKhuyenmai.Click += new System.EventHandler(this.btnKhuyenmai_Click);
            this.btnKhuyenmai.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btnBanhang
            // 
            this.btnBanhang.BackColor = System.Drawing.Color.Transparent;
            this.btnBanhang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnBanhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanhang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnBanhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBanhang.ForeColor = System.Drawing.Color.White;
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanhang.Location = new System.Drawing.Point(0, 457);
            this.btnBanhang.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBanhang.Size = new System.Drawing.Size(221, 47);
            this.btnBanhang.TabIndex = 2;
            this.btnBanhang.Text = "Trang bán hàng";
            this.btnBanhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanhang.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnBanhang.Click += new System.EventHandler(this.btnBanle_Click);
            this.btnBanhang.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // btnqlchucvu
            // 
            this.btnqlchucvu.BackColor = System.Drawing.Color.Transparent;
            this.btnqlchucvu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnqlchucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnqlchucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnqlchucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnqlchucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnqlchucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnqlchucvu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnqlchucvu.ForeColor = System.Drawing.Color.White;
            this.btnqlchucvu.Image = ((System.Drawing.Image)(resources.GetObject("btnqlchucvu.Image")));
            this.btnqlchucvu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnqlchucvu.Location = new System.Drawing.Point(3, 560);
            this.btnqlchucvu.Name = "btnqlchucvu";
            this.btnqlchucvu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnqlchucvu.Size = new System.Drawing.Size(218, 47);
            this.btnqlchucvu.TabIndex = 2;
            this.btnqlchucvu.Text = "Quản lý chức vụ";
            this.btnqlchucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnqlchucvu.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnqlchucvu.Click += new System.EventHandler(this.btnqlchucvu_Click);
            this.btnqlchucvu.Leave += new System.EventHandler(this.mainbutton_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblten);
            this.panel1.Controls.Add(this.lblTenquyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTaikhoan);
            this.panel1.Controls.Add(this.lblFuncName);
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 52);
            this.panel1.TabIndex = 6;
            // 
            // lblten
            // 
            this.lblten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(927, 11);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(44, 16);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "label1";
            // 
            // lblTenquyen
            // 
            this.lblTenquyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenquyen.AutoSize = true;
            this.lblTenquyen.Location = new System.Drawing.Point(927, 27);
            this.lblTenquyen.Name = "lblTenquyen";
            this.lblTenquyen.Size = new System.Drawing.Size(44, 16);
            this.lblTenquyen.TabIndex = 2;
            this.lblTenquyen.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quyền: ";
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.BorderRadius = 3;
            this.btnTaikhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaikhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaikhoan.FillColor = System.Drawing.Color.White;
            this.btnTaikhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaikhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaikhoan.Location = new System.Drawing.Point(509, 0);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(107, 52);
            this.btnTaikhoan.TabIndex = 1;
            // 
            // lblFuncName
            // 
            this.lblFuncName.AutoSize = true;
            this.lblFuncName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncName.Location = new System.Drawing.Point(27, 15);
            this.lblFuncName.Name = "lblFuncName";
            this.lblFuncName.Size = new System.Drawing.Size(0, 25);
            this.lblFuncName.TabIndex = 0;
            // 
            // pnNoidung
            // 
            this.pnNoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNoidung.Location = new System.Drawing.Point(221, 52);
            this.pnNoidung.Name = "pnNoidung";
            this.pnNoidung.Size = new System.Drawing.Size(1069, 750);
            this.pnNoidung.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(221, 47);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.Leave += new System.EventHandler(this.subbutton_Leave);
            // 
            // pnLogout
            // 
            this.pnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(0, 752);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(221, 49);
            this.pnLogout.TabIndex = 0;
            // 
            // GUI_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1290, 801);
            this.Controls.Add(this.pnNoidung);
            this.Controls.Add(this.pnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý cửa hàng máy tính Qhuy Store";
            this.MenuSanpham.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnDonhang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer Menutransition;
        private System.Windows.Forms.Timer sidebarTransition;
        public Guna.UI2.WinForms.Guna2Button btnDsnhanvien;
        public Guna.UI2.WinForms.Guna2Button btnbaocao;
        public Guna.UI2.WinForms.Guna2Button btnKhachhang;
        public Guna.UI2.WinForms.Guna2Button btnNhaphang;
        public Guna.UI2.WinForms.Guna2Button btnNhacc;
        public Guna.UI2.WinForms.Guna2Button btnQLkho;
        public Guna.UI2.WinForms.Guna2Button btnDSSP;
        public Guna.UI2.WinForms.Guna2Button btnSanpham;
        public System.Windows.Forms.FlowLayoutPanel MenuSanpham;
        public Guna.UI2.WinForms.Guna2Button btnTongquan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblFuncName;
        public Guna.UI2.WinForms.Guna2Button btnTaikhoan;
        private System.Windows.Forms.Panel pnNoidung;
        private System.Windows.Forms.FlowLayoutPanel pnDonhang;
        public Guna.UI2.WinForms.Guna2Button btnDonhang;
        public Guna.UI2.WinForms.Guna2Button btndonbanhang;
        public Guna.UI2.WinForms.Guna2Button btnDonnhap;
        public Guna.UI2.WinForms.Guna2Button btnBanhang;
        public Guna.UI2.WinForms.Guna2Button btnKhuyenmai;
        public Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel pnLogout;
        public Guna.UI2.WinForms.Guna2Button btnLoaiSP;
        private System.Windows.Forms.Label lblTenquyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2Button btnqlchucvu;
    }
}