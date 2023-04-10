using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GROUP_PROJECT
{
    class LopDungChung
    {
<<<<<<< Updated upstream
		SqlConnection connect;

		public void Connect()
		{
			connect = new SqlConnection(@"Data Source=PROX\SQLEXPRESS01;Initial Catalog=QLXE;Integrated Security=True");
			connect.Open();
		}

		public void close()
		{
			connect.Close();
		}

		public DataTable getData(string sql)
		{
			DataTable table = new DataTable();
			try
			{
				Connect();
				SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
				adapter.Fill(table);
			}
			catch
			{
				table = null;
			}
			finally
			{
				close();
			}

			return table;
		}

		public int setData(string sql)
		{
			try
			{
				Connect();
				SqlCommand command = new SqlCommand(sql, connect);
				return command.ExecuteNonQuery();
			}
			catch
			{
				return -1;
			}
			finally
			{
				close();
			}
		}
	}
=======
        string chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\12doa\source\repos\doan\doan\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }
        public int Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int dem = (int)comm.ExecuteScalar();
            conn.Close();
            return dem;
        }
    }
>>>>>>> Stashed changes
}
