namespace ĐA1
{
    partial class GUI_DSSanpham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DSSanpham));
            this.panelIfnodata = new System.Windows.Forms.Panel();
            this.pnIfhavedata = new System.Windows.Forms.Panel();
            this.dgvSP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNCC = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clLoaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhanhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcotheban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLtonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngayktao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.cbbNhanhieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLoaisp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimkiemSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTatcaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapfile = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaonhacc = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelIfnodata.SuspendLayout();
            this.pnIfhavedata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIfnodata
            // 
            this.panelIfnodata.Controls.Add(this.pnIfhavedata);
            this.panelIfnodata.Controls.Add(this.btnNhapfile);
            this.panelIfnodata.Controls.Add(this.label1);
            this.panelIfnodata.Controls.Add(this.btnTaonhacc);
            this.panelIfnodata.Controls.Add(this.pictureBox1);
            this.panelIfnodata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIfnodata.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIfnodata.Location = new System.Drawing.Point(0, 0);
            this.panelIfnodata.Name = "panelIfnodata";
            this.panelIfnodata.Size = new System.Drawing.Size(1067, 554);
            this.panelIfnodata.TabIndex = 2;
            // 
            // pnIfhavedata
            // 
            this.pnIfhavedata.Controls.Add(this.dgvSP);
            this.pnIfhavedata.Controls.Add(this.panel2);
            this.pnIfhavedata.Controls.Add(this.panel1);
            this.pnIfhavedata.Controls.Add(this.btnnhap);
            this.pnIfhavedata.Controls.Add(this.btnXuatfile);
            this.pnIfhavedata.Controls.Add(this.btnThemSP);
            this.pnIfhavedata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnIfhavedata.Location = new System.Drawing.Point(0, 0);
            this.pnIfhavedata.Name = "pnIfhavedata";
            this.pnIfhavedata.Size = new System.Drawing.Size(1067, 554);
            this.pnIfhavedata.TabIndex = 4;
            // 
            // dgvSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(205)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSP.ColumnHeadersHeight = 40;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAnh,
            this.clmasp,
            this.clTenNCC,
            this.clLoaisp,
            this.clNhanhieu,
            this.clcotheban,
            this.clSLtonkho,
            this.clngayktao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSP.GridColor = System.Drawing.Color.White;
            this.dgvSP.Location = new System.Drawing.Point(12, 193);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSP.RowHeadersVisible = false;
            this.dgvSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSP.RowTemplate.Height = 40;
            this.dgvSP.RowTemplate.ReadOnly = true;
            this.dgvSP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSP.Size = new System.Drawing.Size(1042, 349);
            this.dgvSP.TabIndex = 9;
            this.dgvSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSP.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSP.ThemeStyle.ReadOnly = true;
            this.dgvSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSP.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clAnh
            // 
            this.clAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clAnh.DataPropertyName = "PRD_IMG";
            this.clAnh.HeaderText = "Ảnh";
            this.clAnh.Name = "clAnh";
            this.clAnh.ReadOnly = true;
            this.clAnh.Width = 37;
            // 
            // clmasp
            // 
            this.clmasp.DataPropertyName = "PRD_ID";
            this.clmasp.HeaderText = "Mã sản phẩm";
            this.clmasp.Name = "clmasp";
            this.clmasp.ReadOnly = true;
            this.clmasp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmasp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clTenNCC
            // 
            this.clTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clTenNCC.DataPropertyName = "PRD_NAME";
            this.clTenNCC.HeaderText = "Tên sản phẩm";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.ReadOnly = true;
            this.clTenNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTenNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clTenNCC.Width = 106;
            // 
            // clLoaisp
            // 
            this.clLoaisp.DataPropertyName = "PRD_TYPE_ID";
            this.clLoaisp.HeaderText = "Loại";
            this.clLoaisp.Name = "clLoaisp";
            this.clLoaisp.ReadOnly = true;
            // 
            // clNhanhieu
            // 
            this.clNhanhieu.DataPropertyName = "BRD_ID";
            this.clNhanhieu.HeaderText = "Nhãn hiệu";
            this.clNhanhieu.Name = "clNhanhieu";
            this.clNhanhieu.ReadOnly = true;
            // 
            // clcotheban
            // 
            this.clcotheban.DataPropertyName = "RDY_FOR_SALE";
            this.clcotheban.HeaderText = "Có thể bán";
            this.clcotheban.Name = "clcotheban";
            this.clcotheban.ReadOnly = true;
            // 
            // clSLtonkho
            // 
            this.clSLtonkho.DataPropertyName = "QUANTITY";
            this.clSLtonkho.HeaderText = "Tồn kho";
            this.clSLtonkho.Name = "clSLtonkho";
            this.clSLtonkho.ReadOnly = true;
            // 
            // clngayktao
            // 
            this.clngayktao.DataPropertyName = "CREATE_DAY";
            this.clngayktao.HeaderText = "Ngày khởi tạo";
            this.clngayktao.Name = "clngayktao";
            this.clngayktao.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.cbbNhanhieu);
            this.panel2.Controls.Add(this.cbbLoaisp);
            this.panel2.Controls.Add(this.txtTimkiemSP);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 69);
            this.panel2.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(929, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Xóa filter";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(814, 16);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cbbNhanhieu
            // 
            this.cbbNhanhieu.BackColor = System.Drawing.Color.Transparent;
            this.cbbNhanhieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNhanhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanhieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNhanhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNhanhieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNhanhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNhanhieu.ItemHeight = 30;
            this.cbbNhanhieu.Location = new System.Drawing.Point(589, 16);
            this.cbbNhanhieu.Name = "cbbNhanhieu";
            this.cbbNhanhieu.Size = new System.Drawing.Size(219, 36);
            this.cbbNhanhieu.TabIndex = 1;
            // 
            // cbbLoaisp
            // 
            this.cbbLoaisp.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaisp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaisp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaisp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaisp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaisp.ItemHeight = 30;
            this.cbbLoaisp.Location = new System.Drawing.Point(374, 16);
            this.cbbLoaisp.Name = "cbbLoaisp";
            this.cbbLoaisp.Size = new System.Drawing.Size(216, 36);
            this.cbbLoaisp.TabIndex = 1;
            // 
            // txtTimkiemSP
            // 
            this.txtTimkiemSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemSP.DefaultText = "";
            this.txtTimkiemSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimkiemSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemSP.Location = new System.Drawing.Point(12, 16);
            this.txtTimkiemSP.Name = "txtTimkiemSP";
            this.txtTimkiemSP.PasswordChar = '\0';
            this.txtTimkiemSP.PlaceholderText = "Tìm kiếm theo mã sản phẩm, tên sản phẩm";
            this.txtTimkiemSP.SelectedText = "";
            this.txtTimkiemSP.Size = new System.Drawing.Size(363, 36);
            this.txtTimkiemSP.TabIndex = 0;
            this.txtTimkiemSP.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTatcaSP);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 50);
            this.panel1.TabIndex = 8;
            // 
            // btnTatcaSP
            // 
            this.btnTatcaSP.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTatcaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatcaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatcaSP.FillColor = System.Drawing.Color.White;
            this.btnTatcaSP.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatcaSP.ForeColor = System.Drawing.Color.Black;
            this.btnTatcaSP.Location = new System.Drawing.Point(0, 0);
            this.btnTatcaSP.Name = "btnTatcaSP";
            this.btnTatcaSP.Size = new System.Drawing.Size(130, 50);
            this.btnTatcaSP.TabIndex = 3;
            this.btnTatcaSP.Text = "Tất cả sản phẩm";
            // 
            // btnnhap
            // 
            this.btnnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnnhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhap.ForeColor = System.Drawing.Color.Black;
            this.btnnhap.Location = new System.Drawing.Point(130, 13);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(113, 43);
            this.btnnhap.TabIndex = 5;
            this.btnnhap.Text = "Nhập File";
            this.btnnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnXuatfile
            // 
            this.btnXuatfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnXuatfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatfile.ForeColor = System.Drawing.Color.Black;
            this.btnXuatfile.Location = new System.Drawing.Point(11, 12);
            this.btnXuatfile.Name = "btnXuatfile";
            this.btnXuatfile.Size = new System.Drawing.Size(113, 43);
            this.btnXuatfile.TabIndex = 6;
            this.btnXuatfile.Text = "Xuất File";
            this.btnXuatfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(897, 12);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(158, 44);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnNhapfile
            // 
            this.btnNhapfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnNhapfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnNhapfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapfile.ForeColor = System.Drawing.Color.Black;
            this.btnNhapfile.Location = new System.Drawing.Point(12, 12);
            this.btnNhapfile.Name = "btnNhapfile";
            this.btnNhapfile.Size = new System.Drawing.Size(121, 39);
            this.btnNhapfile.TabIndex = 3;
            this.btnNhapfile.Text = "Nhập file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cửa hàng của bạn chưa có nhà cung cấp nào";
            // 
            // btnTaonhacc
            // 
            this.btnTaonhacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaonhacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaonhacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaonhacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaonhacc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(138)))), ((int)(((byte)(254)))));
            this.btnTaonhacc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaonhacc.ForeColor = System.Drawing.Color.White;
            this.btnTaonhacc.Location = new System.Drawing.Point(426, 431);
            this.btnTaonhacc.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaonhacc.Name = "btnTaonhacc";
            this.btnTaonhacc.Size = new System.Drawing.Size(215, 41);
            this.btnTaonhacc.TabIndex = 1;
            this.btnTaonhacc.Text = "Tạo nhà cung cấp đầu tiên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_DSSanpham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelIfnodata);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DSSanpham";
            this.Text = "GUI_DSSanpham";
            this.Load += new System.EventHandler(this.GUI_DSSanpham_Load);
            this.panelIfnodata.ResumeLayout(false);
            this.panelIfnodata.PerformLayout();
            this.pnIfhavedata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIfnodata;
        private System.Windows.Forms.Panel pnIfhavedata;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSP;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemSP;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTatcaSP;
        private Guna.UI2.WinForms.Guna2Button btnnhap;
        private Guna.UI2.WinForms.Guna2Button btnXuatfile;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2Button btnNhapfile;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTaonhacc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaisp;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNhanhieu;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private System.Windows.Forms.DataGridViewImageColumn clAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmasp;
        private System.Windows.Forms.DataGridViewLinkColumn clTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhanhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcotheban;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLtonkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngayktao;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}