namespace ĐA1
{
    partial class GUI_DSKhachhang
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
            this.ThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapfile = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKQtimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnTatcakh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoloc = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMakh = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clTenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongsldonhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemKH
            // 
            this.ThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThemKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemKH.ForeColor = System.Drawing.Color.White;
            this.ThemKH.Location = new System.Drawing.Point(890, 12);
            this.ThemKH.Name = "ThemKH";
            this.ThemKH.Size = new System.Drawing.Size(165, 44);
            this.ThemKH.TabIndex = 0;
            this.ThemKH.Text = "Thêm khách hàng";
            this.ThemKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ThemKH.Click += new System.EventHandler(this.ThemKH_Click);
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
            this.btnXuatfile.TabIndex = 1;
            this.btnXuatfile.Text = "Xuất File";
            this.btnXuatfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXuatfile.MouseEnter += new System.EventHandler(this.btnXuatfile_MouseEnter);
            this.btnXuatfile.MouseLeave += new System.EventHandler(this.btnXuatfile_MouseLeave);
            // 
            // btnNhapfile
            // 
            this.btnNhapfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnNhapfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapfile.ForeColor = System.Drawing.Color.Black;
            this.btnNhapfile.Location = new System.Drawing.Point(130, 13);
            this.btnNhapfile.Name = "btnNhapfile";
            this.btnNhapfile.Size = new System.Drawing.Size(113, 43);
            this.btnNhapfile.TabIndex = 1;
            this.btnNhapfile.Text = "Nhập File";
            this.btnNhapfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNhapfile.MouseEnter += new System.EventHandler(this.btnNhapfile_MouseEnter);
            this.btnNhapfile.MouseLeave += new System.EventHandler(this.btnNhapfile_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnKQtimkiem);
            this.panel1.Controls.Add(this.btnTatcakh);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnKQtimkiem
            // 
            this.btnKQtimkiem.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnKQtimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKQtimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKQtimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKQtimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKQtimkiem.FillColor = System.Drawing.Color.White;
            this.btnKQtimkiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKQtimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnKQtimkiem.Location = new System.Drawing.Point(143, 0);
            this.btnKQtimkiem.Name = "btnKQtimkiem";
            this.btnKQtimkiem.Size = new System.Drawing.Size(142, 50);
            this.btnKQtimkiem.TabIndex = 3;
            this.btnKQtimkiem.Text = "Kết quả tìm kiếm";
            this.btnKQtimkiem.Click += new System.EventHandler(this.btnKQtimkiem_Click);
            this.btnKQtimkiem.Leave += new System.EventHandler(this.btnKQtimkiem_Leave);
            // 
            // btnTatcakh
            // 
            this.btnTatcakh.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTatcakh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcakh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatcakh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatcakh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatcakh.FillColor = System.Drawing.Color.White;
            this.btnTatcakh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatcakh.ForeColor = System.Drawing.Color.Black;
            this.btnTatcakh.Location = new System.Drawing.Point(0, 0);
            this.btnTatcakh.Name = "btnTatcakh";
            this.btnTatcakh.Size = new System.Drawing.Size(142, 50);
            this.btnTatcakh.TabIndex = 3;
            this.btnTatcakh.Text = "Tất cả khách hàng";
            this.btnTatcakh.Click += new System.EventHandler(this.btnTatcakh_Click);
            this.btnTatcakh.Leave += new System.EventHandler(this.btnTatcakh_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnBoloc);
            this.panel2.Controls.Add(this.txtTimkiemKH);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 69);
            this.panel2.TabIndex = 2;
            // 
            // btnBoloc
            // 
            this.btnBoloc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBoloc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBoloc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBoloc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBoloc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoloc.ForeColor = System.Drawing.Color.White;
            this.btnBoloc.Location = new System.Drawing.Point(833, 15);
            this.btnBoloc.Name = "btnBoloc";
            this.btnBoloc.Size = new System.Drawing.Size(97, 35);
            this.btnBoloc.TabIndex = 1;
            this.btnBoloc.Text = "Bộ lọc";
            // 
            // txtTimkiemKH
            // 
            this.txtTimkiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiemKH.DefaultText = "Tìm kiếm theo mã khách hàng, tên, SĐT khách hàng";
            this.txtTimkiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiemKH.Location = new System.Drawing.Point(14, 15);
            this.txtTimkiemKH.Name = "txtTimkiemKH";
            this.txtTimkiemKH.PasswordChar = '\0';
            this.txtTimkiemKH.PlaceholderText = "";
            this.txtTimkiemKH.SelectedText = "";
            this.txtTimkiemKH.Size = new System.Drawing.Size(812, 36);
            this.txtTimkiemKH.TabIndex = 0;
            this.txtTimkiemKH.Click += new System.EventHandler(this.txtTimkiemKH_Click);
            // 
            // dgvKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.ColumnHeadersHeight = 40;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMakh,
            this.clTenkh,
            this.clNgaysinh,
            this.clGioitinh,
            this.clSDT,
            this.clAddress,
            this.clTongtien,
            this.clTongSP,
            this.clTongsldonhang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvKH.Location = new System.Drawing.Point(12, 193);
            this.dgvKH.Name = "dgvKH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.RowTemplate.Height = 40;
            this.dgvKH.RowTemplate.ReadOnly = true;
            this.dgvKH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.Size = new System.Drawing.Size(1042, 349);
            this.dgvKH.TabIndex = 3;
            this.dgvKH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKH.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKH.ThemeStyle.ReadOnly = false;
            this.dgvKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKH.ThemeStyle.RowsStyle.Height = 40;
            this.dgvKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // clMakh
            // 
            this.clMakh.DataPropertyName = "CUS_ID";
            this.clMakh.HeaderText = "Mã khách hàng";
            this.clMakh.Name = "clMakh";
            this.clMakh.ReadOnly = true;
            // 
            // clTenkh
            // 
            this.clTenkh.DataPropertyName = "CUS_NAME";
            this.clTenkh.HeaderText = "Tên khách hàng";
            this.clTenkh.Name = "clTenkh";
            this.clTenkh.ReadOnly = true;
            // 
            // clNgaysinh
            // 
            this.clNgaysinh.DataPropertyName = "CUS_BIRTHDAY";
            this.clNgaysinh.HeaderText = "Ngày sinh";
            this.clNgaysinh.Name = "clNgaysinh";
            this.clNgaysinh.ReadOnly = true;
            // 
            // clGioitinh
            // 
            this.clGioitinh.DataPropertyName = "CUS_GENDER";
            this.clGioitinh.HeaderText = "Giới tính";
            this.clGioitinh.Name = "clGioitinh";
            this.clGioitinh.ReadOnly = true;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "CUS_PHONE_NUMBER";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            this.clSDT.ReadOnly = true;
            // 
            // clAddress
            // 
            this.clAddress.DataPropertyName = "CUS_ADDRESS";
            this.clAddress.HeaderText = "Địa chỉ";
            this.clAddress.Name = "clAddress";
            this.clAddress.ReadOnly = true;
            // 
            // clTongtien
            // 
            this.clTongtien.DataPropertyName = "CUS_TOTAL_SPENDING_MONEY";
            this.clTongtien.HeaderText = "Tổng tiền đã mua";
            this.clTongtien.Name = "clTongtien";
            this.clTongtien.ReadOnly = true;
            // 
            // clTongSP
            // 
            this.clTongSP.DataPropertyName = "CUS_TOTAL_PRODUCTS_PURCHASED";
            this.clTongSP.HeaderText = "Tổng số sản phẩm đã mua";
            this.clTongSP.Name = "clTongSP";
            this.clTongSP.ReadOnly = true;
            // 
            // clTongsldonhang
            // 
            this.clTongsldonhang.DataPropertyName = "CUS_TOTAL_QUANTITY_OF_ORDER";
            this.clTongsldonhang.HeaderText = "Tổng SL đơn hàng";
            this.clTongsldonhang.Name = "clTongsldonhang";
            this.clTongsldonhang.ReadOnly = true;
            // 
            // GUI_DSKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNhapfile);
            this.Controls.Add(this.btnXuatfile);
            this.Controls.Add(this.ThemKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DSKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.GUI_DSKhachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ThemKH;
        private Guna.UI2.WinForms.Guna2Button btnXuatfile;
        private Guna.UI2.WinForms.Guna2Button btnNhapfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemKH;
        private Guna.UI2.WinForms.Guna2Button btnTatcakh;
        private Guna.UI2.WinForms.Guna2Button btnKQtimkiem;
        private Guna.UI2.WinForms.Guna2Button btnBoloc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewLinkColumn clMakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongsldonhang;
    }
}

