using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT
{
    public partial class frm_DangNhapKH : Form
    {
		LopDungChung lopchung = new LopDungChung();
		BLL.BLL_DNKH Bll_DNKH;

		public frm_DangNhapKH()
        {
            InitializeComponent();
			Bll_DNKH = new BLL.BLL_DNKH(this);
        }

		private void btn_DangNhapKH_Click(object sender, EventArgs e)
		{
			Bll_DNKH.BLL_DangNhapKH();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frm_DangNhapNV nhanVien = new frm_DangNhapNV();
			nhanVien.Show();
			this.Hide();
		}
	}
}
