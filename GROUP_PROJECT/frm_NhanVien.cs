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
	public partial class frm_NhanVien : Form
	{

		string MaNhanVien;

		public frm_NhanVien()
		{
			InitializeComponent();
		}

		public frm_NhanVien(string MaNhanVien)
		{
			InitializeComponent();
			//MessageBox.Show(MaNhanVien);
			this.MaNhanVien = MaNhanVien;
		}

		private void btn_QLXeDuLich_Click(object sender, EventArgs e)
		{
			frm_XeDuLich xeDuLich = new frm_XeDuLich();
			xeDuLich.Show();
		}

		private void btn_QLXeChoHang_Click(object sender, EventArgs e)
		{
			frm_XeChoHang xeChoHang = new frm_XeChoHang();
			xeChoHang.Show();
		}

		private void btn_PheDuyet_Click(object sender, EventArgs e)
		{
			frm_PheDuyetXe pheDuyetXe = new frm_PheDuyetXe(MaNhanVien);
			pheDuyetXe.Show();
		}
	}
}
