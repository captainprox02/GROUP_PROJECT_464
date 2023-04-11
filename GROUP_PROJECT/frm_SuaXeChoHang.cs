using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT
{
    public partial class frm_SuaXeChoHang : Form
    {
        String MaXe;
        String BienSo;
        String TenXe;
        int TrongTai;
        DateTime NgayDangKiem;
        int TieuChuanBang;
        int SoTan;

        String HinhAnh;

        String HinhAnhMoi = "";

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
        LopDungChung lopDungChung = new LopDungChung();

        public frm_SuaXeChoHang(String MaXe, String BienSo, String TenXe, int TrongTai, DateTime NgayDangKiem, int TieuChuanBang, int SoTan, String HinhAnh)
        {
            InitializeComponent();
            this.MaXe = MaXe;
            this.BienSo = BienSo;
            this.TenXe = TenXe;
            this.TrongTai = TrongTai;
            this.NgayDangKiem = NgayDangKiem;
            this.TieuChuanBang = TieuChuanBang;
            this.SoTan = SoTan;
            this.HinhAnh = HinhAnh;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Bạn muốn đóng chứ ?"), "Đóng", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void frm_SuaXeChoHang_Load(object sender, EventArgs e)
        {
            if (MaXe == null || BienSo == null || TenXe == null || TrongTai < 0 || NgayDangKiem == null || TieuChuanBang < 0 || SoTan < 0 || TenXe == null || HinhAnh == null)
            {
                MessageBox.Show("Hãy chọn xe chở hàng cần sửa");
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
                txt_SoTan.Text = SoTan.ToString();
                try
                {
                    pictureBox1.Image = Image.FromFile(duongdan + HinhAnh + ".jpg");

                }
                catch
                {
                    MessageBox.Show("Không tìm thấy ảnh xe chở hàng");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (txt_MaXe.Text == "" || txt_BienSo.Text == "" || txt_TenXe.Text == "" || txt_TrongTai.Text == "" || date_NgayDangKiem.Text == "" || txt_TieuChuanBang.Text == "" || txt_SoTan.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            else
            {
                if (HinhAnhMoi != "")
                {
                    try
                    {
                        // if (File.Exists(duongdan + HinhAnh + ".jpg"))
                        // {
                        // 	File.
                        //     File.Delete(duongdan + HinhAnh + ".jpg");
                        // }
                        if (!File.Exists(duongdan + HinhAnhMoi + ".jpg"))
                        {
                            pictureBox1.Image.Save(duongdan + HinhAnhMoi + ".jpg");
                        }
                        else
                        {
                            MessageBox.Show("Ảnh đã tồn tại" + HinhAnhMoi + ".jpg");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không thể lưu ảnh" + HinhAnhMoi + ".jpg");
                        return;
                    }
                }
                try
                {
                    DateTime NgayDangKiem = DateTime.Parse(date_NgayDangKiem.Text);
                    int TrongTai = int.Parse(txt_TrongTai.Text);
                    int TieuChuanBang = int.Parse(txt_TieuChuanBang.Text);
                    int SoTan = int.Parse(txt_SoTan.Text);
                    string MaXe = txt_MaXe.Text;
                    string BienSo = txt_BienSo.Text;
                    string TenXe = txt_TenXe.Text;
                    string HinhAnh = this.HinhAnh;
                    if (HinhAnhMoi != "")
                    {
                        HinhAnh = HinhAnhMoi;
                    }

                    string sql = "UPDATE XeChoHang SET BienSo = N'" + BienSo + "', TenXe = N'" + TenXe + "', TrongTai = " + TrongTai + ", NgayDangKiem = '" + NgayDangKiem + "', TieuChuanBang = " + TieuChuanBang + ", SoTan = " + SoTan + ", HinhAnh = '" + HinhAnh + "' WHERE MaXe = '" + MaXe + "'";

                    int KetQua = lopDungChung.setData(sql);

                    if (KetQua > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        frm_XeChoHang xeChoHang = Application.OpenForms["frm_XeChoHang"] as frm_XeChoHang;
                        xeChoHang.loadXeChoHang();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa xe chở hàng");
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh xe chở hàng";
            open.Filter = "Tất cả ảnh|*.*|JPEG|*.JPEG|PNG|*.PNG|JPG|*.JPG|BMP|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                HinhAnhMoi = DateTime.Now.ToFileTime().ToString();
            }
        }
    }
}
