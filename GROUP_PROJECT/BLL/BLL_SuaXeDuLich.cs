using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GROUP_PROJECT.BLL
{
	class BLL_SuaXeDuLich
	{
		DAL.DAL_SuaXeDuLich dal_SuaXeDuLich = new DAL.DAL_SuaXeDuLich();
		frm_SuaXeDuLich frm;
		string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";

		public BLL_SuaXeDuLich(frm_SuaXeDuLich fS)
		{
			this.frm = fS;
		}

		public void SuaXeDuLich(string HinhAnhMoi, string HinhAnhCu)
		{
			string MaXe = frm.txt_MaXe.Text;
			string BienSo = frm.txt_BienSo.Text;
			string TenXe = frm.txt_TenXe.Text;
			int TrongTai;
			DateTime NgayDangKiem = frm.date_NgayDangKiem.Value;
			int TieuChuanBang;
			int SoChoNgoi;
			
			string HinhAnh;

			if (HinhAnhMoi == "")
			{
				HinhAnh = HinhAnhCu;
			}
			else
			{
				HinhAnh = HinhAnhMoi;
			}

			try
			{
				TrongTai = int.Parse(frm.txt_TrongTai.Text);
			}
			catch
			{

				MessageBox.Show("Hãy nhập trọng tải là một số !");
				return;
			}
			try
			{
				TieuChuanBang = int.Parse(frm.txt_TieuChuanBang.Text);
			}
			catch
			{
				MessageBox.Show("Hãy nhập tiêu chuẩn bằng là một số !");
				return;
			}
			try
			{
				SoChoNgoi = int.Parse(frm.txt_SoChoNgoi.Text);
			}
			catch
			{
				MessageBox.Show("Hãy nhập số chỗ ngồi là một số !");
				return;
			}

			if (dal_SuaXeDuLich.SuaXeDuLich(MaXe, BienSo, TenXe, TrongTai, NgayDangKiem, TieuChuanBang, SoChoNgoi, HinhAnh))
			{
				if (HinhAnhMoi != "")
				{
					frm.pictureBox1.Image.Save(duongdan + HinhAnh + ".jpg");
				}
				MessageBox.Show("Sửa thành công !");
				frm_XeDuLich xeDuLich = Application.OpenForms["frm_XeDuLich"] as frm_XeDuLich;
				xeDuLich.loadXeDuLich();
			}
			else
			{
				MessageBox.Show("Sửa thất bại !");
			}
		}

	}
}
