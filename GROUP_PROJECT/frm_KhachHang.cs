using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUP_PROJECT
{
    public partial class frm_KhachHang : Form
    {
        string MaKhachHang;
        LopDungChung lopchung = new LopDungChung();

        public frm_KhachHang()
        {
            InitializeComponent();
        }

        public frm_KhachHang(string MaKhachHang)
        {
            InitializeComponent();
            this.MaKhachHang = MaKhachHang;
            //MessageBox.Show(MaKhachHang);
        }

        private void btn_DatXe_Click(object sender, EventArgs e)
        {
            frm_DatXe datXe = new frm_DatXe(MaKhachHang);
            datXe.Show();
        }

       

        public void LoadDanhSachHopDong()
        {
            string sql = "SELECT * FROM HopDongChoThue where MaKH = '" + this.MaKhachHang + "'";
            DataTable dt = lopchung.getData(sql);
            dataGridView1.DataSource = dt;
            try
            {
                dataGridView1.Columns.Remove("MaNhanVien");
                dataGridView1.Columns.Remove("MaKH");
            }
            catch
            {

            }

        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            if (this.MaKhachHang == null)
            {
                MessageBox.Show("Đã Xảy ra lỗi đăng nhập !");
            }
            else
            {
                LoadDanhSachHopDong();
            }
        }

		private void btn_HuyXe_Click(object sender, EventArgs e)
		{
			frm_HuyXe huyXe = new frm_HuyXe(this.MaKhachHang);
			huyXe.Show();
		}
	}
}
