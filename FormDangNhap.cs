﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DATN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            if (textBoxTenDN.Text == "BuiThiDieuLinh" && textBoxMatKhau.Text == "123456")
            {
                ClassDN.dangnhap = true;
            }
            else
            {
                ClassDN.dangnhap = false;
            }
            this.Close();
        }
    }
}
