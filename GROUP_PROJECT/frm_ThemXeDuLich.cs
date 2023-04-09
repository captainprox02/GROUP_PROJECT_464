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
    public partial class frm_ThemXeDuLich : Form
    {
        LopDungChung lopDungChung = new LopDungChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
        public frm_ThemXeDuLich()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh xe du lịch";
            open.Filter = "Tất cả ảnh|*.*|JPEG|*.JPEG|PNG|*.PNG|JPG|*.JPG|BMP|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaXe = txt_MaXe.Text;
            string BienSo = txt_BienSo.Text;
            string TenXe = txt_TenXe.Text;
            int TrongTai;
            DateTime NgayDangKiem = date_NgayDangKiem.Value;
            int TieuChuanBang;
            int SoChoNgoi;

            try
            {
                TrongTai = int.Parse(txt_TrongTai.Text);
            }
            catch
            {

                MessageBox.Show("Hãy nhập trọng tải là một số !");
                return;
            }
            try
            {
                TieuChuanBang = int.Parse(txt_TieuChuanBang.Text);
            }
            catch
            {
                MessageBox.Show("Hãy nhập tiêu chuẩn bằng là một số !");
                return;
            }
            try
            {
                SoChoNgoi = int.Parse(txt_SoChoNgoi.Text);
            }
            catch
            {
                MessageBox.Show("Hãy nhập số chỗ ngồi là một số !");
                return;
            }
            string HinhAnh = DateTime.Now.ToFileTime().ToString();
            //MessageBox.Show(HinhAnh);

            string sql = "INSERT INTO XeDuLich VALUES (N'" + MaXe + "', N'" + BienSo + "', N'" + TenXe + "', " + TrongTai + ", '" + NgayDangKiem + "', " + TieuChuanBang + ", " + SoChoNgoi + ", N'" + HinhAnh + "')";

            try
            {
                lopDungChung.Connect();
                int ketQua = lopDungChung.setData(sql);
                if (ketQua >= 1)
                {
                    pictureBox1.Image.Save(duongdan + HinhAnh + ".jpg");
                    MessageBox.Show("Thêm thành công !");
                    frm_XeDuLich xeDuLich = Application.OpenForms["frm_XeDuLich"] as frm_XeDuLich;
                    xeDuLich.loadXeDuLich();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Bạn muốn đóng chứ ?"), "Đóng", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
