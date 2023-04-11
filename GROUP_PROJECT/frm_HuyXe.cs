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
	public partial class frm_HuyXe : Form
	{
		LopDungChung lopChung = new LopDungChung();
		string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
		string MaKH;
		int MaHopDong;
		public frm_HuyXe()
		{
			InitializeComponent();
		}

		public frm_HuyXe(string MaKH)
		{
			InitializeComponent();
			this.MaKH = MaKH;
		}

		public void loadHopDong(){
			try
			{
				string sql = "SELECT * FROM HopDongChoThue WHERE MaKH = N'"+ this.MaKH + "' AND TrangThai = N'Chờ phê duyệt'";
				lopChung.Connect();
				DataTable dt = lopChung.getData(sql);
				dataGridView1.DataSource = dt;
				try
				{
					dataGridView1.Columns.Remove("MaNhanVien");
					dataGridView1.Columns.Remove("MaKH");
				}
				catch 
				{
				}
				lopChung.close();
			}
			catch
			{
			}
		}

		private void HuyXe_Load(object sender, EventArgs e)
		{
			loadHopDong();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			
			if (index >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[index];
				txt_LoaiXe.Text = row.Cells[2].Value.ToString();
				txt_SoNgaythue.Text = row.Cells[3].Value.ToString();
				txt_DonGia.Text = row.Cells[4].Value.ToString();
				date_NgayDatXe.Text = row.Cells[5].Value.ToString();
				string MaXe = row.Cells[1].Value.ToString();
				this.MaHopDong = int.Parse(row.Cells[0].Value.ToString());

				string sql = "SELECT * FROM XeDuLich WHERE MaXe = N'" + MaXe + "'";
				if (row.Cells[2].Value.ToString() == "Xe Du Lịch")
				{
					sql = "SELECT * FROM XeDuLich WHERE MaXe = N'" + MaXe + "'";
				}
				else if(row.Cells[2].Value.ToString() == "Xe Chở Hàng")
				{
					sql = "SELECT * FROM XeChoHang WHERE MaXe = N'" + MaXe + "'";
				}
				
				try
				{
					lopChung.Connect();
					DataTable dt = lopChung.getData(sql);
					string HinhAnh = dt.Rows[0]["HinhAnh"].ToString();
					txt_TenXe.Text = dt.Rows[0]["TenXe"].ToString();
					pictureBox1.Image = Image.FromFile(duongdan + HinhAnh + ".jpg");
					lopChung.close();
				}
				catch
				{

				}
			}
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
			string sql = "UPDATE HopDongChoThue SET TrangThai = N'Đã hủy' WHERE MaHopDong = " + this.MaHopDong + "";
			try
			{
				lopChung.Connect();
				int ketQua = lopChung.setData(sql);
				if (ketQua >= 1)
				{
					MessageBox.Show("Hủy thành công");
					this.loadHopDong();
					frm_KhachHang datXe = Application.OpenForms["frm_KhachHang"] as frm_KhachHang;
					datXe.LoadDanhSachHopDong();
				}
				lopChung.close();
			}
			catch
			{

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
