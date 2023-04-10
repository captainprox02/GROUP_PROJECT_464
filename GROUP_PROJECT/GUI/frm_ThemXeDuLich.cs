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
    public partial class frm_ThemXeDuLich : Form
    {
       
		BLL.BLL_ThemXeDuLich bll_ThemXeDuLich;
        LopDungChung lopDungChung = new LopDungChung();
       
        public frm_ThemXeDuLich()
        {
            InitializeComponent();
			bll_ThemXeDuLich = new BLL.BLL_ThemXeDuLich(this);
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
			bll_ThemXeDuLich.ThemXeDuLich();
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
