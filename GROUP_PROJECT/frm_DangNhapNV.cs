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
    public partial class frm_DangNhapNV : Form
    {
        public frm_DangNhapNV()
        {
            InitializeComponent();
        }

        LopDungChung lopchung = new LopDungChung();

        private void btn_DangNhapNV_Click(object sender, EventArgs e)
        {
            string sqlDN = "select count (*) from NhanVien where TenTaiKhoan ='" + txt_DangNhapNV.Text + "'and MatKhau='" + txt_MatKhauNV.Text + "' ";
            int ketqua = lopchung.Scalar(sqlDN);
            if (ketqua >= 1)
            {
                //frm_NhanVien NV = new frm_NhanVien();
                //NV.Show();
                //this.Hide();
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void txt_MatKhauNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DangNhapNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
