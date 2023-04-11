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
	public partial class frm_DatXe : Form
	{

		LopDungChung lopDungChung = new LopDungChung();
		
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
		String MaKH;
		public frm_DatXe()
		{
			InitializeComponent();
		}

		public frm_DatXe(string MaKH)
		{
			InitializeComponent();
			this.MaKH = MaKH;
		}


		private void loadXeDuLich(){
			try
			{
				lopDungChung.Connect();
				string sql = "select * from XeDuLich";
				DataTable dt = lopDungChung.getData(sql);
				cb_Xe.DataSource = dt;
				cb_Xe.DisplayMember = "TenXe";
				cb_Xe.ValueMember = "MaXe";
				lopDungChung.close();
			}
			catch 
			{
				
				MessageBox.Show("Lỗi kết nối");
			}
		}

		private void loadXeChoHang(){
			try
			{
				lopDungChung.Connect();
				string sql = "select * from XeChoHang";
				DataTable dt = lopDungChung.getData(sql);
				cb_Xe.DataSource = dt;
				cb_Xe.DisplayMember = "TenXe";
				cb_Xe.ValueMember = "MaXe";
				lopDungChung.close();
			}
			catch 
			{
				MessageBox.Show("Lỗi kết nối");
			}
		}

		private void cb_LoaiXe_SelectedIndexChanged(object sender, EventArgs e)
		{
			string LoaiXe = cb_LoaiXe.SelectedItem.ToString();
			if (LoaiXe == "Xe Du Lịch")
			{
				loadXeDuLich();
			}
			else if (LoaiXe == "Xe Chở Hàng")
			{
				loadXeChoHang();
			}
		}

		private int SoNgayThueXe(){
			int SoNgayThueXe = 0;
			DateTime NgayBatDau = date_NgayDatXe.Value;
			DateTime NgayKetThuc = date_NgayKetThuc.Value;
			TimeSpan timeSpan = NgayKetThuc - NgayBatDau;
			SoNgayThueXe = (int)Math.Ceiling(timeSpan.TotalDays);
			//MessageBox.Show(SoNgayThueXe.ToString());
			return SoNgayThueXe + 1;
		}

		private void TinhTienThueXe(){
			string MaXe = cb_Xe.SelectedValue.ToString();
			string LoaiXe = cb_LoaiXe.SelectedItem.ToString(); 

			int DonGia = 0;
			// MessageBox.Show(MaXe);

			try
			{
				if (LoaiXe == "Xe Du Lịch")
				{
					string sql = "select * from XeDuLich where MaXe = '" + MaXe + "'";
					lopDungChung.Connect();
					DataTable dt = lopDungChung.getData(sql);
					pictureBox1.Image = Image.FromFile(duongdan + dt.Rows[0]["HinhAnh"].ToString() + ".jpg");
					int SoChoNgoi = int.Parse(dt.Rows[0]["SoChoNgoi"].ToString());
					if (SoChoNgoi <= 5)
					{
						DonGia = 500000;
					}else if(SoChoNgoi <= 7){
						DonGia = 700000;
					}else{
						DonGia = 1000000;
					}

					int ThanhTien = this.SoNgayThueXe() * DonGia;

					txt_DonGia.Text = ThanhTien.ToString();
					lopDungChung.close();
				}else if(LoaiXe == "Xe Chở Hàng")
				{
					string sql = "select * from XeChoHang where MaXe = '" + MaXe + "'";
					lopDungChung.Connect();
					DataTable dt = lopDungChung.getData(sql);
					pictureBox1.Image = Image.FromFile(duongdan + dt.Rows[0]["HinhAnh"].ToString() + ".jpg");
					int ThanhTien = this.SoNgayThueXe() * 500000;

					txt_DonGia.Text = ThanhTien.ToString();
					lopDungChung.close();
				}
			}
			catch 
			{
				// MessageBox.Show("Lỗi kết nối");
			}
		}

		private void cb_Xe_SelectedIndexChanged(object sender, EventArgs e)
		{
			TinhTienThueXe();
		}

		private void date_NgayDatXe_ValueChanged(object sender, EventArgs e)
		{
			TinhTienThueXe();
		}

		private void date_NgayKetThuc_ValueChanged(object sender, EventArgs e)
		{
			TinhTienThueXe();
		}

		private void btn_DatXe_Click(object sender, EventArgs e)
		{
			
			string MaXe = cb_Xe.SelectedValue.ToString();
			string LoaiXe = cb_LoaiXe.SelectedItem.ToString();
			int SoNgayThueXe = this.SoNgayThueXe();
			double DonGia = double.Parse(txt_DonGia.Text);
			string NgayDatXe = date_NgayDatXe.Value.ToString("MM-dd-yyyy");

			string sql = "insert into HopDongChoThue(MaKH, MaXe, LoaiXe, SoNgayThue, DonGia, NgayThue) values (N'" + this.MaKH + "', N'" + MaXe + "', N'" + LoaiXe + "', " + SoNgayThueXe + ", " + DonGia + ", '" + NgayDatXe + "')";
			try
			{
				//MessageBox.Show(MaKH);
				lopDungChung.Connect();
				int ketQua =  lopDungChung.setData(sql);
				if (ketQua >= 0)
				{
					MessageBox.Show("Đặt xe thành công");
					frm_KhachHang datXe = Application.OpenForms["frm_KhachHang"] as frm_KhachHang;
					datXe.LoadDanhSachHopDong();
				}
				else
				{
					MessageBox.Show("Đặt xe thất bại!");
				}
				lopDungChung.close();
			}
			catch 
			{
				MessageBox.Show("Lỗi kết nối");
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
