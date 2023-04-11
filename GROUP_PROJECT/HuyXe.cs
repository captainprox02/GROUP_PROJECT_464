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
	public partial class HuyXe : Form
	{
		LopDungChung lopChung = new LopDungChung();
		string MaKH;
		public HuyXe()
		{
			InitializeComponent();
		}

		public HuyXe(string MaKH)
		{
			InitializeComponent();
			this.MaKH = MaKH;
		}

		private void HuyXe_Load(object sender, EventArgs e)
		{
			try
			{
				string sql = "SELECT * FROM HopDongChoThue WHERE MaKH = N'"+ this.MaKH +"' AND TrangThai = N'Chờ phê duyệt'";
				lopChung.Connect();
				DataTable dt = lopChung.LoadData(sql);
				dataGridView1.DataSource = dt;
				try
				{
					dataGridView1.Columns.Remove("MaNhanVien");
					dataGridView1.Columns.Remove("MaKH");
				}
				catch 
				{
				}
				lopChung.DisConnect();
			}
			catch
			{
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{

			}
		}
	}
}
