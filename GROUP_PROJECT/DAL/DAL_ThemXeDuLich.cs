using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT.DAL
{
	class DAL_ThemXeDuLich
	{
		LopDungChung lopDungChung = new LopDungChung();


		public Boolean ThemXeDuLich(String MaXe,String BienSo,String TenXe,int TrongTai,DateTime NgayDangKiem,int TieuChuanBang,int SoChoNgoi, String HinhAnh)
		{
            string sql = "INSERT INTO XeDuLich VALUES (N'" + MaXe + "', N'" + BienSo + "', N'" + TenXe + "', " + TrongTai + ", '" + NgayDangKiem + "', " + TieuChuanBang + ", " + SoChoNgoi + ", N'" + HinhAnh + "')";

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
