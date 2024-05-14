﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    public partial class GUI_Dangnhap : Form
    {
        public GUI_Dangnhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text.ToLower() == "admin" && txtMatkhau.Text == "Admin")
            {
                this.Hide();
                GUI_MainForm mf = new GUI_MainForm();
                mf.ShowDialog();
            }
        }

        private void swAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
