using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT.BLL
{
    class BLL_DNNV
    {
        DAL.DAL_DNNV Dal_DNNV;
        frm_DangNhapNV DN;
        public BLL_DNNV(frm_DangNhapNV fDNNV)
        {
            Dal_DNNV = new DAL.DAL_DNNV();
            DN = fDNNV;
        }
        public void BLL_DangNhapNV()
        {
            string ketqua = Dal_DNNV.DAL_DangNhapNV(DN.txt_DangNhapNV.Text,
                DN.txt_MatKhauNV.Text);
            if (ketqua != null)
            {
                frm_NhanVien NV = new frm_NhanVien(ketqua);
                NV.Show();
                DN.Hide();
            }
            else
                MessageBox.Show("Sai user hoặc pass");
        }
    }
}
