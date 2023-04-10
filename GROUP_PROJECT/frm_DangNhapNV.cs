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

		public frm_DangNhapNV()
        {
            InitializeComponent();
        }

		private void btn_DangNhapNV_Click(object sender, EventArgs e)
		{
			string sqlDN = "select count (*) from NhanVien where TenTaiKhoan ='" + txt_DangNhapNV.Text + "'and MatKhau='" + txt_MatKhauNV.Text + "' ";
			int ketqua = lopchung.Scalar(sqlDN);
			if (ketqua >= 1)
			{
				frm_NhanVien NV = new frm_NhanVien();
				NV.Show();
				this.Hide();
			}
			else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
		}
	}
}
