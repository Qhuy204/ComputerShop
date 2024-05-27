namespace ĐA1
{
    partial class GUI_DSHDnhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.btXuatdulieu = new Guna.UI2.WinForms.Guna2Button();
            this.dtpendate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtstartdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnNhaphang = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoafilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbbKhachhang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimmgg = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvhdban = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatdulieu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdban)).BeginInit();
            this.btnXuatdulieu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(554, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "đến";
            // 
            // btXuatdulieu
            // 
            this.btXuatdulieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXuatdulieu.BorderRadius = 5;
            this.btXuatdulieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXuatdulieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXuatdulieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXuatdulieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXuatdulieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btXuatdulieu.ForeColor = System.Drawing.Color.White;
            this.btXuatdulieu.Location = new System.Drawing.Point(682, 24);
            this.btXuatdulieu.Name = "btXuatdulieu";
            this.btXuatdulieu.Size = new System.Drawing.Size(136, 50);
            this.btXuatdulieu.TabIndex = 15;
            this.btXuatdulieu.Text = "Xuất dữ liệu";
            // 
            // dtpendate
            // 
            this.dtpendate.BorderRadius = 5;
            this.dtpendate.Checked = true;
            this.dtpendate.FillColor = System.Drawing.Color.White;
            this.dtpendate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpendate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpendate.Location = new System.Drawing.Point(591, 97);
            this.dtpendate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpendate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpendate.Name = "dtpendate";
            this.dtpendate.Size = new System.Drawing.Size(127, 36);
            this.dtpendate.TabIndex = 16;
            this.dtpendate.Value = new System.DateTime(2024, 5, 19, 20, 55, 39, 283);
            // 
            // dtstartdate
            // 
            this.dtstartdate.BorderRadius = 5;
            this.dtstartdate.Checked = true;
            this.dtstartdate.FillColor = System.Drawing.Color.White;
            this.dtstartdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtstartdate.Location = new System.Drawing.Point(421, 97);
            this.dtstartdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtstartdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtstartdate.Name = "dtstartdate";
            this.dtstartdate.Size = new System.Drawing.Size(127, 36);
            this.dtstartdate.TabIndex = 17;
            this.dtstartdate.Value = new System.DateTime(2024, 5, 19, 20, 55, 39, 283);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhaphang.BorderRadius = 5;
            this.btnNhaphang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaphang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaphang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaphang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhaphang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNhaphang.ForeColor = System.Drawing.Color.White;
            this.btnNhaphang.Location = new System.Drawing.Point(824, 24);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(136, 50);
            this.btnNhaphang.TabIndex = 14;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnxoafilter
            // 
            this.btnxoafilter.BorderRadius = 5;
            this.btnxoafilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoafilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoafilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoafilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoafilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnxoafilter.ForeColor = System.Drawing.Color.White;
            this.btnxoafilter.Location = new System.Drawing.Point(851, 97);
            this.btnxoafilter.Name = "btnxoafilter";
            this.btnxoafilter.Size = new System.Drawing.Size(109, 36);
            this.btnxoafilter.TabIndex = 14;
            this.btnxoafilter.Text = "Xóa filter";
            // 
            // btnsearch
            // 
            this.btnsearch.BorderRadius = 5;
            this.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(731, 97);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(109, 36);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "Tìm kiếm";
            // 
            // cbbKhachhang
            // 
            this.cbbKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.cbbKhachhang.BorderRadius = 5;
            this.cbbKhachhang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhachhang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhachhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbKhachhang.ItemHeight = 30;
            this.cbbKhachhang.Location = new System.Drawing.Point(211, 97);
            this.cbbKhachhang.Name = "cbbKhachhang";
            this.cbbKhachhang.Size = new System.Drawing.Size(206, 36);
            this.cbbKhachhang.TabIndex = 13;
            // 
            // txtTimmgg
            // 
            this.txtTimmgg.BorderRadius = 5;
            this.txtTimmgg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimmgg.DefaultText = "";
            this.txtTimmgg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimmgg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimmgg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimmgg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimmgg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimmgg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimmgg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimmgg.Location = new System.Drawing.Point(9, 97);
            this.txtTimmgg.Name = "txtTimmgg";
            this.txtTimmgg.PasswordChar = '\0';
            this.txtTimmgg.PlaceholderText = "Tìm kiếm theo mã hóa đơn";
            this.txtTimmgg.SelectedText = "";
            this.txtTimmgg.Size = new System.Drawing.Size(196, 36);
            this.txtTimmgg.TabIndex = 12;
            this.txtTimmgg.Tag = "";
            // 
            // dgvhdban
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvhdban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhdban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhdban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhdban.ColumnHeadersHeight = 40;
            this.dgvhdban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clMancc,
            this.clmanv,
            this.clngaynhap,
            this.cltongtien,
            this.clghichu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhdban.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhdban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvhdban.Location = new System.Drawing.Point(10, 147);
            this.dgvhdban.Margin = new System.Windows.Forms.Padding(0);
            this.dgvhdban.Name = "dgvhdban";
            this.dgvhdban.RowHeadersVisible = false;
            this.dgvhdban.RowTemplate.Height = 40;
            this.dgvhdban.RowTemplate.ReadOnly = true;
            this.dgvhdban.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhdban.Size = new System.Drawing.Size(950, 349);
            this.dgvhdban.TabIndex = 10;
            this.dgvhdban.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvhdban.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvhdban.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvhdban.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvhdban.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvhdban.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvhdban.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvhdban.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvhdban.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvhdban.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvhdban.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhdban.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvhdban.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvhdban.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvhdban.ThemeStyle.ReadOnly = false;
            this.dgvhdban.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhdban.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvhdban.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhdban.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvhdban.ThemeStyle.RowsStyle.Height = 40;
            this.dgvhdban.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvhdban.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "IB_ID";
            this.clID.HeaderText = "Mã hóa đơn";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            // 
            // clMancc
            // 
            this.clMancc.DataPropertyName = "BRD_ID";
            this.clMancc.HeaderText = "Mã nhà cung cấp";
            this.clMancc.Name = "clMancc";
            this.clMancc.ReadOnly = true;
            // 
            // clmanv
            // 
            this.clmanv.DataPropertyName = "EMP_ID";
            this.clmanv.HeaderText = "Mã nhân viên";
            this.clmanv.Name = "clmanv";
            this.clmanv.ReadOnly = true;
            // 
            // clngaynhap
            // 
            this.clngaynhap.DataPropertyName = "IB_DATE";
            this.clngaynhap.HeaderText = "Ngày nhập";
            this.clngaynhap.Name = "clngaynhap";
            this.clngaynhap.ReadOnly = true;
            // 
            // cltongtien
            // 
            this.cltongtien.DataPropertyName = "TOTAL_MONEY";
            this.cltongtien.HeaderText = "Tổng tiền";
            this.cltongtien.Name = "cltongtien";
            this.cltongtien.ReadOnly = true;
            // 
            // clghichu
            // 
            this.clghichu.DataPropertyName = "NOTE";
            this.clghichu.HeaderText = "Ghi chú";
            this.clghichu.Name = "clghichu";
            this.clghichu.ReadOnly = true;
            // 
            // btnXuatdulieu
            // 
            this.btnXuatdulieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatdulieu.BackColor = System.Drawing.Color.White;
            this.btnXuatdulieu.Controls.Add(this.label3);
            this.btnXuatdulieu.Controls.Add(this.btXuatdulieu);
            this.btnXuatdulieu.Controls.Add(this.dtpendate);
            this.btnXuatdulieu.Controls.Add(this.dtstartdate);
            this.btnXuatdulieu.Controls.Add(this.btnNhaphang);
            this.btnXuatdulieu.Controls.Add(this.btnxoafilter);
            this.btnXuatdulieu.Controls.Add(this.btnsearch);
            this.btnXuatdulieu.Controls.Add(this.cbbKhachhang);
            this.btnXuatdulieu.Controls.Add(this.txtTimmgg);
            this.btnXuatdulieu.Controls.Add(this.dgvhdban);
            this.btnXuatdulieu.Location = new System.Drawing.Point(22, 33);
            this.btnXuatdulieu.Name = "btnXuatdulieu";
            this.btnXuatdulieu.Size = new System.Drawing.Size(970, 530);
            this.btnXuatdulieu.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnXuatdulieu);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1013, 588);
            this.guna2Panel1.TabIndex = 1;
            // 
            // GUI_DSHDnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 588);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DSHDnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DSHDnhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdban)).EndInit();
            this.btnXuatdulieu.ResumeLayout(false);
            this.btnXuatdulieu.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btXuatdulieu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpendate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtstartdate;
        private Guna.UI2.WinForms.Guna2Button btnNhaphang;
        private Guna.UI2.WinForms.Guna2Button btnxoafilter;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbKhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txtTimmgg;
        private Guna.UI2.WinForms.Guna2DataGridView dgvhdban;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clghichu;
        private Guna.UI2.WinForms.Guna2Panel btnXuatdulieu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}