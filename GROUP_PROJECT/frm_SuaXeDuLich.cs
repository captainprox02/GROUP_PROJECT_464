using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GROUP_PROJECT
{
	public partial class frm_SuaXeDuLich : Form
	{
		String MaXe;
		String BienSo;
		String TenXe;
		int TrongTai;
		DateTime NgayDangKiem;
		int TieuChuanBang;
		int SoChoNgoi;

		String HinhAnh;

		string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";

		public frm_SuaXeDuLich()
		{
			InitializeComponent();
		}

		public frm_SuaXeDuLich(String MaXe, String BienSo, String TenXe, int TrongTai, DateTime NgayDangKiem, int TieuChuanBang, int SoChoNgoi, String HinhAnh)
		{
			InitializeComponent();
			this.MaXe = MaXe;
			this.BienSo = BienSo;
			this.TenXe = TenXe;
			this.TrongTai = TrongTai;
			this.NgayDangKiem = NgayDangKiem;
			this.TieuChuanBang = TieuChuanBang;
			this.SoChoNgoi = SoChoNgoi;
			this.HinhAnh = HinhAnh;
		}

		private void frm_SuaXeDuLich_Load(object sender, EventArgs e)
		{
			if (MaXe == null || BienSo == null || TenXe == null || TrongTai < 0 || NgayDangKiem == null || TieuChuanBang < 0 || SoChoNgoi <0  || TenXe == null || HinhAnh == null)
			{
				MessageBox.Show("Hãy chọn xe du lịch cần sửa");
				this.Close();
				return;
			}else{
				txt_MaXe.Text = MaXe;
				txt_BienSo.Text = BienSo;
				txt_TenXe.Text = TenXe;
				txt_TrongTai.Text = TrongTai.ToString();
				date_NgayDangKiem.Text = NgayDangKiem.ToString();
				txt_TieuChuanBang.Text = TieuChuanBang.ToString();
				txt_SoChoNgoi.Text = SoChoNgoi.ToString();
				try
				{
					pictureBox1.Image = Image.FromFile(duongdan +  HinhAnh + ".jpg");

				}
				catch
				{
					MessageBox.Show("Không tìm thấy ảnh xe du lịch");
				}
			}
		}
	}
}
