using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUP_PROJECT.DAL
{
    class DAL_DNNV
    {
        LopDungChung lopchung;
        public DAL_DNNV()
        {
            lopchung = new LopDungChung();
        }
        public string DAL_DangNhapNV(string TenTaiKhoan, string MatKhau)
        {
            string sqlDN = "select * from NhanVien where TenTaiKhoan ='" + TenTaiKhoan + "'and MatKhau='" + MatKhau + "' ";
            DataTable dt = lopchung.getData(sqlDN);
			if (dt.Rows.Count > 0)
			{
				return dt.Rows[0]["MaNhanVien"].ToString();
			}
			else
			{
				return null;
			}
		}
    }
}
