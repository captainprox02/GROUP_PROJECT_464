using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GROUP_PROJECT.BLL
{
	class BLL_ThemXeDuLich
	{
		DAL.DAL_ThemXeDuLich dal_ThemXeDuLich;
        frm_ThemXeDuLich frm;
		string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";

		public BLL_ThemXeDuLich(frm_ThemXeDuLich fT)
		{
			dal_ThemXeDuLich = new DAL.DAL_ThemXeDuLich();
			this.frm = fT;
		}

		public void ThemXeDuLich()
		{
			string MaXe = frm.txt_MaXe.Text;
            string BienSo = frm.txt_BienSo.Text;
            string TenXe = frm.txt_TenXe.Text;
            int TrongTai;
            DateTime NgayDangKiem = frm.date_NgayDangKiem.Value;
            int TieuChuanBang;
            int SoChoNgoi;

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
            string HinhAnh = DateTime.Now.ToFileTime().ToString();
            //MessageBox.Show(HinhAnh);

			if (MaXe == "" || BienSo == "" || TenXe == "" || TrongTai < 0 || NgayDangKiem == null || TieuChuanBang < 0 || SoChoNgoi < 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            
			Boolean ketqua = dal_ThemXeDuLich.ThemXeDuLich(MaXe, BienSo, TenXe, TrongTai, NgayDangKiem, TieuChuanBang, SoChoNgoi, HinhAnh);
			if (ketqua == true)
			{
				frm.pictureBox1.Image.Save(duongdan + HinhAnh + ".jpg");
				MessageBox.Show("Thêm thành công !");
				frm_XeDuLich xeDuLich = Application.OpenForms["frm_XeDuLich"] as frm_XeDuLich;
				xeDuLich.loadXeDuLich();
			}
			else
			{
				MessageBox.Show("Thêm thất bại !");
			}
		}
	}
}
