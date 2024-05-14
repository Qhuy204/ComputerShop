﻿using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_DSNhanvien : Form
    {
        private BUS_DSNhanvien busNV = new BUS_DSNhanvien();
        private EMPLOYEE nvFromform;

        public GUI_DSNhanvien()
        {
            InitializeComponent();
        }

        private void btnDoichu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn đổi tài khoản chủ sở hữu thành tài khoản này?", "Xác nhận đổi chủ sở hữu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            GUI_ThemNV themnv = new GUI_ThemNV();
            themnv.Show();
        }

        private void GUI_DSNhanvien_Load(object sender, EventArgs e)
        {
            /*cboPosition.DataSource = busPosition.GetAll();
            cboPosition.ValueMember = "Ma";
            cboPosition.DisplayMember = "Ten";
            cboPosition.SelectedIndex = 0;
*/
            UpdateDgv(busNV.GetAll());
        }

        private void UpdateDgv(List<EMPLOYEE> staffList)
        {
            dgvNhanvien.DataSource = staffList.Select(x => new { x.EMP_NAME, x.PS_ID }).ToList();
        }


    }
}
