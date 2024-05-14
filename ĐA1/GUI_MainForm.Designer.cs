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
            this.btnCauhinh = new Guna.UI2.WinForms.Guna2Button();
            this.btnbaocao = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaphang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhacc = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLkho = new Guna.UI2.WinForms.Guna2Button();
            this.btnDSSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanpham = new Guna.UI2.WinForms.Guna2Button();
            this.MenuSanpham = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTongquan = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaikhoan = new Guna.UI2.WinForms.Guna2Button();
            this.lblFuncName = new System.Windows.Forms.Label();
            this.pnNoidung = new System.Windows.Forms.Panel();
            this.MenuSanpham.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // btnCauhinh
            // 
            this.btnCauhinh.BackColor = System.Drawing.Color.Transparent;
            this.btnCauhinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnCauhinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCauhinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCauhinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCauhinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCauhinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnCauhinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCauhinh.ForeColor = System.Drawing.Color.White;
            this.btnCauhinh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCauhinh.Location = new System.Drawing.Point(3, 360);
            this.btnCauhinh.Name = "btnCauhinh";
            this.btnCauhinh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCauhinh.Size = new System.Drawing.Size(216, 47);
            this.btnCauhinh.TabIndex = 2;
            this.btnCauhinh.Text = "Cấu hình";
            this.btnCauhinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCauhinh.Click += new System.EventHandler(this.btnCauhinh_Click);
            this.btnCauhinh.Leave += new System.EventHandler(this.subbutton_Leave);
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
            this.btnbaocao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbaocao.Location = new System.Drawing.Point(0, 310);
            this.btnbaocao.Margin = new System.Windows.Forms.Padding(0);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnbaocao.Size = new System.Drawing.Size(216, 47);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "Báo cáo";
            this.btnbaocao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnKhachhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachhang.Location = new System.Drawing.Point(3, 260);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(216, 47);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnNhaphang.Size = new System.Drawing.Size(216, 47);
            this.btnNhaphang.TabIndex = 2;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhaphang.Click += new System.EventHandler(this.subbutton_Click);
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
            this.btnNhacc.Size = new System.Drawing.Size(216, 47);
            this.btnNhacc.TabIndex = 2;
            this.btnNhacc.Text = "Nhà cung cấp";
            this.btnNhacc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhacc.Click += new System.EventHandler(this.subbutton_Click);
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
            this.btnQLkho.Size = new System.Drawing.Size(216, 47);
            this.btnQLkho.TabIndex = 2;
            this.btnQLkho.Text = "Quản lý kho";
            this.btnQLkho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnDSSP.Size = new System.Drawing.Size(216, 47);
            this.btnDSSP.TabIndex = 2;
            this.btnDSSP.Text = "Danh sách sản phẩm";
            this.btnDSSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSanpham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanpham.Location = new System.Drawing.Point(0, 0);
            this.btnSanpham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSanpham.Size = new System.Drawing.Size(216, 47);
            this.btnSanpham.TabIndex = 2;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.MenuSanpham.Location = new System.Drawing.Point(3, 207);
            this.MenuSanpham.Name = "MenuSanpham";
            this.MenuSanpham.Size = new System.Drawing.Size(216, 47);
            this.MenuSanpham.TabIndex = 4;
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
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.btnTongquan);
            this.sidebar.Controls.Add(this.MenuSanpham);
            this.sidebar.Controls.Add(this.btnKhachhang);
            this.sidebar.Controls.Add(this.btnbaocao);
            this.sidebar.Controls.Add(this.btnCauhinh);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidebar.Size = new System.Drawing.Size(221, 801);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTaikhoan);
            this.panel1.Controls.Add(this.lblFuncName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 52);
            this.panel1.TabIndex = 6;
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
            this.btnTaikhoan.Location = new System.Drawing.Point(739, 0);
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
            this.pnNoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNoidung.Location = new System.Drawing.Point(221, 52);
            this.pnNoidung.Name = "pnNoidung";
            this.pnNoidung.Size = new System.Drawing.Size(1069, 749);
            this.pnNoidung.TabIndex = 7;
            // 
            // GUI_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1290, 801);
            this.Controls.Add(this.pnNoidung);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer Menutransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Guna.UI2.WinForms.Guna2Button btnCauhinh;
        private Guna.UI2.WinForms.Guna2Button btnbaocao;
        private Guna.UI2.WinForms.Guna2Button btnKhachhang;
        private Guna.UI2.WinForms.Guna2Button btnNhaphang;
        private Guna.UI2.WinForms.Guna2Button btnNhacc;
        private Guna.UI2.WinForms.Guna2Button btnQLkho;
        private Guna.UI2.WinForms.Guna2Button btnDSSP;
        private Guna.UI2.WinForms.Guna2Button btnSanpham;
        private System.Windows.Forms.FlowLayoutPanel MenuSanpham;
        private Guna.UI2.WinForms.Guna2Button btnTongquan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblFuncName;
        private Guna.UI2.WinForms.Guna2Button btnTaikhoan;
        private System.Windows.Forms.Panel pnNoidung;
    }
}