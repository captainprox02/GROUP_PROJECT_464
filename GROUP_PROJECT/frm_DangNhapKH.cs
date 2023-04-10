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

		public frm_DangNhapKH()
        {
            InitializeComponent();
        }

		private void btn_DangNhapKH_Click(object sender, EventArgs e)
		{
			string sqlDN = "select count (*) from KhachHang where TenTaiKhoan ='" + txt_TaiKhoanKH.Text + "'and MatKhau='" + txt_MatKhauKH.Text + "' ";
			int ketqua = lopchung.Scalar(sqlDN);
			if (ketqua >= 1)
			{
				frm_KhachHang SV = new frm_KhachHang();
				SV.Show();
				this.Hide();
			}
			else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
		}
	}
}
