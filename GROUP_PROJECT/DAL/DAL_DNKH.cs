using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUP_PROJECT.DAL
{
    class DAL_DNKH
    {
        LopDungChung lopchung;
        public DAL_DNKH()
        {
            lopchung = new LopDungChung();
        }
        public string DAL_DangNhapKH(string TenTaiKhoan, string MatKhau)
        {
            string sqlDN = "select * from KhachHang where TenTaiKhoan ='" + TenTaiKhoan + "'and MatKhau='" + MatKhau + "' ";
				DataTable dt =  lopchung.getData(sqlDN);
			if (dt.Rows.Count > 0)
			{
				return dt.Rows[0]["MaKhachHang"].ToString();
			}
			else
			{
				return null;
			}
		}
    }
}
