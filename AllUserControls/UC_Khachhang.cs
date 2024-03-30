using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanNuoc.AllUserControls
{
    public partial class UC_Khachhang : UserControl
    {
        Function fn = new Function();
        string query;
        public UC_Khachhang()
        {
            InitializeComponent();
            LoadTotalData();
        }
        private void LoadTotalData()
        {
            query = "SELECT * FROM KHACHHANG";
            DataSet ds = fn.getTotalData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnThemHoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKhachHang = guna2TextBox1.Text.Trim();
                string query = "SELECT * FROM KHACHHANG WHERE TENKH LIKE '%" + tenKhachHang + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
