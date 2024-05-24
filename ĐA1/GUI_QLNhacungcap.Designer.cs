namespace ĐA1
{
    partial class GUI_QLNhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLNhacungcap));
            this.panelIfnodata = new System.Windows.Forms.Panel();
            this.pnIfhavedata = new System.Windows.Forms.Panel();
            this.dgvNCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaNCC = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTatcaNCC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemnhacc = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapfile = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaonhacc = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelIfnodata.SuspendLayout();
            this.pnIfhavedata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
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
            this.panelIfnodata.TabIndex = 0;
            // 
            // pnIfhavedata
            // 
            this.pnIfhavedata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnIfhavedata.Controls.Add(this.dgvNCC);
            this.pnIfhavedata.Controls.Add(this.panel2);
            this.pnIfhavedata.Controls.Add(this.panel1);
            this.pnIfhavedata.Controls.Add(this.guna2Button1);
            this.pnIfhavedata.Controls.Add(this.btnXuatfile);
            this.pnIfhavedata.Controls.Add(this.btnThemnhacc);
            this.pnIfhavedata.Location = new System.Drawing.Point(0, 0);
            this.pnIfhavedata.Name = "pnIfhavedata";
            this.pnIfhavedata.Size = new System.Drawing.Size(1067, 554);
            this.pnIfhavedata.TabIndex = 4;
            // 
            // dgvNCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.ColumnHeadersHeight = 40;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNCC,
            this.clTenNCC,
            this.clDiachi,
            this.clSDT,
            this.clemail,
            this.clTrangthai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNCC.Location = new System.Drawing.Point(12, 193);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowTemplate.Height = 40;
            this.dgvNCC.RowTemplate.ReadOnly = true;
            this.dgvNCC.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.Size = new System.Drawing.Size(1042, 349);
            this.dgvNCC.TabIndex = 9;
            this.dgvNCC.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNCC.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNCC.ThemeStyle.ReadOnly = false;
            this.dgvNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNCC.ThemeStyle.RowsStyle.Height = 40;
            this.dgvNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // clMaNCC
            // 
            this.clMaNCC.DataPropertyName = "BRD_ID";
            this.clMaNCC.HeaderText = "Mã ";
            this.clMaNCC.Name = "clMaNCC";
            this.clMaNCC.ReadOnly = true;
            // 
            // clTenNCC
            // 
            this.clTenNCC.DataPropertyName = "BRD_NAME";
            this.clTenNCC.HeaderText = "Tên hãng sản xuất";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.ReadOnly = true;
            // 
            // clDiachi
            // 
            this.clDiachi.DataPropertyName = "BRD_ADDRESS";
            this.clDiachi.HeaderText = "Địa chỉ";
            this.clDiachi.Name = "clDiachi";
            this.clDiachi.ReadOnly = true;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "BRD_PHONE";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            this.clSDT.ReadOnly = true;
            // 
            // clemail
            // 
            this.clemail.DataPropertyName = "BRD_EMAIL";
            this.clemail.HeaderText = "Email";
            this.clemail.Name = "clemail";
            this.clemail.ReadOnly = true;
            // 
            // clTrangthai
            // 
            this.clTrangthai.DataPropertyName = "BRD_STATUS";
            this.clTrangthai.HeaderText = "Trạng thái";
            this.clTrangthai.Name = "clTrangthai";
            this.clTrangthai.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.txtTimkiemKH);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 69);
            this.panel2.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(890, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 41);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(746, 14);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(138, 41);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiemKH
            // 
            this.txtTimkiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemKH.DefaultText = "";
            this.txtTimkiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimkiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemKH.Location = new System.Drawing.Point(12, 14);
            this.txtTimkiemKH.Name = "txtTimkiemKH";
            this.txtTimkiemKH.PasswordChar = '\0';
            this.txtTimkiemKH.PlaceholderText = "Tìm kiếm theo mã nhà cung cấp, SĐT, tên nhà cung cấp";
            this.txtTimkiemKH.SelectedText = "";
            this.txtTimkiemKH.Size = new System.Drawing.Size(728, 41);
            this.txtTimkiemKH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTatcaNCC);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 50);
            this.panel1.TabIndex = 8;
            // 
            // btnTatcaNCC
            // 
            this.btnTatcaNCC.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTatcaNCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcaNCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatcaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatcaNCC.FillColor = System.Drawing.Color.White;
            this.btnTatcaNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatcaNCC.ForeColor = System.Drawing.Color.Black;
            this.btnTatcaNCC.Location = new System.Drawing.Point(0, 0);
            this.btnTatcaNCC.Name = "btnTatcaNCC";
            this.btnTatcaNCC.Size = new System.Drawing.Size(189, 50);
            this.btnTatcaNCC.TabIndex = 3;
            this.btnTatcaNCC.Text = "Danh sách hãng sản xuất";
            this.btnTatcaNCC.Click += new System.EventHandler(this.btnTatcaNCC_Click);
            this.btnTatcaNCC.Leave += new System.EventHandler(this.btnTatcaNCC_Leave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(130, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(113, 43);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Nhập File";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // btnThemnhacc
            // 
            this.btnThemnhacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemnhacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemnhacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemnhacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemnhacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemnhacc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemnhacc.ForeColor = System.Drawing.Color.White;
            this.btnThemnhacc.Location = new System.Drawing.Point(897, 12);
            this.btnThemnhacc.Name = "btnThemnhacc";
            this.btnThemnhacc.Size = new System.Drawing.Size(158, 44);
            this.btnThemnhacc.TabIndex = 4;
            this.btnThemnhacc.Text = "Thêm nhà cung cấp";
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
            // GUI_QLNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelIfnodata);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_QLNhacungcap";
            this.ShowInTaskbar = false;
            this.Text = "GUI_QLNhacungcap";
            this.Load += new System.EventHandler(this.GUI_QLNhacungcap_Load);
            this.panelIfnodata.ResumeLayout(false);
            this.panelIfnodata.PerformLayout();
            this.pnIfhavedata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIfnodata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTaonhacc;
        private Guna.UI2.WinForms.Guna2Button btnNhapfile;
        private System.Windows.Forms.Panel pnIfhavedata;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNCC;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemKH;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTatcaNCC;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnXuatfile;
        private Guna.UI2.WinForms.Guna2Button btnThemnhacc;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.DataGridViewLinkColumn clMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangthai;
    }
}