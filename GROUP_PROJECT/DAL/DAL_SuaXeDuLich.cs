using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUP_PROJECT.DAL
{
	class DAL_SuaXeDuLich
	{
		LopDungChung lopDungChung = new LopDungChung();


		public Boolean SuaXeDuLich(String MaXe, String BienSo, String TenXe, int TrongTai, DateTime NgayDangKiem, int TieuChuanBang, int SoChoNgoi, String HinhAnh)
		{
			
			 string sql = "UPDATE XeDuLich SET BienSo = N'" + BienSo + "', TenXe = N'" + TenXe + "', TrongTai = " + TrongTai + ", NgayDangKiem = '" + NgayDangKiem + "', TieuChuanBang = " + TieuChuanBang + ", SoChoNgoi = " + SoChoNgoi + ", HinhAnh = '" + HinhAnh + "' WHERE MaXe = '" + MaXe + "'";

			try
			{
				lopDungChung.Connect();
				int ketQua = lopDungChung.setData(sql);
				if (ketQua >= 1)
				{
					return true;

				}
				else
				{
					return false;
				}
			}
			catch (System.Exception)
			{

				throw new System.Exception("Lỗi kết nối");
			}
		}
	}
}
