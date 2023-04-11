using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT.BLL
{
	class BLL_DNKH
	{
		DAL.DAL_DNKH Dal_DNKH;
		frm_DangNhapKH DN;
		public BLL_DNKH(frm_DangNhapKH fDNKH)
		{
			Dal_DNKH = new DAL.DAL_DNKH();
			DN = fDNKH;
		}
		public void BLL_DangNhapKH()
		{
			string ketqua = Dal_DNKH.DAL_DangNhapKH(DN.txt_TaiKhoanKH.Text,
				DN.txt_MatKhauKH.Text);
			if (ketqua != null)
			{
				frm_KhachHang KH = new frm_KhachHang(ketqua);
				KH.Show();
				DN.Hide();
			}
			else
				MessageBox.Show("Sai user hoặc pass");
		}
	}
}
