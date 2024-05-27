namespace ĐA1
{
    partial class GUI_DSLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DSLoaiSP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNhapfile = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvloaisp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTatcaNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTaonhacc = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bththemlsp = new Guna.UI2.WinForms.Guna2Button();
            this.pnIfhavedata = new System.Windows.Forms.Panel();
            this.panelIfnodata = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnIfhavedata.SuspendLayout();
            this.panelIfnodata.SuspendLayout();
            this.SuspendLayout();
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
            // dgvloaisp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvloaisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvloaisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloaisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvloaisp.ColumnHeadersHeight = 40;
            this.dgvloaisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloaisp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvloaisp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvloaisp.Location = new System.Drawing.Point(12, 193);
            this.dgvloaisp.Name = "dgvloaisp";
            this.dgvloaisp.RowHeadersVisible = false;
            this.dgvloaisp.RowTemplate.Height = 40;
            this.dgvloaisp.RowTemplate.ReadOnly = true;
            this.dgvloaisp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloaisp.Size = new System.Drawing.Size(1037, 383);
            this.dgvloaisp.TabIndex = 9;
            this.dgvloaisp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvloaisp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvloaisp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvloaisp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvloaisp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvloaisp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvloaisp.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvloaisp.ThemeStyle.ReadOnly = false;
            this.dgvloaisp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvloaisp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvloaisp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvloaisp.ThemeStyle.RowsStyle.Height = 40;
            this.dgvloaisp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvloaisp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvloaisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaisp_CellContentClick);
            // 
            // clid
            // 
            this.clid.DataPropertyName = "PRD_TYPE_ID";
            this.clid.HeaderText = "Mã loại sản phẩm";
            this.clid.Name = "clid";
            this.clid.ReadOnly = true;
            // 
            // clname
            // 
            this.clname.DataPropertyName = "PRD_TYPE_NAME";
            this.clname.HeaderText = "Tên loại sản phẩm";
            this.clname.Name = "clname";
            this.clname.ReadOnly = true;
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
            this.btnTatcaNCC.Text = "Danh sách loại sản phẩm";
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
            this.txtTimkiemKH.PlaceholderText = "Tìm kiếm theo mã loại sản phẩm, tên loại sản phẩm";
            this.txtTimkiemKH.SelectedText = "";
            this.txtTimkiemKH.Size = new System.Drawing.Size(728, 41);
            this.txtTimkiemKH.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(1038, 69);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTatcaNCC);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 50);
            this.panel1.TabIndex = 8;
            // 
            // bththemlsp
            // 
            this.bththemlsp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bththemlsp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bththemlsp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bththemlsp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bththemlsp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bththemlsp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.bththemlsp.ForeColor = System.Drawing.Color.White;
            this.bththemlsp.Location = new System.Drawing.Point(892, 12);
            this.bththemlsp.Name = "bththemlsp";
            this.bththemlsp.Size = new System.Drawing.Size(158, 44);
            this.bththemlsp.TabIndex = 4;
            this.bththemlsp.Text = "Thêm loại sản phẩm";
            this.bththemlsp.Click += new System.EventHandler(this.bththemlsp_Click);
            // 
            // pnIfhavedata
            // 
            this.pnIfhavedata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnIfhavedata.Controls.Add(this.dgvloaisp);
            this.pnIfhavedata.Controls.Add(this.panel2);
            this.pnIfhavedata.Controls.Add(this.panel1);
            this.pnIfhavedata.Controls.Add(this.bththemlsp);
            this.pnIfhavedata.Location = new System.Drawing.Point(0, 0);
            this.pnIfhavedata.Name = "pnIfhavedata";
            this.pnIfhavedata.Size = new System.Drawing.Size(1062, 588);
            this.pnIfhavedata.TabIndex = 4;
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
            this.panelIfnodata.Size = new System.Drawing.Size(1062, 588);
            this.panelIfnodata.TabIndex = 1;
            // 
            // GUI_DSLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 588);
            this.Controls.Add(this.panelIfnodata);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DSLoaiSP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DSLoaiSP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnIfhavedata.ResumeLayout(false);
            this.panelIfnodata.ResumeLayout(false);
            this.panelIfnodata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnNhapfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvloaisp;
        private Guna.UI2.WinForms.Guna2Button btnTatcaNCC;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiemKH;
        private Guna.UI2.WinForms.Guna2Button btnTaonhacc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button bththemlsp;
        private System.Windows.Forms.Panel pnIfhavedata;
        private System.Windows.Forms.Panel panelIfnodata;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clname;
    }
}