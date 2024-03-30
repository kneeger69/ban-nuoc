using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanNuoc
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database = QLQN; integrated security = True";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con =  getConnection();
            SqlCommand cmd =  new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Cap nhat co so du lieu thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
