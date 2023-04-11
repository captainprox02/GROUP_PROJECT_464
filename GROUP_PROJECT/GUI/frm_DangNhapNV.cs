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
    public partial class frm_DangNhapNV : Form
    {
		LopDungChung lopchung = new LopDungChung();
		BLL.BLL_DNNV Bll_DNNV;

		public frm_DangNhapNV()
        {
            InitializeComponent();
			Bll_DNNV = new BLL.BLL_DNNV(this);
		}

		private void btn_DangNhapNV_Click(object sender, EventArgs e)
		{
			Bll_DNNV.BLL_DangNhapNV();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frm_DangNhapKH khachHang = new frm_DangNhapKH();
			khachHang.Show();
			this.Hide();
		}
	}
}
