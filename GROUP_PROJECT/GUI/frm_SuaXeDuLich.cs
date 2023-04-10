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

        String HinhAnhMoi = "";

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
        LopDungChung lopDungChung = new LopDungChung();

        BLL.BLL_SuaXeDuLich bll_SuaXeDuLich;

        public frm_SuaXeDuLich()
        {
            InitializeComponent();
            bll_SuaXeDuLich = new BLL.BLL_SuaXeDuLich(this);
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
			bll_SuaXeDuLich = new BLL.BLL_SuaXeDuLich(this);
		}

        private void frm_SuaXeDuLich_Load(object sender, EventArgs e)
        {
            if (MaXe == null || BienSo == null || TenXe == null || TrongTai < 0 || NgayDangKiem == null || TieuChuanBang < 0 || SoChoNgoi < 0 || TenXe == null || HinhAnh == null)
            {
                MessageBox.Show("Hãy chọn xe du lịch cần sửa");
                this.Close();
                return;
            }
            else
            {
                txt_MaXe.Text = MaXe;
                txt_BienSo.Text = BienSo;
                txt_TenXe.Text = TenXe;
                txt_TrongTai.Text = TrongTai.ToString();
                date_NgayDangKiem.Text = NgayDangKiem.ToString();
                txt_TieuChuanBang.Text = TieuChuanBang.ToString();
                txt_SoChoNgoi.Text = SoChoNgoi.ToString();
                try
                {
                    pictureBox1.Image = Image.FromFile(duongdan + HinhAnh + ".jpg");

                }
                catch
                {
                    MessageBox.Show("Không tìm thấy ảnh xe du lịch");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Bạn muốn đóng chứ ?"), "Đóng", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // if (txt_MaXe.Text == "" || txt_BienSo.Text == "" || txt_TenXe.Text == "" || txt_TrongTai.Text == "" || date_NgayDangKiem.Text == "" || txt_TieuChuanBang.Text == "" || txt_SoChoNgoi.Text == "")
            // {
            //     MessageBox.Show("Hãy nhập đầy đủ thông tin");
            //     return;
            // }
            // else
            // {
            //     if (HinhAnhMoi != "")
            //     {
            //         try
            //         {
            //             // if (File.Exists(duongdan + HinhAnh + ".jpg"))
            //             // {
			// 			// 	File.
            //             //     File.Delete(duongdan + HinhAnh + ".jpg");
            //             // }
            //             if (!File.Exists(duongdan + HinhAnhMoi + ".jpg"))
            //             {
            //                 pictureBox1.Image.Save(duongdan + HinhAnhMoi + ".jpg");
            //             }
            //             else
            //             {
            //                 MessageBox.Show("Ảnh đã tồn tại" + HinhAnhMoi + ".jpg");
            //             }
            //         }
            //         catch
            //         {
            //             MessageBox.Show("Không thể lưu ảnh" + HinhAnhMoi + ".jpg");
            //             return;
            //         }
            //     }
            //     try
            //     {
            //         DateTime NgayDangKiem = DateTime.Parse(date_NgayDangKiem.Text);
            //         int TrongTai = int.Parse(txt_TrongTai.Text);
            //         int TieuChuanBang = int.Parse(txt_TieuChuanBang.Text);
            //         int SoChoNgoi = int.Parse(txt_SoChoNgoi.Text);
            //         string MaXe = txt_MaXe.Text;
            //         string BienSo = txt_BienSo.Text;
            //         string TenXe = txt_TenXe.Text;
            //         
			// 		if(HinhAnhMoi != "")
			// 		{
			// 			HinhAnh = HinhAnhMoi;
			// 		}

            //         string sql = "UPDATE XeDuLich SET BienSo = N'" + BienSo + "', TenXe = N'" + TenXe + "', TrongTai = " + TrongTai + ", NgayDangKiem = '" + NgayDangKiem + "', TieuChuanBang = " + TieuChuanBang + ", SoChoNgoi = " + SoChoNgoi + ", HinhAnh = '" + HinhAnh + "' WHERE MaXe = '" + MaXe + "'";

            //         int KetQua = lopDungChung.setData(sql);

            //         if (KetQua > 0)
            //         {
            //             MessageBox.Show("Sửa thành công");
            //             frm_XeDuLich xeDuLich = Application.OpenForms["frm_XeDuLich"] as frm_XeDuLich;
            //             xeDuLich.loadXeDuLich();
            //             this.Close();
            //         }
            //         else
            //         {
            //             MessageBox.Show("Sửa thất bại");
            //         }
            //     }
            //     catch
            //     {
            //         MessageBox.Show("Không thể sửa xe du lịch");
            //         return;
            //     }
            // }
            bll_SuaXeDuLich.SuaXeDuLich(HinhAnhMoi, HinhAnh);

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh xe du lịch";
            open.Filter = "Tất cả ảnh|*.*|JPEG|*.JPEG|PNG|*.PNG|JPG|*.JPG|BMP|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                HinhAnhMoi = DateTime.Now.ToFileTime().ToString();
            }
        }
    }
}
