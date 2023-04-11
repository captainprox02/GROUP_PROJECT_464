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
    public partial class frm_XeChoHang : Form
    {
        LopDungChung lopDungChung = new LopDungChung();

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
		string hinhAnh = "";

        public frm_XeChoHang()
        {
            InitializeComponent();           
        }

        public void loadXeChoHang()
        {
            string sql = "SELECT * FROM XeChoHang";
            try
            {
                lopDungChung.Connect();
                lopDungChung.getData(sql);

                DataTable dt = lopDungChung.getData(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                lopDungChung.close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu");
            }
        }

        private void frm_XeChoHang_Load(object sender, EventArgs e)
        {
            loadXeChoHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemXeChoHang themXeChoHang = new frm_ThemXeChoHang();
            themXeChoHang.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                txt_MaXe.Text = row.Cells[0].Value.ToString();
                txt_BienSo.Text = row.Cells[1].Value.ToString();
                txt_TenXe.Text = row.Cells[2].Value.ToString();
                txt_TrongTai.Text = row.Cells[3].Value.ToString();
                date_NgayDangKiem.Text = row.Cells[4].Value.ToString();
                txt_TieuChuanBang.Text = row.Cells[5].Value.ToString();
                txt_SoTan.Text = row.Cells[6].Value.ToString();
                try
                {
                    pictureBox1.Image = Image.FromFile(duongdan + row.Cells[7].Value.ToString() + ".jpg");
                    hinhAnh = row.Cells[7].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy ảnh xe du lịch");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                String MaXe = txt_MaXe.Text;
                String BienSo = txt_BienSo.Text;
                String TenXe = txt_TenXe.Text;
                int TrongTai = int.Parse(txt_TrongTai.Text);
                DateTime NgayDangKiem = date_NgayDangKiem.Value;
                int TieuChuanBang = int.Parse(txt_TieuChuanBang.Text);
                int SoTan = int.Parse(txt_SoTan.Text);
                String HinhAnh = hinhAnh;

                frm_SuaXeChoHang suaXeChoHang = new frm_SuaXeChoHang(MaXe, BienSo, TenXe, TrongTai, NgayDangKiem, TieuChuanBang, SoTan, HinhAnh);
                suaXeChoHang.Show();
            }
            catch
            {
                MessageBox.Show("Hãy chọn xe cần sửa !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MaXe = txt_MaXe.Text;
            if (MaXe != "" && MaXe != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa xe này không ?", "Xóa", MessageBoxButtons.YesNo))
                {
                    string sql = "DELETE FROM XeChoHang WHERE MaXe = '" + MaXe + "'";
                    try
                    {
                        lopDungChung.Connect();
                        int ketqua = lopDungChung.setData(sql);
                        if (ketqua >= 1)
                        {
                            MessageBox.Show("Xóa thành công");
                            loadXeChoHang();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                        lopDungChung.close();
                    }
                    catch (System.Exception)
                    {

                        throw new System.Exception("Không thể kết nối đến cơ sở dữ liệu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn xe cần xóa !");
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
